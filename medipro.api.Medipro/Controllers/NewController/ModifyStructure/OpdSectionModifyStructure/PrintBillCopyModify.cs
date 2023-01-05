using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class PrintBillCopyModify
    {
        public void OpdbillSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_PrintBillCopyOpdBillSelectByInv_no(@inv_no varchar(11)) ");
            s.Append(" as ");
            s.Append(" select a.claim_code, b.policyid , ltrim(str(ASCII( SUBSTRING( a.inv_no, 1,1)))) + LTRIM( ( SUBSTRING( a.inv_no, 5,7))) as invno1 , ");
            s.Append(" isnull(m.PRINT_COUNT,0) AS print_count1, a.consid, l.referer as consultant, dbo.fn_AgeDay( a.ageday) as ageymd, a.canceled, h.particular as acparticular, a.ipdno, a.ipd, a.bedno ,a.er, ");
            s.Append(" a.hospid,a.inv_no,a.ddate,c.bs_date,b.pname,b.dob, b.address,b.sex,a.refid,e.referer, ");
            s.Append(" a.billtime,b.telephone,a.billmode,a.p_type,A.contact, A.AGEDAY, a.member, f.department, ");
            s.Append(" a.amount,a.discount,a.vat,isnull(-a.roundoff,0) as roundoff, ");
            s.Append(" (a.amount-a.discount+a.vat-isnull(a.roundoff,0) ) as Net,d.username,a.tender,a.paid, A.FIRM, a.advance, a.remarks, a.labno, g.firmname, g.regno, g.firm_address, g.firm_telephone, j.particular as ward, a.organization, k.groupname, ");
            s.Append(" a.barcode, A.PRINT_COUNT, b.regno as pan, isnull(A.REFUND,0) as refund, ");
            s.Append(" a.ssf, a.ssf_scheme_id, a.ssf_pc, case when a.ssf=1 then 100 - a.ssf_pc else 0 end as ssf_pc1, ( (a.amount-a.discount+a.vat-isnull(a.roundoff,0) )*( (case when a.ssf=1 then 100 - a.ssf_pc else 0 end) ))/100 as ssf_amt1 ");
            s.Append(" from opdbill a with (nolock) ");
            s.Append(" LEFT JOIN member b with (nolock) ON a.hospid=b.hospid ");
            s.Append(" LEFT JOIN calendar c with (nolock) ON a.ddate=c.ad_date ");
            s.Append(" LEFT JOIN userlist d with (nolock) ON a.[user]=d.userid ");
            s.Append(" LEFT JOIN referer e with (nolock) ON a.refid=e.refid ");
            s.Append(" LEFT JOIN empdept f with (nolock) on b.dptid=f.dptid ");
            s.Append(" LEFT JOIN FIRMS G with (nolock) on A.firm=G.firm ");
            s.Append(" LEFT JOIN ac_code h with (nolock) on A.ac_code=h.ac_code ");
            s.Append(" LEFT JOIN bedrack i with (nolock) on A.bedno=i.bedno ");
            s.Append(" LEFT JOIN ward j with (nolock) on i.wardno=j.wardno ");
            s.Append(" LEFT JOIN division k with (nolock) on a.dpid=k.dp_id ");
            s.Append(" LEFT JOIN referer l with (nolock) ON a.consid=l.refid ");
            s.Append(" LEFT JOIN opdbill_info m with (nolock) on a.inv_no=m.inv_no ");
            s.Append(" WHERE a.inv_no=@inv_no ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OpdrecSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" Create procedure sp_PrintBillCopyOpdRecSelectByInv_no(@inv_no varchar(11)) ");
            s.Append(" as ");
            s.Append(" select a.*,b.servname, ");
            s.Append(" b.roomno ");
            s.Append(" from opdrec a with (nolock) left join service b with (nolock) on a.servid=b.servid ");
            s.Append(" left join serviceWiseTokenNumber c with (nolock) on a.inv_no=c.inv_no and b.grpid=c.grpid ");
            s.Append(" where ");
            s.Append(" A.inv_no=@inv_no order by a.sn ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void CopyReceiptSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" Create procedure sp_PrintBillCopyReceiptSelectByInv_no(@inv_no varchar(11)) ");
            s.Append(" as ");
            s.Append(" select * from receipt with (nolock) ");
            s.Append(" where inv_no=@inv_no ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void CopyPanelRecSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" Create procedure sp_PrintBillCopyPanelRecSelectByInv_no(@inv_no varchar(11), @master_servid int) ");
            s.Append(" as ");
            s.Append(" select a.*, b.servname ");
            s.Append(" from panelrec a left join service b on a.servid=b.servid ");
            s.Append(" where a.inv_no=@inv_no and a.master_servid=@master_servid ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void PrintBillCopyOpdBillUpdate()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_PrintBillCopyOpdBillUpdate(@inv_no varchar(11)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" update OPDBILL_info set print_count=isnull(print_count,0)+1, original_pending=0 ");
            s.Append(" where inv_no=@inv_no ");
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