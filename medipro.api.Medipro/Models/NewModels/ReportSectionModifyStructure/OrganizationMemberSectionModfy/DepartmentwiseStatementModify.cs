using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class DepartmentwiseStatementModify
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
            s.Append(" where (name like '%sp_DeptWiseStmtDateRangeSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_DeptWiseStmtDateRangeSelect  ");
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


        //

        public void DeptSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_DeptSelectbyOrgid(@orgid int) ");
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

        //

        public void DeptSelectByDate()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create proc sp_DeptWiseStmtDateRangeSelect(@hospid int, @init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select a.ddate, b.bs_date,a.inv_no, a.servid, c.servname, ");
            s.Append(" a.qty*a.rate as amount, ");
            s.Append(" a.qty*a.rate*a.disc/100 as discount, ");
            s.Append(" ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 as Tax, ");
            s.Append(" ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+(((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100)) as Total ");
            s.Append(" from opdrec a, calendar b, service c, opdbill d ");
            s.Append(" where a.hospid=@hospid ");
            s.Append(" and a.ddate=b.ad_date ");
            s.Append(" and a.servid=c.servid ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and a.inv_no=d.inv_no ");
            s.Append(" and d.p_type='Credit' ");
            s.Append(" UNION ");
            s.Append(" select a.ddate, b.bs_date,a.inv_no, 0 , 'PRESCRIPTION DRUGS' AS servname, ");
            s.Append(" A.amount, ");
            s.Append(" A.discount, ");
            s.Append(" 0 as Tax, ");
            s.Append(" (A.AMOUNT-A.DISCOUNT) as Total ");
            s.Append(" from sales a, calendar b ");
            s.Append(" where a.hospid=@hospid ");
            s.Append(" and a.ddate=b.ad_date ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and A.SALESTYPE='SR' ");
            s.Append(" AND A.MEMBER=1 ");
            s.Append(" UNION ");
            s.Append(" select a.ddate, b.bs_date,a.CR_NO AS inv_no, 0 , 'PRESCRIPTION DRUGS RETURN' AS servname, ");
            s.Append(" -A.amount AS AMOUNT, ");
            s.Append(" -A.discount AS DISCOUNT, ");
            s.Append(" 0 as Tax, ");
            s.Append(" -(A.AMOUNT-A.DISCOUNT) as Total ");
            s.Append(" from CRNOTE a, calendar b ");
            s.Append(" where a.hospid=@hospid ");
            s.Append(" and a.ddate=b.ad_date ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and (A.SALESTYPE='UR' OR A.SALESTYPE='XD') ");
            s.Append(" AND A.MEMBER=1 ");




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