using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class CreditInvoiceDueClearReportModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_CreditInvoiceDueClearReportSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_CreditInvoiceDueClearReportSelect  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_CreditInvoiceDueClearReportSum%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_CreditInvoiceDueClearReportSum  ");
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
        public void CrtInvDueRpt()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_CreditInvoiceDueClearReportSelect @init datetime,@final datetime,@search varchar(50) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select a.ddate, b.bs_date, a.vr_no, a.ac_code, ");
            s.Append(" c.particular, sum(a.paid) as paid, a.bank_code, d.particular as bank_name ");
            s.Append(" from creditdue a ");
            s.Append(" left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join ac_code c on a.ac_code=c.ac_code ");
            s.Append(" left join ac_code d on a.bank_code=d.ac_code ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and c.particular like '%'+@search+'%' ");
            s.Append(" group by ");
            s.Append(" a.ddate, b.bs_date, a.vr_no, a.ac_code, ");
            s.Append(" c.particular, a.bank_code, d.particular order by a.ddate, a.vr_no ");
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

        public void CrtInvDueRptSum()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_CreditInvoiceDueClearReportSum @init datetime,@final datetime,@search varchar(50) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select sum(a.paid) as paid ");
            s.Append(" from creditdue a ");
            s.Append(" left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join ac_code c on a.ac_code=c.ac_code ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and c.particular like '%'+@search+'%' ");
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