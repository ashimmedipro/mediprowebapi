using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.DueSectionModify
{
    public class DueClearModify
    {
        public void DueClearViewSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DueClearView (@firm int) ");
            s.Append(" as ");
            s.Append(" select b.pname,a.*, (cast((a.amount-a.discount+a.vat-isnull(a.roundoff,0) ) as decimal(12,2))- cast(a.paid as decimal(12,2))) as nDue ");
            s.Append(" from opdbill a, member b ");
            s.Append(" where a.firm=1 and a.p_type='Cash' ");
            s.Append(" and a.hospid=b.hospid ");
            s.Append(" and (cast((a.amount-a.discount+a.vat-isnull(a.roundoff,0)) as decimal(12,2)))<>cast(a.paid as decimal(12,2)) ");
            s.Append(" and (a.inv_no like '%%' OR B.PNAME LIKE '%%') ");





            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void DueClearSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DueClearSelectInvNo(@inv_no varchar(11)) ");
            s.Append(" as ");
            s.Append(" select inv_no from opdbill ");
            s.Append(" with (nolock) ");
            s.Append(" Where (amount-discount+vat-isnull(roundoff,0))<>paid and inv_no=@inv_no ");





            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void DueClearInsert()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_DueClearInsert( ");
            s.Append(" @ddate datetime , @r_no varchar(11), @inv_no varchar(11), @billtime varchar(15), @due varchar(3), @remarks varchar(50), @hospid int, @nuser int, @amount numeric(18,2), @canceled bit, @postledger bit, @ipdno int, ");
            s.Append(" @ipd bit, @serialno int, @refund bit, @rebate numeric(12,2), @fy varchar(1), @firm int ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" exec sp_Receipt_Insert @ddate, @r_no, @inv_no, @fy, @billtime, @due, @remarks, @hospid, @nuser, @firm, @amount, @canceled, @postledger, @ipdno, ");
            s.Append(" @ipd, @serialno, @refund, @rebate ");
            s.Append(" update OPDBILL ");
            s.Append(" set paid=paid+@amount where inv_no=@inv_no ");
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