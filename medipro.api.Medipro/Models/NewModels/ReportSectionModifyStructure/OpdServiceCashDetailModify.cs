using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class OpdServiceCashDetailModify
    {
        public void OpdrecCashDetailPost()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure temp_opdrecCashDetailInsert @init datetime, @final datetime, @userid int, @firm int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" delete from temp_opdrecCashDetail where userid=@userid ");
            s.Append(" insert into temp_opdrecCashDetail ");
            s.Append(" select a.dp_id, a.divison, a.detail, a.grpid, a.groupname, isnull(b.hospqty,0) as hospqty, ");
            s.Append(" isnull(b.qty,0) as qty, isnull(b.amt,0) as amt, ");
            s.Append(" isnull(b.cashpaid,0) as cashpaid, isnull(b.dueamt,0) as duemat, isnull(c.duepaid,0) as duepaid, ");
            s.Append(" isnull(c.duepaid,0)+ isnull(b.Cash,0) as cash, a.userid, a.night ");
            s.Append(" from ");
            s.Append(" ( select e.dp_id, e.groupname as divison, isnull(e.detail,0) as detail, ");
            s.Append(" case when e.service=1 then b.servid else case when isnull(e.detail,0)=0 then e.dp_id else b.grpid end end as grpid, ");
            s.Append(" case when e.service=1 then b.servname else case when isnull(e.detail,0)=0 then e.groupname else d.groupname end end as groupname, ");
            s.Append(" @userid as userid, ISNULL( f.night,0) as night ");
            s.Append(" from service b ");
            s.Append(" left join opdrec a on a.servid=b.servid ");
            s.Append(" left join servgroup d on b.grpid=d.grpid ");
            s.Append(" left join division e on d.dp_id=e.dp_id ");
            s.Append(" left join opdbill f on a.inv_no=f.inv_no ");
            s.Append(" where a.firm=@firm and f.firm=@firm and ( (a.ddate between @init and @final) or (a.rdate between @init and @final)) ");
            s.Append(" group by e.dp_id, e.groupname , isnull(e.detail,0) , ");
            s.Append(" case when e.service=1 then b.servid else case when isnull(e.detail,0)=0 then e.dp_id else b.grpid end end , ");
            s.Append(" case when e.service=1 then b.servname else case when isnull(e.detail,0)=0 then e.groupname else d.groupname end end , ISNULL( f.night,0) ");
            s.Append(" ) a ");
            s.Append(" left join ");
            s.Append(" ( ");
            s.Append(" select e.dp_id, e.groupname as divison, isnull(e.detail,0) as detail, ");
            s.Append(" case when e.service=1 then b.servid else case when isnull(e.detail,0)=0 then e.dp_id else b.grpid end end as grpid, ");
            s.Append(" case when e.service=1 then b.servname else case when isnull(e.detail,0)=0 then e.groupname else d.groupname end end as groupname, ");
            s.Append(" COUNT(distinct a.hospid) as hospqty, SUM(qty) as qty, SUM( (a.qty*a.rate)-a.disc_amt+a.vatamt ) as amt, ");
            s.Append(" SUM( (a.qty*a.rate)-a.disc_amt+a.vatamt - dueamt ) as cashpaid, ");
            s.Append(" SUM(dueamt) as dueamt , ");
            s.Append(" SUM( (a.qty*a.rate)-a.disc_amt+a.vatamt - dueamt ) ");
            s.Append(" as Cash , @userid as userid, ISNULL( f.night,0) as night ");
            s.Append(" from service b ");
            s.Append(" left join opdrec a on a.servid=b.servid ");
            s.Append(" left join servgroup d on b.grpid=d.grpid ");
            s.Append(" left join division e on d.dp_id=e.dp_id ");
            s.Append(" left join opdbill f on a.inv_no=f.inv_no ");
            s.Append(" where a.firm=@firm and f.firm=@firm and (a.ddate between @init and @final) ");
            s.Append(" group by e.dp_id, e.groupname , isnull(e.detail,0) , ");
            s.Append(" case when e.service=1 then b.servid else case when isnull(e.detail,0)=0 then e.dp_id else b.grpid end end , ");
            s.Append(" case when e.service=1 then b.servname else case when isnull(e.detail,0)=0 then e.groupname else d.groupname end end , ISNULL( f.night,0) ");
            s.Append(" ) b on a.dp_id=b.dp_id and a.grpid=b.grpid and a.night=b.night ");
            s.Append(" left join ( ");
            s.Append(" select case when isnull(e.detail,0)=0 then e.dp_id else b.grpid end as grpid, SUM(duepaid) as duepaid , f.night ");
            s.Append(" from opdrec a ");
            s.Append(" left join service b on a.servid=b.servid ");
            s.Append(" left join servgroup d on b.grpid=d.grpid ");
            s.Append(" left join division e on d.dp_id=e.dp_id ");
            s.Append(" left join opdbill f on a.inv_no=f.inv_no ");
            s.Append(" where rdate between @init and @final ");
            s.Append(" group by case when isnull(e.detail,0)=0 then e.dp_id else b.grpid end , f.night ");
            s.Append(" ) c on c.grpid=a.grpid and c.night=a.night ");
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

        public void OpdrecCashDetailSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure temp_opdrecCashDetailSelect @userid int ");
            s.Append(" as ");
            s.Append(" select 1 as sn, a.dp_id, a.division, a.detail, a.dp_id as grpid, a.division as groupname, null as hosqty, ");
            s.Append(" null as qty, null as amt, null as cashpaid, null as dueamt, null as duepaid, null as cash ");
            s.Append(" from temp_opdrecCashDetail a where userid=@userid ");
            s.Append(" group by a.dp_id, a.division, a.detail ");
            s.Append(" union all ");
            s.Append(" select 2 as sn, a.dp_id, a.division, a.detail, a.grpid, a.groupname, a.hospqty, a.qty, a.amt, a.cashpaid, a.dueamt, a.duepaid, a.Cash ");
            s.Append(" from temp_opdrecCashDetail a where userid=@userid and a.night=0 ");
            s.Append(" union all ");
            s.Append(" select 3 as sn, a.dp_id, a.division, a.detail, A.DP_ID AS grpid, a.division+' EMERGENCY INCOME', ");
            s.Append(" SUM(a.hospqty) AS hopsid, sum(a.qty) as qty, sum(a.amt) as amt, sum(a.cashpaid) as cashpaid, sum(a.dueamt) as dueamt, sum(a.duepaid) as duepaid, sum(a.Cash) as cash ");
            s.Append(" from temp_opdrecCashDetail a ");
            s.Append(" where a.night=1 group by a.dp_id, a.division, a.detail, a.night ");
            s.Append(" order by dp_id, sn ");
            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void OpdrecCashDetailSumSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure temp_opdrecCashDetailSelectSum @userid int ");
            s.Append(" as ");
            s.Append(" select sum(a.hospqty) as hospqty, sum(a.qty) as qty, sum(a.amt) as amt, sum(a.cashpaid) as cashpaid, sum(a.dueamt) as dueamt, sum(a.duepaid) as duepaid, sum(a.Cash) as cash ");
            s.Append(" from temp_opdrecCashDetail a where userid=@userid ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void OpdServDiscSum()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_OpdServiceDiscountandSalesSum @init datetime,@final datetime,@firm int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select sum(d.dis) as Discount,sum(e.sales) as SalesReverse from ");
            s.Append(" (select a.hospid,sum(a.discount) as dis from opdbill a where firm=@firm and ");
            s.Append(" ddate between @init and @final group by hospid) d ");
            s.Append(" left join ( ");
            s.Append(" select a.hospid,sum(a.amount-a.discount+a.vat-isnull(roundoff,0)) as sales from opdbill a where firm=@firm and amount<0 and ");
            s.Append(" ddate between @init ");
            s.Append(" and @final group by hospid) e on d.hospid=e.hospid ");
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