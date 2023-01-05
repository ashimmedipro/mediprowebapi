using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdBillingSectionModify
{
    public class DepositModify
    {
//{Inpatient Select }


        public void DepositGetTotal()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DepositGetTotalByIpdno (@ipdno int ,@p_type varchar(10)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select sum(amount-discount+vat-isnull(roundoff,0)) as total from opdbill where ipdno=@ipdno and p_type=@p_type ");
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

        public void DepositGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DepositGetDepositByIpdno @ipdno int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select sum(amount) as total from deposit where ipdno=@ipdno ");
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

        public void DepositGetRefund()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_DepositGetRefundByIpdno @ipdno int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select sum(amount) as total from refund where ipdno=@ipdno ");
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

        public void DepositGetReceipt()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DepositGetReceiptByIpdno @ipdno int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select sum(amount) as total from receipt where ipdno=@ipdno ");
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

        public void DepositGetAdvance()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_DepositGetAdvanceByHospid @hospid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select sum(Amount-Paid) as AdvAmt from Advance where hospid=@hospid ");
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

        public void DepositInsert()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure [dbo].[sp_DepositInsert]( ");
            s.Append(" @fy varchar(2) , ");
            s.Append(" @inv_no varchar(11) , ");
            s.Append(" @ipdno int , ");
            s.Append(" @amount numeric(18, 2) , ");
            s.Append(" @userid int , ");
            s.Append(" @billtime varchar(15) , ");
            s.Append(" @posted bit , ");
            s.Append(" @firm int , ");
            s.Append(" @DDATE datetime ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into deposit ( ");
            s.Append(" fy , ");
            s.Append(" inv_no , ");
            s.Append(" ipdno , ");
            s.Append(" amount, ");
            s.Append(" userid , ");
            s.Append(" billtime , ");
            s.Append(" posted , ");
            s.Append(" firm , ");
            s.Append(" DDATE ");
            s.Append(" ) ");
            s.Append(" values( ");
            s.Append(" @fy , ");
            s.Append(" @inv_no , ");
            s.Append(" @ipdno , ");
            s.Append(" @amount, ");
            s.Append(" @userid , ");
            s.Append(" @billtime , ");
            s.Append(" @posted , ");
            s.Append(" @firm , ");
            s.Append(" @DDATE ");
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