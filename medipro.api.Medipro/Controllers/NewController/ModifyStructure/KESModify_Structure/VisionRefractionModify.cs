using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class VisionRefractionModify
    {
        public void VisionRefrationInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefractionInsert( "); 
            s.Append(" @mrdno varchar(15) , ");
            s.Append(" @ddate date, ");
            s.Append(" @userid int, ");
            s.Append(" @biltime datetime , ");
            s.Append(" @hospid int ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into VisionandRefraction(mrdno ,ddate ,userid ,biltime,hospid) ");
            s.Append(" values(@mrdno ,@ddate ,@userid ,@biltime,@hospid) ");
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

        public void VisionRefractionUpdate()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefractionUpdate( ");
            s.Append(" @sn int , ");
            s.Append(" @mrdno varchar(15), ");
            s.Append(" @ddate date, ");
            s.Append(" @userid int, ");
            s.Append(" @biltime datetime , ");
            s.Append(" @hospid int ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" update VisionandRefraction ");
            s.Append(" set ");
            s.Append(" ddate=@ddate , ");
            s.Append(" userid=@userid , ");
            s.Append(" biltime=@biltime, ");
            s.Append(" hospid = @hospid ");
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

        public void VisionRefractionSelect()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefractionSelect ");
            s.Append(" (@mrdno varchar(15) = '0') ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" if (@mrdno = '0') ");
            s.Append(" select a.sn,a.mrdno, a.userid, a.biltime ,a.ddate, b.HOSPID from VisionandRefraction a ");
            s.Append(" left join MEMBER b on a.hospid= b.HOSPID ");
            s.Append(" else ");
            s.Append(" select a.sn,a.mrdno, a.userid, a.biltime ,a.ddate, b.HOSPID from VisionandRefraction a ");
            s.Append(" left join MEMBER b on a.hospid= b.HOSPID ");
            s.Append(" where mrdno=@mrdno ");
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


        public void VisionRefractionDelete()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefractionDelete ");
            s.Append(" (@mrdno varchar(15)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" delete from VisionandRefraction where mrdno=@mrdno ");
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

        public void VisionRefractionDetailInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefraction_detailsInsert( ");
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
            s.Append(" insert into VisionandRefraction_details( ");
            s.Append(" mrdno , ");
            s.Append(" title , ");
            s.Append(" result, ");
            s.Append(" tick_mark, ");
            s.Append(" ddate, ");
            s.Append(" hospid ");
            s.Append(" ) ");
            s.Append(" values( ");
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

        public void VisionRefractionDetailUpdate()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefraction_detailsUpdate( ");
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
            s.Append(" update VisionandRefraction_details ");
            s.Append(" set ");
            s.Append(" title =@title, ");
            s.Append(" result=@result, ");
            s.Append(" tick_mark=@tick_mark, ");
            s.Append(" ddate=@ddate, ");
            s.Append(" hospid=@hospid ");
            s.Append(" where mrdno =@mrdno ");
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

        public void VisionRefractionDetailSelect()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefraction_detailsSelect(@mrdno varchar(15) ='0' ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" if (@mrdno = '0') ");
            s.Append(" select a.sn, a.hospid,a.mrdno, a.title, a.result, a.tick_mark, a.ddate,b.PNAME, b.ADDRESS,b.contact,b.MartialStatus, b.sex, ");
            s.Append(" Case ");
            s.Append(" when DateAdd(year, DATEDIFF(YY,b.DOB,GetDate()), b.DOB) > GETDATE() ");
            s.Append(" then DateDiff(YY,b.dob,GETDATE()) - 1 ");
            s.Append(" else ");
            s.Append(" DateDiff(YY,b.DOB,getdate()) ");
            s.Append(" end ");
            s.Append(" as age ");
            s.Append(" from VisionandRefraction_details a ");
            s.Append(" left join MEMBER b on a.hospid= b.HOSPID ");
            s.Append(" else ");
            s.Append(" select a.sn,a.hospid, a.mrdno, a.title, a.result, a.tick_mark,a.ddate, b.PNAME, b.ADDRESS,b.contact,b.MartialStatus, b.sex, ");
            s.Append(" Case ");
            s.Append(" when DateAdd(year, DATEDIFF(YY,b.DOB,GetDate()), b.DOB) > GETDATE() ");
            s.Append(" then DateDiff(YY,b.dob,GETDATE()) - 1 ");
            s.Append(" else ");
            s.Append(" DateDiff(YY,b.DOB,getdate()) ");
            s.Append(" end ");
            s.Append(" as age ");
            s.Append(" from VisionandRefraction_details a ");
            s.Append(" left join MEMBER b on a.hospid= b.HOSPID ");
            s.Append(" where a.mrdno=@mrdno ");
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

        public void VisionRefractionDetailDelete()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_VisionandRefraction_detailsDelete(@mrdno varchar(15)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" delete from VisionandRefraction_details ");
            s.Append(" where mrdno=@mrdno ");
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

        public void TempVisionRefractionDetailInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_TempVisionandRefraction_detailsInsert ");
            s.Append(" @title [varchar](200), ");
            s.Append(" @result [varchar](200) , ");
            s.Append(" @tick_mark [bit] , ");
            s.Append(" @userid int ");
            s.Append(" as ");
            s.Append(" insert into TempVisionandRefraction_details ");
            s.Append(" (title, result, tick_mark, userid) values (@title, Upper(@result), @tick_mark, @userid) ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void TempVisionRefractionDetailBulkInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_TempVisionandRefraction_detailsBulkInsert ");
            s.Append(" @ddate datetime, ");
            s.Append(" @hospid int, ");
            s.Append(" @mrdno varchar(15), ");
            s.Append(" @userid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into VisionandRefraction_details ");
            s.Append(" ( ");
            s.Append(" title, result, tick_mark, ddate, hospid, mrdno ");
            s.Append(" ) ");
            s.Append(" select title, result, tick_mark, @ddate, @hospid, @mrdno ");
            s.Append(" from TempVisionandRefraction_details where userid=@userid ");
            s.Append(" delete from TempVisionandRefraction_details where userid=@userid ");
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


        public void TempVisionRefractionDetailDelete()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_TempVisionandRefraction_detailsDelete @userid int ");
            s.Append(" as ");
            s.Append(" delete from TempVisionandRefraction_details where userid=@userid ");

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