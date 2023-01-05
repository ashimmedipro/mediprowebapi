using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class CashRegisterSummaryModify 
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_ReceiptRegGetByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_ReceiptRegGetByDate  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_ReceiptRegSumGetByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_ReceiptRegSumGetByDate  ");
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

        public void ReceiptRegGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_ReceiptRegGetByDate(@init datetime, @final datetime, @firm int, @ipd int, @due varchar(3),@search varchar(50) ) ");
            s.Append(" as ");
            s.Append(" select a.ddate, b.bs_date, a.r_no, c.pname, a.amount, a.rebate, due, d.username, a.billtime, a.ipd, a.inv_no from ");
            s.Append(" receipt a, calendar b, member c, userlist d ");
            s.Append(" where a.ddate=b.ad_date and ");
            s.Append(" a.hospid=c.hospid and ");
            s.Append(" a.[user]=d.userid and ");
            s.Append(" a.ipd = case when @ipd = 2 then a.ipd else @ipd end and  ");
            s.Append(" a.due = case when @due = 'ALL' then a.due else case when @due='YES' then 'YES' else '' end end ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm and ( c.pname like '%'+@search+'%' ) ");
            s.Append(" order by a.ddate, a.r_no ");



            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void ReceiptRegGetSum()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_ReceiptRegSumGetByDate (@init datetime, @final datetime, @firm int, @ipd int, @due varchar(3)) ");
            s.Append(" as ");
            s.Append(" select sum(a.amount) as amount, sum(isnull(rebate,0)) as rebate from ");
            s.Append(" receipt a ");
            s.Append(" where ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.due = case when @due = 'ALL' then a.due else case when @due='YES' then 'YES' else '' end end ");


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