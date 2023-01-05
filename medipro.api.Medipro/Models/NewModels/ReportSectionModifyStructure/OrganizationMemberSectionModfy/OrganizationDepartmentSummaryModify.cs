using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class OrganizationDepartmentSummaryModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OrganizeSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrganizeSelect  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_DeptSelectbyOrgid%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_DeptSelectbyOrgid  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OrgDeptSmrySelectByDateRange%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrgDeptSmrySelectByDateRange  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OrgDeptSmrySumSelectByDateRange%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrgDeptSmrySumSelectByDateRange  ");
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
        public void OrganizSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" CREATE procedure sp_OrganizeSelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select * from organiz ");
            s.Append(" where ( upper(ORGNAME) like '%'+@search+'%') ");
            s.Append(" order by orgname ");



            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void DeptSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_DeptSelectbyOrgid (@orgid int) ");
            s.Append(" as ");
            s.Append(" Select * from empdept where orgid=@orgid ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OrgDeptSmrySelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_OrgDeptSmrySelectByDateRange(@orgid int, @dptid int , @init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select c.groupname, sum(a.qty*a.rate) as amount, sum(a.qty*a.rate*a.disc/100) as discount, ");
            s.Append(" sum( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) as vat, ");
            s.Append(" sum( (a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) ) as Net ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where a.hospid in (select hospid from member where orgid=@orgid and dptid=@dptid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill where p_type='Credit') ");
            s.Append(" group by c.groupname, c.grpid ");
            s.Append(" Union ");
            s.Append(" select 'PRECRIPTION DRUGS' AS GROUPNAME, SUM(AMOUNT), SUM(DISCOUNT) AS DISCOUNT, 0 AS VAT, SUM(AMOUNT-DISCOUNT) AS NET ");
            s.Append(" from sales where salestype='SR' AND MEMBER=1 AND HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid and dptid=@dptid) ");
            s.Append(" and ddate>=@init and ddate<=@final ");
            s.Append(" Union ");
            s.Append(" select 'PRECRIPTION DRUGS RETURN' AS GROUPNAME, SUM(-AMOUNT), SUM(-DISCOUNT) AS DISCOUNT, 0 AS VAT,-SUM(AMOUNT-DISCOUNT) AS NET ");
            s.Append(" from CRNOTE where (salestype<>'VR' OR SALESTYPE<>'YD') AND MEMBER=1 AND HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid and dptid=@dptid ) ");
            s.Append(" and ddate>=@init and ddate<=@final ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void OrgDeptSmrySumSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_OrgDeptSmrySumSelectByDateRange(@orgid int, @dptid int , @init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select sum(amount) as amount, sum(discount) as discount, sum(vat) as vat, sum(net) as net ");
            s.Append("  ");
            s.Append(" from ( ");
            s.Append(" select c.groupname, sum(a.qty*a.rate) as amount, sum(a.qty*a.rate*a.disc/100) as discount, ");
            s.Append(" sum( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) as vat, ");
            s.Append(" sum( (a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) ) as Net ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where a.hospid in (select hospid from member where orgid=@orgid and dptid=@dptid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill where p_type='Credit') ");
            s.Append(" group by c.groupname, c.grpid ");
            s.Append(" Union ");
            s.Append(" select 'PRECRIPTION DRUGS' AS GROUPNAME, SUM(AMOUNT), SUM(DISCOUNT) AS DISCOUNT, 0 AS VAT, SUM(AMOUNT-DISCOUNT) AS NET ");
            s.Append(" from sales where salestype='SR' AND MEMBER=1 AND HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid and dptid=@dptid ) ");
            s.Append(" and ddate>=@init and ddate<=@final ");
            s.Append(" Union ");
            s.Append(" select 'PRECRIPTION DRUGS RETURN' AS GROUPNAME, SUM(-AMOUNT), SUM(-DISCOUNT) AS DISCOUNT, 0 AS VAT,-SUM(AMOUNT-DISCOUNT) AS NET ");
            s.Append(" from CRNOTE where (salestype<>'VR' OR SALESTYPE<>'YD') AND MEMBER=1 AND HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid and dptid=@dptid ) ");
            s.Append(" and ddate>=@init and ddate<=@final ");
            s.Append(" ) a ");

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