using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class OpdSalesSummaryModify
    {

        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OpdSalesSummaryGetbyDateRange%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OpdSalesSummaryGetbyDateRange  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OpdSalesSummaryGetTotalbyDateRange%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OpdSalesSummaryGetTotalbyDateRange  ");
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
        public void OpdSalesGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_OpdSalesSummaryGetbyDateRange(@init datetime, @final datetime, @firm int) ");
            s.Append(" as ");
            s.Append(" select 1 as sn, 'Cash/Card Sales' as Type, sum(-ISNULL(ROUNDOFF,0)) as roundoff, sum(amount) as Amount, ");
            s.Append(" sum(discount)+ isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type IN ( 'Cash','Card' ) and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) as Discount, ");
            s.Append(" sum(vat) as Vat, ");
            s.Append(" sum(amount-discount+vat-ISNULL(ROUNDOFF,0))- ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type IN ( 'Cash','Card' ) and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) as Net ");
            s.Append(" from opdbill where p_type IN ( 'Cash','Card' ) and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ");
            s.Append(" union all ");
            s.Append(" select 2 as sn,'Credit Sales' as Type, sum(-ISNULL(ROUNDOFF,0)) as roundoff, sum(amount) as Amount, ");
            s.Append(" sum(discount) + ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) as Discount, ");
            s.Append(" sum(vat) as Vat, ");
            s.Append(" sum(amount-discount+vat-ISNULL(ROUNDOFF,0)) - ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) ");
            s.Append(" from opdbill where p_type='Credit' and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 union ");
            s.Append(" select 3 as sn,'Member Cash/Card Sales' as Type, sum(-ISNULL(ROUNDOFF,0)) as roundoff, sum(amount) as Amount, ");
            s.Append(" sum(discount) + ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type IN ( 'Cash','Card' ) and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) ");
            s.Append(" as Discount, ");
            s.Append(" sum(vat) as Vat, ");
            s.Append(" sum(amount-discount+vat-ISNULL(ROUNDOFF,0))- ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type IN ( 'Cash','Card' ) and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) ");
            s.Append(" as Net from opdbill where p_type IN ( 'Cash','Card' ) and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ");
            s.Append(" union all ");
            s.Append(" select 4 as sn,'Member Credit Sales' as Type,sum(- ");
            s.Append(" ISNULL(ROUNDOFF,0)) as roundoff, sum(amount) as Amount, ");
            s.Append(" sum(discount)+ ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) ");
            s.Append(" as Discount, ");
            s.Append(" sum(vat) as Vat, ");
            s.Append(" sum(amount-discount+vat-ISNULL(ROUNDOFF,0))- ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ) ),0) ");
            s.Append(" from opdbill where p_type='Credit' and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=0 ");
            s.Append(" union all ");
            s.Append(" select 5 as sn,'IPD Credit Sales' as Type,sum(- ");
            s.Append(" ISNULL(ROUNDOFF,0)) as roundoff, sum(amount) as Amount, ");
            s.Append(" sum(discount)+ ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=1 ) ),0) ");
            s.Append(" as Discount, ");
            s.Append(" sum(vat) as Vat, sum(amount-discount+vat-ISNULL(ROUNDOFF,0))- ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=0 and ddate>=@init and ddate<=@final and firm=@firm and ipd=1 ) ),0) ");
            s.Append(" from opdbill where p_type='Credit' and ddate>=@init and ddate<=@final and firm=@firm and ipd=1 and member=0 union ");
            s.Append(" select 6 as sn,'IPD Member Credit Sales' as Type, sum(-ISNULL(ROUNDOFF,0)) as roundoff, sum(amount) as Amount, ");
            s.Append(" sum(discount)+ ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=1 ) ),0) ");
            s.Append(" as Discount, sum(vat) as Vat, ");
            s.Append(" sum(amount-discount+vat-ISNULL(ROUNDOFF,0)) - ");
            s.Append(" isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm and ");
            s.Append(" inv_no in (select inv_no from opdbill where p_type='Credit' and member=1 and ddate>=@init and ddate<=@final and firm=@firm and ipd=1 ) ),0) ");
            s.Append(" from opdbill where p_type='Credit' and ddate>=@init and ddate<=@final and firm=@firm and ipd=1 and member=1 ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }


        }

        public void OpdSalesGetTotal()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_OpdSalesSummaryGetTotalbyDateRange @init datetime, @final datetime , @firm int ");
            s.Append(" as ");
            s.Append(" select sum(amount) as Amount, sum(discount)+isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm ),0 ) as Discount, sum(vat) as Vat, ");
            s.Append(" sum(-isnull(roundoff,0)) as roundoff, sum(amount-discount+vat-isnull(roundoff,0) )-isnull( (select sum(discount) from invoicediscount where ddate>=@init and ddate<=@final and firm=@firm ),0 ) as Net from opdbill ");
            s.Append(" where firm=@firm and ddate>=@init and ddate<=@final ");





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