using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class ServicewiseSalesSummaryModify
    {

        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_ServicewiseSalesGetByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_ServicewiseSalesGetByDate  ");
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
        public void ServwiseSalesGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_ServicewiseSalesGetByDate (@init datetime, @final datetime,@firm int,@val int,@ipd int, ");
            s.Append(" @insurance int, @refid int ,@initbilltime varchar(15),@finalbilltime varchar(15), @er int,@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select a.servid, b.servname,sum(a.qty) as NOB, sum(qty*rate)as Amount, ");
            s.Append(" sum( a.disc_amt )as Discount, ");
            s.Append(" sum(case when vatamt<>0 then (qty*rate)-disc_amt else 0 end) as taxable, ");
            s.Append(" sum(case when vatamt<>0 then 0 else (qty*rate)-disc_amt end) as nontaxable, ");
            s.Append(" sum((a.qty*a.rate)-a.disc_amt)as Net, ");
            s.Append(" sum(a.vatamt) as Vatamt, ");
            s.Append(" sum(((a.qty*a.rate)-a.disc_amt)+a.vatamt)as Total, ");
            s.Append(" sum(a.dueamt) as dueamt, sum(a.paid) as Paid, ");
            s.Append(" isnull(( select sum(d.DuePaid) as DuePaid ");
            s.Append(" from opdrec d left join service e on d.servid=e.servid left join servgroup f on e.grpid=f.grpid ");
            s.Append(" where ");
            s.Append(" d.rdate>=@init and d.rdate<=@final ");
            s.Append(" and d.inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.er = case when @er=0 then a.er else @er end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 ");
            s.Append(" then ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
            s.Append(" and d.servid=a.servid and e.servname like '%'+@search+'%' ");
            s.Append(" group by d.servid, e.servname ),0) as DuePaid ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid left join opdbill d on a.inv_no=d.inv_no ");
            s.Append(" where b.servname like '%'+@search+'%' and ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and (d.ddate + (d.billtime)>=case when @initbilltime='0' then d.ddate+d.billtime else @init + @initbilltime end ");
            s.Append(" and d.ddate+(d.billtime)<=case when @finalbilltime='0' then d.ddate + d.billtime else @final + @finalbilltime end) ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where ddate>=@init and ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.er = case when @er=0 then a.er else @er end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 ");
            s.Append(" then ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
            s.Append(" group by a.servid, b.servname ");
            s.Append(" union all ");
            s.Append(" select a.servid, b.servname, 0 as NOB, 0.00 Amount, ");
            s.Append(" 0.00 as Discount, ");
            s.Append(" 0.00 as taxable, ");
            s.Append(" 0.00 as nontaxable, ");
            s.Append(" 0.00 as Net, ");
            s.Append(" 0.00 as Vatamt, ");
            s.Append(" 0.00 as Total, ");
            s.Append(" 0.00 as dueamt, 0.00 as Paid, ");
            s.Append(" sum(a.duepaid) as duepaid ");
            s.Append(" from opdrec a, service b, servgroup c ");
            s.Append(" where b.grpid=c.grpid and a.servid=b.servid and b.servname like '%'+@search+'%' and ");
            s.Append(" a.rdate>=@init and a.rdate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.er = case when @er=0 then a.er else @er end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 ");
            s.Append(" then ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
            s.Append(" and a.servid not in (select servid from opdrec where ddate>=@init and ");
            s.Append(" Ddate<=@final ");
            s.Append(" and inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.er = case when @er=0 then a.er else @er end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 ");
            s.Append(" then ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
            s.Append(" ) ");
            s.Append(" group by a.servid, b.servname order by amount desc ");
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

        public void ServwiseSalesGetSum()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_ServicewiseSalesGetSum(@init datetime, @final datetime,@firm int,@val int,@ipd int, ");
            s.Append(" @insurance int,@refid int ,@initbilltime varchar(15),@finalbilltime varchar(15),@er int) ");
            s.Append(" as ");
            s.Append(" select sum(a.qty) as NOB, sum(qty*rate)as Amount, ");
            s.Append(" sum(a.disc_amt)as Discount, ");
            s.Append(" sum((a.qty*a.rate)-a.disc_amt)as Net, ");
            s.Append(" sum(a.vatamt) as Vatamt, ");
            s.Append(" sum(((a.qty*a.rate)-a.disc_amt)+a.vatamt )as Total, sum(a.dueamt) as dueamt, sum(a.paid) as Paid ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.er = case when @er=0 then a.er else @er end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 ");
            s.Append(" then ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" and (a.ddate + (a.billtime)>=case when @initbilltime='0' then a.ddate+a.billtime else @init + @initbilltime end ");
            s.Append(" and a.ddate+(a.billtime)<=case when @finalbilltime='0' then a.ddate + a.billtime else @final + @finalbilltime end) ");
            s.Append(" )) ");





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

        public void ServwiseSalesGetDue()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_ServiceSalesGetDue (@init datetime, @final datetime,@firm int,@val int,@ipd int, ");
            s.Append(" @insurance int,@refid int,@er int) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select sum(a.duepaid) as duepaid ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where ");
            s.Append(" a.rdate>=@init and a.rdate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.er = case when @er=0 then a.er else @er end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 ");
            s.Append(" then ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
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

        public void PatientCount()
        {
            StringBuilder s = new StringBuilder();



            //encrypted query




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