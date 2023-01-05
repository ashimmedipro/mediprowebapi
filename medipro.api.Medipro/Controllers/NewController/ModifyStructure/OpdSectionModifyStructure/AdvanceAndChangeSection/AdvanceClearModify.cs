using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceClearModify
    {
        public void AdvanceClearSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_AdvanceClearSelect ");
            s.Append(" as ");
            s.Append(" select a.*,b.pname from Advance a left join member b on a.hospid=b.hospid ");
            s.Append(" where a.Amount<>a.paid and ( B.PNAME LIKE '%%' OR a.sn LIKE '%%' ) ");





            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void AdvanceClearUpdate()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_AdvanceClearUpdate (@sn int,@amount float, @user1 int, @clear_date datetime) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" Update Advance ");
            s.Append(" set paid=paid+(@amount) , User1=@user1, clear_date=@clear_date where sn=@sn ");
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