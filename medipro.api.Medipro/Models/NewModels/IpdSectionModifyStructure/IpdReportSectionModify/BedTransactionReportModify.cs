using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdReportSectionModify
{
    public class BedTransactionReportModify
    {
        public void BedTransInPatientSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_InpatientSelectForBedTransactionReport ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select top 100 a.ipdno, a.hospid, h.fileno, a.ddate, a.firm, a.userid, a.amount, a.posted, a.member, a.discharge, a.ddate as admit_date, ");
            s.Append(" a.discharge_date, a.refid, d.referer, a.em_code, ");
            s.Append(" a.bedno, b.pname, b.ref_code, b.address,datediff(year, dob,getdate()) as age, b.sex, b.telephone,b.contact, ");
            s.Append(" b.ac_code as member_code, b.payfrom, c.ac_code, b.MartialStatus, b.Occupation, ");
            s.Append(" b.dob, b.p_type, b.orgid, b.m_type, c.orgname, c.pharma_disc1, c.pharma_disc2, a.Foreigner, a.discount_id, ");
            s.Append(" e.discount_name, e.notify, a.ipd_locked, a.ipd_crlimit, a.consid, f.referer as consultant, a.dpid, g.groupname, d.telephone as ref_tel, ");
            s.Append(" b.regno, c.insurance, b.ssf, b.policyid, a.claim_code, c.insurance_product ");
            s.Append(" from inpatient a with (nolock) ");
            s.Append(" left join member b with (nolock) on a.hospid=b.hospid ");
            s.Append(" left join organiz c with (nolock) on b.orgid=c.orgid ");
            s.Append(" left join referer d with (nolock) on a.refid=d.refid ");
            s.Append(" left join discount_name e on a.discount_id=e.discount_id ");
            s.Append(" left join referer F with (nolock) on a.consid=F.refid ");
            s.Append(" left join division g with (nolock) on a.dpid=g.dp_id ");
            s.Append(" left join PatientFileNo h with (nolock) on a.hospid=h.hospid ");
            s.Append(" where 1=1 and a.ipdno= case when 0=0 then a.ipdno else 0 end ");
            s.Append(" Order by a.discharge, a.ddate desc, b.pname ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");



            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }



        public void BedTransactionReport()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_BedTransactionReport (@ipdno int, @ddate datetime) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.*, b.bs_date, d.particular as ward, (select 'Y' from bedrec where bedrec.sn=sn) as book ");
            s.Append(" from bedrec a left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join bedrack c on a.bedno=c.bedno ");
            s.Append(" left join ward d on c.wardno=d.wardno ");
            s.Append(" where a.ipdno=@ipdno and ddate<=@ddate ");
            s.Append(" order by ddate, billtime ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");



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