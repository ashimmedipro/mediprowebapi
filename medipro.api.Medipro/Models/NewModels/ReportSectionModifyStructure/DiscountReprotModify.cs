using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class DiscountReprotModify
    {

        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_DiscountSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_DiscountSelect  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_DiscountReportMemberSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_DiscountReportMemberSelect  ");
            s.Append(" end ");
           
            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_opdDiscountReport%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_opdDiscountReport  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_opdDiscountReportSum%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_opdDiscountReportSum  ");
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

        //
        public void DiscountGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DiscountSelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select * from discount_name with (nolock) where isnull(status,'Active')='Active' and discount_name like '%'+@search+'%' ");
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


        public void DiscountRptMemberGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DiscountReportMemberSelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select top 100 *, datediff(year, dob,getdate()) as age from member where ( pname like '%'+@search+'%' or hospid like '%'+@search+'%') order by pname ");
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



        public void OpdDiscountRptGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" CREATE PROCEDURE sp_opdDiscountReport @init datetime, @final datetime, @firm int, @scheme int, @hospid int ");
            s.Append(" AS ");
            s.Append(" select d.bs_date, a.ddate, a.inv_no, b.pname, a.amount, a.discount+sum( isnull( e.discount,0 ) ) as discount, (a.discount/a.amount)*100 as disc_pc, c.username, a.remarks, F.DISCOUNT_NAME, ");
            s.Append(" a.appby, a.reqby, a.telno ");
            s.Append(" from opdbill a ");
            s.Append(" left join member b on a.hospid=b.hospid ");
            s.Append(" left join userlist c on a.[user]=c.userid ");
            s.Append(" left join calendar d on a.ddate=d.ad_date ");
            s.Append(" left join invoicediscount e on a.inv_no=e.inv_no ");
            s.Append(" left join discount_name f on a.scheme = f.discount_id ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and ( a.discount>0 or a.inv_no in (select inv_no from invoicediscount where ddate>=@Init and ddate<=@final and firm=@firm ) ) ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.scheme = case when @scheme=0 then a.scheme else @scheme end ");
            s.Append(" and a.hospid = case when @hospid=0 then a.hospid else @Hospid end ");
            s.Append(" group by d.bs_date, a.ddate, a.inv_no, b.pname, a.amount, a.discount, c.username, a.remarks ,a.appby, a.reqby, a.telno, F.DISCOUNT_NAME ");
            s.Append(" order by a.ddate, a.inv_no ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void OpdDiscountRptSumGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" CREATE PROCEDURE sp_opdDiscountReportSum @init datetime, @final datetime, @firm int, @scheme int, @hospid int ");
            s.Append(" AS ");
            s.Append(" select sum(amount) as amount , sum(discount) as discount ");
            s.Append(" from opdbill where ddate>=@init and ddate<=@final and ");
            s.Append(" firm=@firm ");
            s.Append(" and isnull(scheme,0)=case when @scheme=0 then isnull(scheme,0) else @scheme end ");
            s.Append(" and isnull(hospid,0)=case when @hospid=0 then isnull(hospid,0) else @hospid end and discount>0 ");

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