using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class OcularExamModify
    {
        public void OcularExamDetailInsert()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_Ocular_Examination_detailsInsert( ");
           
            s.Append(" @mrdno varchar(15) , ");
            s.Append(" @title varchar(200), ");
            s.Append(" @result varchar(200), ");
            s.Append(" @tick_mark bit, ");
            s.Append(" @ddate datetime, ");
            s.Append(" @hospid int ");
            
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into Ocular_Examination_details( ");
            
            s.Append(" mrdno , ");
            s.Append(" title , ");
            s.Append(" result, ");
            s.Append(" tick_mark, ");
            s.Append(" ddate, ");
            s.Append(" hospid ");
           
            s.Append(" ) ");
            s.Append(" values( ");
            s.Append("  ");
            s.Append(" @mrdno , ");
            s.Append(" @title , ");
            s.Append(" @result, ");
            s.Append(" @tick_mark, ");
            s.Append(" @ddate, ");
            s.Append(" @hospid ");
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

        public void OcularExamDetailSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure Ocular_Examination_detailsSelect(@mrdno varchar(15) ='0' ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" if (@mrdno = '0') ");
            s.Append(" select a.sn, a.mrdno, a.title, a.result, a.tick_mark, a.ddate,b.PNAME, b.ADDRESS,b.contact,b.MartialStatus, b.sex, ");
            s.Append(" Case ");
            s.Append(" when DateAdd(year, DATEDIFF(YY,b.DOB,GetDate()), b.DOB) > GETDATE() ");
            s.Append(" then DateDiff(YY,b.dob,GETDATE()) - 1 ");
            s.Append(" else ");
            s.Append(" DateDiff(YY,b.DOB,getdate()) ");
            s.Append(" end ");
            s.Append(" as age ");
            s.Append(" from Ocular_Examination_details a ");
            s.Append(" left join MEMBER b on a.hospid= b.HOSPID ");
            s.Append(" left join VisionandRefraction c on a.mrdno=c.mrdno ");
            s.Append(" else ");
            s.Append(" select a.sn, a.mrdno, a.title, a.result, a.tick_mark, a.ddate,b.PNAME, b.ADDRESS,b.contact,b.MartialStatus, b.sex, ");
            s.Append(" Case ");
            s.Append(" when DateAdd(year, DATEDIFF(YY,b.DOB,GetDate()), b.DOB) > GETDATE() ");
            s.Append(" then DateDiff(YY,b.dob,GETDATE()) - 1 ");
            s.Append(" else ");
            s.Append(" DateDiff(YY,b.DOB,getdate()) ");
            s.Append(" end ");
            s.Append(" as age ");
            s.Append(" from Ocular_Examination_details a ");
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

        public void OcularExamDetailDelete()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure Ocular_Examination_detailsDelete(@mrdno varchar(15)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" delete from Ocular_Examination_details ");
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

        public void TempOcularExamDetailInsert()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_TempOcular_Examination_detailsInsert ");
            s.Append(" @title varchar(200), ");
            s.Append(" @result varchar(200) , ");
            s.Append(" @tick_mark bit , ");
            s.Append(" @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into TempOcular_Examination_details ");
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

        public void TempOcularExamDetailBulkInsert()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_TempOcular_Examination_detailsBulkInsert ");
            s.Append(" @ddate datetime, ");
            s.Append(" @hospid int, ");
            s.Append(" @mrdno varchar(15), ");
            s.Append(" @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into Ocular_Examination_details ");
            s.Append(" ( ");
            s.Append(" title, result, tick_mark, ddate, hospid, mrdno ");
            s.Append(" ) ");
            s.Append(" select title, result, tick_mark, @ddate, @hospid, @mrdno ");
            s.Append(" from TempOcular_Examination_details where userid=@userid ");
            s.Append("  ");
            s.Append(" delete from TempOcular_Examination_details where userid=@userid ");
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

        public void TempOcularExamDetailDelete()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_TempOcular_Examination_details_Delete @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" delete from TempFearAndPreception_details where userid=@userid ");
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