using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class OrganizationStatementSummaryModify
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
                s.Append(" where (name like '%sp_OrganizSummaryGroupSelect%' ) ");
                s.Append(" ) ");
                s.Append(" begin ");
                s.Append(" drop proc sp_OrganizSummaryGroupSelect  ");
                s.Append(" end ");

                //

                s.Append(" if exists (select name from sys.procedures ");
                s.Append(" where (name like '%sp_OrganizSummaryGroupSumSelect%' ) ");
                s.Append(" ) ");
                s.Append(" begin ");
                s.Append(" drop proc sp_OrganizSummaryGroupSumSelect  ");
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


        public void OrgSmrySelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_OrganizSummaryGroupSelect(@init datetime, @final datetime, @orgid int ) ");
            s.Append(" as ");
            s.Append(" select c.groupname, sum(a.qty*a.rate) as amount, sum(a.qty*a.rate*a.disc/100) as discount, ");
            s.Append(" sum( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) as vat, ");
            s.Append(" sum( (a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) ) as Net ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where a.hospid in (select hospid from member where orgid=@orgid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill where p_type='Credit') ");
            s.Append(" group by c.groupname, c.grpid ");
            s.Append(" Union all ");
            s.Append(" select 'PRECRIPTION DRUGS' AS GROUPNAME, SUM(a.AMOUNT), SUM(a.DISCOUNT) AS DISCOUNT, ");
            s.Append(" SUM(a.vat+isnull(a.vat_Free,0)) AS VAT, ");
            s.Append(" SUM((a.amount+a.freight-a.discount-a.claim-a.rd-a.scheme-a.extra+a.vat+isnull(a.vat_Free,0)+isnull(a.cc_charge,0)+isnull(a.cc_free,0)-isnull(a.roundoff,0) )) AS NET ");
            s.Append(" from sales a left join inpatient b on a.ipdno=b.ipdno where a.salestype<>'SC' AND (a.MEMBER=1 or b.member=1) AND a.HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" Union all ");
            s.Append(" select 'PRECRIPTION DRUGS RETURN' AS GROUPNAME, SUM(-a.AMOUNT), SUM(-a.DISCOUNT) AS DISCOUNT, -SUM(VAT) AS VAT, ");
            s.Append(" -SUM(a.amount-a.discount-(a.rd+a.claim+a.extra)-a.scheme+a.vat+a.cc_charge+a.cc_free-isnull(a.roundoff,0) ) AS NET ");
            s.Append(" from CRNOTE a left join inpatient b on a.ipdno=b.ipdno where (salestype<>'VR' OR SALESTYPE<>'YD') AND ( a.MEMBER=1 or b.member=1) AND a.HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OrgSmrySumSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_OrganizSummaryGroupSumSelect(@init datetime, @final datetime, @orgid int ) ");
            s.Append(" as ");
            s.Append(" SELECT SUM(AMOUNT) AS AMOUNT, SUM(DISCOUNT) AS DISCOUNT, SUM(VAT) AS VAT, SUM(NET) AS NET ");
            s.Append(" FROM ( ");
            s.Append(" select c.groupname, sum(a.qty*a.rate) as amount, sum(a.qty*a.rate*a.disc/100) as discount, ");
            s.Append(" sum( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) as vat, ");
            s.Append(" sum( (a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+( ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 ) ) as Net ");
            s.Append(" from opdrec a left join service b on a.servid=b.servid left join servgroup c on b.grpid=c.grpid ");
            s.Append(" where a.hospid in (select hospid from member where orgid=@orgid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.inv_no in (select inv_no from opdbill where p_type='Credit') ");
            s.Append(" group by c.groupname, c.grpid ");
            s.Append(" Union all ");
            s.Append(" select 'PRECRIPTION DRUGS' AS GROUPNAME, SUM(a.AMOUNT), SUM(a.DISCOUNT) AS DISCOUNT, ");
            s.Append(" SUM(a.vat+isnull(a.vat_Free,0)) AS VAT, ");
            s.Append(" SUM((a.amount+a.freight-a.discount-a.claim-a.rd-a.scheme-a.extra+a.vat+isnull(a.vat_Free,0)+isnull(a.cc_charge,0)+isnull(a.cc_free,0)-isnull(a.roundoff,0) )) AS NET ");
            s.Append(" from sales a left join inpatient b on a.ipdno=b.ipdno where a.salestype<>'SC' AND (a.MEMBER=1 or b.member=1) AND a.HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" Union all ");
            s.Append(" select 'PRECRIPTION DRUGS RETURN' AS GROUPNAME, SUM(-a.AMOUNT), SUM(-a.DISCOUNT) AS DISCOUNT, -SUM(VAT) AS VAT, ");
            s.Append(" -SUM(a.amount-a.discount-(a.rd+a.claim+a.extra)-a.scheme+a.vat+a.cc_charge+a.cc_free-isnull(a.roundoff,0) ) AS NET ");
            s.Append(" from CRNOTE a left join inpatient b on a.ipdno=b.ipdno where (salestype<>'VR' OR SALESTYPE<>'YD') AND ( a.MEMBER=1 or b.member=1) AND a.HOSPID IN (SELECT HOSPID FROM MEMBER WHERE ORGID=@orgid ) ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" ) A ");


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
