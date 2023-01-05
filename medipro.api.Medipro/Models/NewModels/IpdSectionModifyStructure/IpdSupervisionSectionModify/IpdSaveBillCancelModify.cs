using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdSupervisionSectionModify
{
    public class IpdSaveBillCancelModify
    {
        public void IpdSaveBillCancel()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_IpdSaveBillCancel (@inv_no varchar(11),@user int) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" delete from ipdrec_save where inv_no=@inv_no ");
            s.Append(" Update ipdbill_save set amount=0, vat=0, ");
            s.Append(" discount=0, due=0, paid=0 ,[user]=@user, Canceled=1, Remarks='Cancelled Invoice' Where inv_no=@inv_no ");
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