using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure
{
    public class DischargeSheetModify
    {
        public void InpatientSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" CREATE procedure sp_InpatientSelect ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select top 100 a.ipdno, a.hospid, h.fileno, a.ddate, a.firm, a.userid, a.amount, a.posted, a.member, a.discharge, a.ddate as admit_date, ");
            s.Append(" a.discharge_date, a.refid, d.referer, a.em_code, ");
            s.Append(" a.bedno, b.pname, b.ref_code, b.address,datediff(year, dob,getdate()) as age, b.sex, b.telephone,b.contact, ");
            s.Append(" b.ac_code as member_code, b.payfrom, c.ac_code, b.MartialStatus, b.Occupation, ");
            s.Append(" b.dob, b.p_type, b.orgid, b.m_type, c.orgname, c.pharma_disc1, c.pharma_disc2, a.Foreigner, a.discount_id, ");
            s.Append(" e.discount_name, e.notify, a.ipd_locked, a.ipd_crlimit, a.consid, f.referer as consultant, a.dpid, g.groupname, d.telephone as ref_tel, b.regno, c.insurance, b.policyid, a.claim_code ");
            s.Append(" from inpatient a with (nolock) ");
            s.Append(" left join member b with (nolock) on a.hospid=b.hospid ");
            s.Append(" left join organiz c with (nolock) on b.orgid=c.orgid ");
            s.Append(" left join referer d with (nolock) on a.refid=d.refid ");
            s.Append(" left join discount_name e on a.discount_id=e.discount_id ");
            s.Append(" left join referer F with (nolock) on a.consid=F.refid ");
            s.Append(" left join division g with (nolock) on a.dpid=g.dp_id ");
            s.Append(" left join PatientFileNo h with (nolock) on a.hospid=h.hospid ");
            s.Append(" where 1=1 and a.ipdno= case when 0=0 then a.ipdno else 0 end ");
            s.Append(" and discharge=0 ");
            s.Append(" Order by a.discharge, b.pname ");
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

        public void RefererSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DischargeSheetRefererSelect ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.*, b.detail from referer a with (nolock) left join speciality b with (nolock) on a.sp_id=b.sp_id ");
            s.Append(" where a.referer like '%%' ");
            s.Append(" AND a.status='Active' ");
            s.Append(" order by referer ");
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

        public void DischargeSheetSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DischargeSheetSelectByInvno @inv_no varchar(11) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.*, c.pname, c.address, b.bedno, b.ageday, c.telephone, d.bs_date,l.particular as ward, ");
            s.Append(" h.ddate as ad_discharge_date, i.bs_date as bs_discharge_date, ");
            s.Append(" b.ddate as ad_admit_date, b.contact, h.dischargeno, ");
            s.Append(" e.bs_date as bs_admit_date, f.referer, g.username, j.bs_date as bs_operation_date, ");
            s.Append(" m.referer as consultant, m.regno as cons_nmc, o.bs_date as cons_bs_Date, ");
            s.Append(" n.referer as medical, n.regno as medi_nmc, p.bs_date as medi_bs_date, c.sex, ");
            s.Append(" q.referer as consultant1, q.regno as cons_nmc1, r.bs_date as cons_bs_date1 ");
            s.Append(" from discharge_sheet a ");
            s.Append(" left join inpatient b on a.ipdno=b.ipdno ");
            s.Append(" left join member c on b.hospid=c.hospid ");
            s.Append(" left join calendar d on a.ddate=d.ad_date ");
            s.Append(" left join calendar e on b.ddate=e.ad_date ");
            s.Append(" left join referer f on a.refid=f.refid ");
            s.Append(" left join userlist g on a.userid=g.userid ");
            s.Append(" left join discharge h on a.ipdno=h.ipdno ");
            s.Append(" left join calendar i on h.ddate=i.ad_date ");
            s.Append(" left join calendar j on a.operation_date=j.ad_date ");
            s.Append(" left join bedrack k on b.bedno=k.bedno ");
            s.Append(" left join ward l on k.wardno=l.wardno ");
            s.Append(" left join referer m on a.consid=m.refid ");
            s.Append(" left join referer n on a.mediid=n.refid ");
            s.Append(" left join calendar o on a.cons_date=o.ad_date ");
            s.Append(" left join calendar p on a.medi_date=p.ad_date ");
            s.Append(" left join referer q on a.consid1=q.refid ");
            s.Append(" left join calendar r on a.cons_date1=R.ad_date ");
            s.Append(" where a.inv_no=@inv_no ");
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

        public void DischargeSheetInsert()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DischargeSheetInsert( ");
            s.Append(" @ddate datetime , ");
            s.Append(" @inv_no varchar(11) , ");
            s.Append(" @ipdno int , ");
            s.Append(" @refid int , ");
            s.Append(" @admit_date datetime , ");
            s.Append(" @discharge_date datetime , ");
            s.Append(" @userid int , ");
            s.Append(" @firm int , ");
            s.Append(" @fy varchar(1) , ");
            s.Append(" @billtime varchar(15) , ");
            s.Append(" @NOTE1 text , ");
            s.Append(" @NOTE2 text , ");
            s.Append(" @NOTE3 text , ");
            s.Append(" @NOTE4 text , ");
            s.Append(" @NOTE5 text , ");
            s.Append(" @NOTE6 text , ");
            s.Append(" @NOTE7 text , ");
            s.Append(" @note8 text , ");
            s.Append(" @note9 text , ");
            s.Append(" @note10 text , ");
            s.Append(" @operation text , ");
            s.Append(" @operation_date datetime , ");
            s.Append(" @note11 text , ");
            s.Append(" @note12 text , ");
            s.Append(" @note13 text , ");
            s.Append(" @note14 text , ");
            s.Append(" @note15 text , ");
            s.Append(" @note16 text , ");
            s.Append(" @note17 text , ");
            s.Append(" @note18 text , ");
            s.Append(" @note19 text , ");
            s.Append(" @consid int , ");
            s.Append(" @cons_date datetime , ");
            s.Append(" @mediid int , ");
            s.Append(" @medi_date datetime , ");
            s.Append(" @consid1 int , ");
            s.Append(" @cons_date1 datetime ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into discharge_sheet ( ");
            s.Append(" ddate , ");
            s.Append(" inv_no , ");
            s.Append(" ipdno , ");
            s.Append(" refid , ");
            s.Append(" admit_date , ");
            s.Append(" discharge_date , ");
            s.Append(" userid , ");
            s.Append(" firm , ");
            s.Append(" fy , ");
            s.Append(" billtime , ");
            s.Append(" NOTE1 , ");
            s.Append(" NOTE2 , ");
            s.Append(" NOTE3 , ");
            s.Append(" NOTE4 , ");
            s.Append(" NOTE5 , ");
            s.Append(" NOTE6 , ");
            s.Append(" NOTE7 , ");
            s.Append(" note8 , ");
            s.Append(" note9 , ");
            s.Append(" note10 , ");
            s.Append(" operation , ");
            s.Append(" operation_date , ");
            s.Append(" note11 , ");
            s.Append(" note12 , ");
            s.Append(" note13 , ");
            s.Append(" note14 , ");
            s.Append(" note15 , ");
            s.Append(" note16 , ");
            s.Append(" note17 , ");
            s.Append(" note18 , ");
            s.Append(" note19 , ");
            s.Append(" consid , ");
            s.Append(" cons_date , ");
            s.Append(" mediid , ");
            s.Append(" medi_date , ");
            s.Append(" consid1 , ");
            s.Append(" cons_date1 ");
            s.Append(" ) ");
            s.Append(" values( ");
            s.Append(" @ddate , ");
            s.Append(" @inv_no , ");
            s.Append(" @ipdno , ");
            s.Append(" @refid , ");
            s.Append(" @admit_date , ");
            s.Append(" @discharge_date , ");
            s.Append(" @userid , ");
            s.Append(" @firm , ");
            s.Append(" @fy , ");
            s.Append(" @billtime , ");
            s.Append(" @NOTE1 , ");
            s.Append(" @NOTE2 , ");
            s.Append(" @NOTE3 , ");
            s.Append(" @NOTE4 , ");
            s.Append(" @NOTE5 , ");
            s.Append(" @NOTE6 , ");
            s.Append(" @NOTE7 , ");
            s.Append(" @note8 , ");
            s.Append(" @note9 , ");
            s.Append(" @note10 , ");
            s.Append(" @operation , ");
            s.Append(" @operation_date , ");
            s.Append(" @note11 , ");
            s.Append(" @note12 , ");
            s.Append(" @note13 , ");
            s.Append(" @note14 , ");
            s.Append(" @note15 , ");
            s.Append(" @note16 , ");
            s.Append(" @note17 , ");
            s.Append(" @note18 , ");
            s.Append(" @note19 , ");
            s.Append(" @consid , ");
            s.Append(" @cons_date , ");
            s.Append(" @mediid , ");
            s.Append(" @medi_date , ");
            s.Append(" @consid1 , ");
            s.Append(" @cons_date1 ");
            s.Append(" ) ");
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