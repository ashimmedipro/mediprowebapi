using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class ServiceGroupwiseSalesSummaryModify
    {
        public void ServiceGroupWiseSalesByDate()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_ServiceGroupWiseSalesByDate(@init datetime, @final datetime, @firm int,@val int,@ipd int, ");
            s.Append(" @insurance int,@refid int ,@initbilltime varchar(15),@finalbilltime varchar(15),@wardno int,@orgid int,@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select c.grpid, c.groupname, sum(a.qty) as NOB, sum(qty*rate)as Amount, ");
            s.Append(" sum(a.disc_amt)as Discount, sum((a.qty*a.rate)-(a.disc_amt ) )as Net, ");
            s.Append(" sum(case when vatamt<>0 then (qty*rate)-disc_amt else 0 end) as taxable, ");
            s.Append(" sum(case when vatamt<>0 then 0 else (qty*rate)-disc_amt end) as nontaxable, ");
            s.Append(" sum(a.vatamt) as vatamt, ");
            s.Append(" sum( (a.qty*a.rate)-(a.disc_amt)+ a.vatamt )as Total, sum(a.dueamt) as dueamt, sum(a.paid) as Paid, ");
            s.Append(" isnull(( select sum(d.DuePaid) as DuePaid ");
            s.Append(" from opdrec d ");
            s.Append(" left join service e on d.servid=e.servid ");
            s.Append(" left join servgroup f on e.grpid=f.grpid ");
            s.Append(" where 1=1 ");
            s.Append(" AND d.firm=@firm ");
            s.Append(" AND d.inv_no in (select a.inv_no from opdbill a ");
            s.Append(" LEFT JOIN MEMBER B ON A.hospid=b.hospid where rdate>=@init and rdate<=@final ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end and ");
            s.Append(" a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and isnull(b.orgid,0) = case when @orgid=0 then isnull(b.orgid,0) else @orgid end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 then ");
            s.Append(" ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
            s.Append(" and e.grpid=c.grpid and f.groupname like '%'+@search+'%' ");
            s.Append(" group by f.grpid, f.groupname ),0) as DuePaid, count(a.hospid) as NOP ");
            s.Append(" from opdrec a, service b, servgroup c ");
            s.Append(" where a.servid=b.servid and ");
            s.Append(" b.grpid=c.grpid and ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.inv_no in (select a.inv_no from opdbill a ");
            s.Append(" left join bedrack b on a.bedno=b.bedno ");
            s.Append(" left join member c on a.hospid=c.hospid where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end and ");
            s.Append(" a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and isnull(b.wardno,0) = case when @wardno=0 then isnull(b.wardno,0) else @wardno end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 then ");
            s.Append(" ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" and isnull(c.orgid,0) = case when @orgid=0 then isnull(c.orgid,0) else @orgid end ");
            s.Append(" ) ");
            s.Append(" and c.groupname like '%'+@search+'%' ");
            s.Append(" group by c.grpid, c.groupname ");
            s.Append(" union all ");
            s.Append(" select c.grpid, c.groupname, 0 as NOB, 0.00 as Amount, ");
            s.Append(" 0.00 as Discount, 0.00 as Net, ");
            s.Append(" 0.00 as taxable, ");
            s.Append(" 0.00 as nontaxable, ");
            s.Append(" 0.00 as vatamt, ");
            s.Append(" 0.00 as Total, 0.00 as dueamt, 0.00 as Paid, ");
            s.Append(" sum(a.DuePaid) as DuePaid, count(a.hospid) as NOP ");
            s.Append(" from opdrec a, service b, servgroup c ");
            s.Append(" where a.servid=b.servid and ");
            s.Append(" b.grpid=c.grpid and ");
            s.Append(" a.rdate>=@init and a.rdate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a ");
            s.Append(" left join member b on a.hospid=b.hospid where 1=1 ");
            s.Append(" AND a.firm=@firm ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end ");
            s.Append(" and a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 then ");
            s.Append(" ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" and isnull(b.orgid,0) = case when @orgid=0 then isnull(b.orgid,0) else @orgid end ");
            s.Append(" ) ");
            s.Append(" and c.groupname like '%'+@search+'%' ");
            s.Append(" and c.grpid not in ");
            s.Append(" ( select c.grpid ");
            s.Append(" from opdrec a, service b, servgroup c ");
            s.Append(" where a.servid=b.servid and ");
            s.Append(" b.grpid=c.grpid and ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.inv_no in (select a.inv_no from opdbill a ");
            s.Append(" left join bedrack b on a.bedno=b.bedno ");
            s.Append(" left join member c on a.hospid=c.hospid ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end ");
            s.Append(" and a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and isnull(b.wardno,0) = case when @wardno=0 then isnull(b.wardno,0) else @wardno end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 then ");
            s.Append(" ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" and isnull(c.orgid,0) = case when @orgid=0 then isnull(c.orgid,0) else @orgid end ");
            s.Append(" ) ");
            s.Append(" and c.groupname like '%'+@search+'%' ");
            s.Append(" group by c.grpid, c.groupname ) ");
            s.Append(" group by c.grpid, c.groupname ");
            s.Append(" order by Amount desc ");
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

        public void ServiceGroupWiseSalesSum()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_ServiceGroupWiseSalesSumByDate(@init datetime, @final datetime, @firm int,@val int,@ipd int, ");
            s.Append(" @insurance int,@refid int ,@initbilltime varchar(15),@finalbilltime varchar(15),@wardno int,@orgid int,@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" select sum(a.qty) as NOB, sum(qty*rate)as Amount, ");
            s.Append(" sum(a.disc_amt)as Discount, sum( (a.qty*a.rate)-(a.disc_amt) )as Net, ");
            s.Append(" sum(case when vatamt<>0 then (qty*rate)-disc_amt else 0 end) as taxable, ");
            s.Append(" sum(case when vatamt<>0 then 0 else (qty*rate)-disc_amt end) as nontaxable, ");
            s.Append(" sum(a.vatamt) as Vatamt, ");
            s.Append(" sum( (a.qty*a.rate)-(a.disc_amt) +(a.vatamt ) )as Total, sum(a.dueamt) as dueamt, sum(a.paid) as paid ");
            s.Append(" from opdrec a ");
            s.Append(" left join service b on a.servid=b.servid ");
            s.Append(" left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where ");
            s.Append(" a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.inv_no in (select a.inv_no from opdbill a ");
            s.Append(" left join bedrack b on a.bedno=b.bedno ");
            s.Append(" left join member c on a.hospid=c.hospid where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.billtime>=case when @initbilltime='0' then a.billtime else @initbilltime end and ");
            s.Append(" a.billtime<=case when @finalbilltime='0' then a.billtime else @finalbilltime end ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and isnull(b.wardno,0) = case when @wardno=0 then isnull(b.wardno,0) else @wardno end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 then ");
            s.Append(" ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" and isnull(c.orgid,0) = case when @orgid=0 then isnull(c.orgid,0) else @orgid end ");
            s.Append(" ) ");
            s.Append(" and c.groupname like '%'+@search+'%' ");




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

        public void ServiceGroupWiseSalesDue()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_ServiceGroupWiseSalesDuePaidByDate(@init datetime, @final datetime, @firm int,@val int,@ipd int, ");
            s.Append(" @insurance int,@refid int,@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" select sum(a.duepaid) as duepaid ");
            s.Append(" from opdrec a ");
            s.Append(" left join service b on a.servid=b.servid ");
            s.Append(" left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where ");
            s.Append(" a.rdate>=@init and a.rdate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.inv_no in (select inv_no from opdbill a where 1=1 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) =case when @refid=0 then ");
            s.Append(" ISNULL(case when @val=1 then a.refid when @val=0 then a.consid end,0) else @refid end ");
            s.Append(" ) ");
            s.Append(" and c.groupname like '%'+@search+'%' ");




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