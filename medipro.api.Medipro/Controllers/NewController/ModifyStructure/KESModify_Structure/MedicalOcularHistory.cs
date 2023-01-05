using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class MedicalOcularHistory
    {
        public void MedicalOcularHistorydetailSelect()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_MedicalOcularHistory_detailsSelect(@mrdno varchar(15)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.sn, a.mrdno, a.title, a.result, a.tick_mark, a.ddate,b.PNAME, b.ADDRESS,b.contact,b.MartialStatus, b.sex, ");
            s.Append(" Case ");
            s.Append(" when DateAdd(year, DATEDIFF(YY,b.DOB,GetDate()), b.DOB) > GETDATE() ");
            s.Append(" then DateDiff(YY,b.dob,GETDATE()) - 1 ");
            s.Append(" else ");
            s.Append(" DateDiff(YY,b.DOB,getdate()) ");
            s.Append(" end ");
            s.Append(" as age ");
            s.Append(" from MedicalOcularHistory_details a ");
            s.Append(" left join MEMBER b on a.hospid= b.HOSPID ");
            s.Append(" left join VisionandRefraction c on a.mrdno=c.mrdno ");
            s.Append(" where a.mrdno=@mrdno ");
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

        public void MedicalOcularHistorydetailDelete()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_MedicalOcularHistory_detailsDelete(@mrdno varchar(15)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" delete from MedicalOcularHistory_details ");
            s.Append(" where mrdno=@mrdno ");
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

        public void TempMedicalOcularHistorydetailInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_TempMedicalOcularHistory_detailsInsert ");
            s.Append(" @title varchar(200), ");
            s.Append(" @result varchar(200) , ");
            s.Append(" @tick_mark bit , ");
            s.Append(" @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into TempMedicalOcularHistory_details ");
            s.Append(" (title, result, tick_mark, userid) values (@title, Upper(@result), @tick_mark, @userid) ");
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

        public void TempMedicalOcularHistorydetailBulkInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_TempMedicalOcularHistory_detailsBulkInsert ");
            s.Append(" @ddate datetime, ");
            s.Append(" @hospid int, ");
            s.Append(" @mrdno varchar(15), ");
            s.Append(" @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into MedicalOcularHistory_details ");
            s.Append(" ( ");
            s.Append(" title, result, tick_mark, ddate, hospid, mrdno ");
            s.Append(" ) ");
            s.Append(" select title, result, tick_mark, @ddate, @hospid, @mrdno ");
            s.Append(" from TempMedicalOcularHistory_details where userid=@userid ");
            s.Append(" delete from TempMedicalOcularHistory_details where userid=@userid ");
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

        public void TempMedicalOcularHistorydetailDelete()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_TempMedicalOcularHistory_detailsDelete @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" delete from TempMedicalOcularHistory_details where userid=@userid ");
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