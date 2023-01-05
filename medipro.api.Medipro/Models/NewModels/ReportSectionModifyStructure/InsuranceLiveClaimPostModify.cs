using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class InsuranceLiveClaimPostModify
    {
        public void InsuranceClaimPost()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_SSFPatientSalesList @init datetime, @final datetime, @policyid varchar(100) , ");
            s.Append(" @ipd bit, @ssf bit, @posted int, @claim_code VARCHAR(20), @search varchar(200) ");
            s.Append(" as ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" declare @new_init datetime, @new_final datetime ");
            s.Append(" set @new_init= case when @ipd=1 or @policyid<>'0' then '2000/01/01' else @Init end ");
            s.Append(" set @new_final= case when @ipd=1 or @policyid<>'0' then convert(varchar, getdate()+1, 111) else @final end ");
            s.Append(" select * into #temp_opdbill from opdbill a where insurance=1 and ( ddate between @new_init and @new_final ) and a.claim_code= case when @claim_code=0 then a.claim_code else @claim_code end ");
            s.Append(" select * into #temp_sales_insurance FROM sales_insurance a where insurance=1 and ( ddate between @new_init and @new_final ) and a.claim_code= case when @claim_code=0 then a.claim_code else @claim_code end ");
            s.Append(" select a.* ");
            s.Append(" INTO #TEMP ");
            s.Append(" from ( ");
            s.Append(" select case when isnull(d.ipdno,0)>0 then 1 else 0 end as ipd, isnull(d.ipdno,0) as ipdno, isnull(z.ssf,0) as ssf, ");
            s.Append(" z.claim_code, z.scheme_id, z.ssf_claim_id, z.scheme_product_id, z.ddate, z.icdcode, z.ssf_claim_code, z.ssf_post, z.ssf_claim_post, z.outcome, ");
            s.Append(" case when ISNULL(b.min_ddate,C.MIN_DDATE)>c.min_ddate then c.min_ddate else ISNULL(b.min_ddate,C.MIN_DDATE) end as min_date, ");
            s.Append(" case when ISNULL(b.max_ddate,C.MAX_DDATE)>c.max_ddate then c.max_ddate else ISNULL(b.max_ddate,C.MAX_DDATE) end as max_date, ");
            s.Append(" a.policyid, a.hospid, a.pname, a.ADDRESS, isnull(b.amt,0)+isnull(c.amt,0) as net, ");
            s.Append(" isnull(b.cnt,0) as service_bill, isnull(c.cnt,0) as pharmacy_bill, y.id as uuid ");
            s.Append(" ,Z.EmployerId ,Z.Admitted ,Z.WoundCondition ,Z.InjuredBodyPart ,Z.IsDisable ,Z.IsDead ,Z.AccidentDescription ,Z.ReasonOfSickness ");
            s.Append(" ,Z.DischargeType ,Z.DischargeSummary ,Z.DischargeDate ,Z.Cancer ,Z.HIV ,Z.HeartAttack ,Z.HighBp ,Z.Diabetes ");
            s.Append(" from member a ");
            s.Append(" left join InsuranceClaimCode z on a.hospid=z.hospid ");
            s.Append(" left join ssf_patient y on a.policyid=y.ssf_identity ");
            s.Append(" left join ");
            s.Append(" ( ");
            s.Append(" select claim_code, min(ddate) as min_ddate, max(ddate) as max_ddate, count(*) as cnt, hospid, sum(amount-discount+vat-roundoff) as amt ");
            s.Append(" from #temp_opdbill ");
            s.Append(" where insurance=1 ");
            s.Append(" and ddate between @new_init and @new_final and ipd=@ipd ");
            s.Append(" group by hospid, claim_code ");
            s.Append(" ) b on a.hospid=b.hospid and b.claim_code=z.claim_code ");
            s.Append(" left join ");
            s.Append(" ( ");
            s.Append(" select a.claim_code, min(a.ddate) as min_ddate, max(a.ddate) as max_ddate, count(*) as cnt, c.hospid, sum(a.amount-a.discount+a.vat-a.roundoff) as amt ");
            s.Append(" from #temp_sales_insurance a left join member_insurance b on a.hospid=b.hospid left join member c on b.policyid=c.policyid ");
            s.Append(" where a.insurance=1 ");
            s.Append(" and a.ddate between @new_init and @new_final and ipd=@ipd ");
            s.Append(" group by c.hospid, a.claim_code ");
            s.Append(" ) c on a.hospid=c.hospid and c.claim_code=ltrim(str(z.claim_code)) ");
            s.Append(" left join ");
            s.Append(" ( ");
            s.Append(" select b.claim_code, b.hospid, a.* ");
            s.Append(" From discharge a ");
            s.Append(" left join inpatient b on a.ipdno=b.ipdno ");
            s.Append(" left join member c on b.hospid=c.hospid ");
            s.Append(" left join ORGANIZ d on c.orgid=d.orgid ");
            s.Append(" where a.ddate between @init and @final and d.insurance=1 ");
            s.Append(" ) d on a.hospid=d.hospid and d.claim_code=z.claim_code ");
            s.Append(" where a.policyid= case when @policyid='0' then a.policyid else @policyid end ");
            s.Append(" ) a where ");
            s.Append(" ( a.service_bill>0 or a.pharmacy_bill>0 ) and ");
            s.Append(" isnull(a.ssf,0)=@ssf ");
            s.Append(" and isnull(a.ipd,0)=@ipd ");
            s.Append(" and isnull(a.ssf_claim_post,0) = case when @posted=2 then isnull(a.ssf_claim_post,0) else @posted end ");
            s.Append(" and a.claim_code= case when @claim_code=0 then a.claim_code else @claim_code end ");
            s.Append(" order by a.claim_code ");
            s.Append(" SELECT * fROM #TEMP where claim_code like '%'+@SEARCH+'%' or pname like '%'+@SEARCH+'%' ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }
    }
}