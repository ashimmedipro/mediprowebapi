using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class ServiceDivisionwiseSalesSummaryForLabModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_ServiceDivisionwiseLabSales%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_ServiceDivisionwiseLabSales  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_ServiceDivisionwiseLabSalesSum%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_ServiceDivisionwiseLabSalesSum  ");
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
        public void ServDivSalesForLab()
        { 
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_ServiceDivisionwiseLabSales (@init datetime,@final datetime,@firm int,@ipd int,@insurance int, ");
            s.Append(" @initbilltime varchar(15),@finalbilltime varchar(15),@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select g.dp_id, g.groupname, sum(a.qty) as NOB, sum(qty*rate)as Amount, ");
            s.Append(" sum(a.disc_amt)as Discount, sum((a.qty*a.rate)-(a.disc_amt ) )as Net, ");
            s.Append(" sum(case when vatamt<>0 then (qty*rate)-disc_amt else 0 end) as taxable, ");
            s.Append(" sum(case when vatamt<>0 then 0 else (qty*rate)-disc_amt end) as nontaxable, ");
            s.Append(" sum(a.vatamt) as vatamt, ");
            s.Append(" sum( (a.qty*a.rate)-(a.disc_amt)+ a.vatamt )as Total, sum(a.dueamt) as dueamt, sum(a.paid) as Paid, ");
            s.Append(" count(a.hospid) as NOP ");
            s.Append(" from opdrec a, service b, servgroup c, division g ");
            s.Append(" where a.servid=b.servid and ");
            s.Append(" b.grpid=c.grpid and c.dp_id=g.dp_id AND ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = @insurance ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end ");
            s.Append(" and a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" ) ");
            s.Append(" and g.groupname like '%'+@search+'%' ");
            s.Append(" group by g.Dp_id, g.groupname ");
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

        public void ServDivSalesForLabSum()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_ServiceDivisionwiseLabSalesSum (@init datetime,@final datetime,@firm int,@ipd int,@insurance int, ");
            s.Append(" @initbilltime varchar(15),@finalbilltime varchar(15),@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select sum(a.qty) as NOB, sum(qty*rate)as Amount, ");
            s.Append(" sum(a.disc_amt)as Discount, sum( (a.qty*a.rate)-(a.disc_amt) )as Net, ");
            s.Append(" sum(a.vatamt) as Vatamt, ");
            s.Append(" sum(case when vatamt<>0 then (qty*rate)-disc_amt else 0 end) as taxable, ");
            s.Append(" sum(case when vatamt<>0 then 0 else (qty*rate)-disc_amt end) as nontaxable, ");
            s.Append(" sum( (a.qty*a.rate)-(a.disc_amt) +(a.vatamt ) )as Total ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid left join division d on c.dp_id=d.dp_id ");
            s.Append(" where ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.FIRM=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = @insurance ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end ");
            s.Append(" and a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" ) ");
            s.Append(" and d.groupname like '%'+@search+'%' ");
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