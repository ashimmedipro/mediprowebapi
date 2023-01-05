using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdBillingSectionModify
{
    public class BedTransferModify
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

        public void BedRackPartSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_BedrackParticularSelect @bedno varchar(15) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select particular from bedrack a left join ward b on a.wardno=b.wardno where a.bedno=@bedno ");
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

        public void BedRackSelect()
        {
            StringBuilder s = new StringBuilder();

            

            s.Append(" create procedure sp_BedrackSelect ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.*, b.particular, d.pname, e.bs_date, (select 'Y' from bedrack where a.bedno=bedno and booked=1 ) as book ");
            s.Append(" from ");
            s.Append(" bedrack a left join ward b on a.wardno=b.wardno ");
            s.Append(" left join inpatient c on a.ipdno=c.ipdno ");
            s.Append(" left join member d on c.hospid=d.hospid ");
            s.Append(" left join calendar e on a.admitdate=e.ad_date and a.ipdno>0 where a.remarkstype<>'Inactive' and a.bedno like '%%' or d.pname like '%%' ");
            s.Append(" order by b.wardno, a.bedno ");
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

        public void BedTransferInsert()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_BedTransfer (@ipdno int, @ddate datetime, @bedno varchar(15), @billtime varchar(15), @booked int, ");
            s.Append(" @inout varchar(1), @old_bed varchar(20),@admitdate datetime) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into bedrec(ipdno, ddate, bedno,billtime,booked,inout,old_bed) ");
            s.Append(" values(@ipdno, @ddate, @bedno, @billtime, @booked, @inout, @old_bed ) ");
            s.Append(" update bedrack set ipdno= null, admitdate = null, remarkstype='Vacant' where ipdno=@ipdno and (booked is null or booked = 0 ) ");
            s.Append(" update bedrack set ipdno=@ipdno, admitdate=@admitdate, remarkstype='Occupied' where bedno=@bedno ");
            s.Append(" update inpatient set bedno=@bedno where ipdno=@ipdno ");
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