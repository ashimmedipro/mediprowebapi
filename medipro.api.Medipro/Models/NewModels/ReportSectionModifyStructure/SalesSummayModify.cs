using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class SalesSummayModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_SalesSummaryGetOpdbillByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_SalesSummaryGetOpdbillByDate  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_SalesSummaryGetDisSumByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_SalesSummaryGetDisSumByDate  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_SalesSummaryGetAmountSumByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_SalesSummaryGetAmountSumByDate  ");
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
        //
        public void SalesSummOpdBillGet()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_SalesSummaryGetOpdbillByDate(@init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select a.ddate, b.bs_date, min(a.inv_no)as Firstinv, max(a.inv_no)as Lastinv, count(inv_no)as Totinv, ");
            s.Append(" sum(a.amount) as TotalAmount, sum(a.discount)+ isnull( (select sum(discount) from invoicediscount where ddate=a.ddate and firm= case when 0=0 then firm else 0 end),0) as TotalDiscount, ");
            s.Append(" sum(a.amount-a.discount)- isnull( (select sum(discount) from invoicediscount where ddate=a.ddate and firm= case when 0=0 then firm else 0 end ),0 ) as Taxable, ");
            s.Append(" sum(a.vat)as Totvat, ");
            s.Append(" sum( -isnull(a.roundoff,0) )as Roundoff, ");
            s.Append(" sum(a.amount-a.discount+a.vat-isnull(roundoff,0))- isnull( (select sum(discount) from invoicediscount where ddate=a.ddate and firm= case when 0=0 then firm else 0 end),0) as Net ");
            s.Append(" from opdbill a , calendar b where a.ddate=b.ad_date ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and A.firm= case when 0=0 then A.firm else 0 end ");
            s.Append(" group by a.ddate,b.bs_date, a.salestype ");
            s.Append(" order by a.ddate ");



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

        public void SalesDiscSumGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_SalesSummaryGetDisSumByDate(@init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select sum(Discount) as Discount ");
            s.Append(" from invoicediscount where ddate>=@init and ddate<=@final ");
            s.Append(" and firm= case when 0=0 then firm else 0 end ");



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

        public void SalesSummAmtGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_SalesSummaryGetAmountSumByDate(@init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select sum(amount) as Amount, sum(discount) as Discount, ");
            s.Append(" sum(amount-discount) as Taxable, ");
            s.Append(" sum(vat) as Vat, sum( -isnull(roundoff,0) )as Roundoff, sum(amount-discount+vat-isnull(roundoff,0)) as Net ");
            s.Append(" from opdbill where ddate>=@init and ddate<=@final ");
            s.Append(" and firm= case when 0=0 then firm else 0 end ");


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