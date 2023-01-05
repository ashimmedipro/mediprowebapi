using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdBillingSectionModify
{
    public class BedBookingModify
    {
        //has inpatientselect and bedrackselect
        public void BedBookingInsert()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_BedBookInsert(@ipdno int, @ddate datetime, @bedno varchar(15),@admitdate datetime, ");
            s.Append(" @billtime varchar(15), @booked int, @inout varchar(1), @old_bed varchar(20)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" Insert Into bedrec (ipdno, ddate, bedno, billtime, booked, inout, old_bed ) values (@ipdno, @ddate, @bedno, @billtime, @booked, ");
            s.Append(" @inout, @old_bed ) ");
            s.Append(" update bedrack set ipdno=@ipdno,admitdate=@admitdate, remarkstype='Occupied', booked=1 where bedno=@bedno ");
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