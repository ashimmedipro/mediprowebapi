using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class OrganizationStatementModify
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
            s.Append(" where (name like '%sp_OrganizationStatementMemberSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrganizationStatementMemberSelect  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OrganizationStatementSelectByDateRange%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrganizationStatementSelectByDateRange  ");
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




        public void OrganizeSelect()
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


        public void OrgStmtMemSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_OrganizationStatementMemberSelect(@init datetime, @final datetime, @orgid int) ");
            s.Append(" as ");
            s.Append(" select * from member ");
            s.Append(" where (hospid in ");
            s.Append(" (select hospid from opdbill WHERE ddate>=@init and ddate<=@final and billMode='Member' and p_type='Credit') or ");
            s.Append(" hospid in (select a.hospid from sales a left join inpatient b on a.ipdno=b.ipdno ");
            s.Append(" where (a.member=1 or b.member=1) and salestype<>'SC' and a.ddate>=@init and a.ddate<=@final ) or ");
            s.Append(" hospid in (select a.hospid from crnote a left join inpatient b on a.ipdno=b.ipdno ");
            s.Append(" where (a.member=1 or b.member=1) and (salestype='UR' OR SALESTYPE='XD') and A.ddate>=@init and A.ddate<=@final )) ");
            s.Append(" and orgid=@orgid and member=1 ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }



        public void OrgStmtSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create proc sp_OrganizationStatementSelectByDateRange(@hospid int, @init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select cast( d.claim_code as varchar(30)) as claim_code, a.sn, a.ddate as dt, a.inv_No as inv, a.ddate, b.bs_date,a.inv_no, a.servid, c.servname, ");
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
            s.Append(" union all ");
            s.Append(" select a.claim_code, 1 as sn, a.ddate as dt, a.inv_No as inv, a.ddate, b.bs_date,a.inv_no, 0 , 'PRESCRIPTION DRUGS' AS servname, ");
            s.Append(" A.amount, ");
            s.Append(" A.discount, ");
            s.Append(" A.VAT as Tax, ");
            s.Append(" (a.amount+a.freight-a.discount-a.claim-a.rd-a.scheme-a.extra+a.vat+isnull(a.vat_Free,0)+isnull(a.cc_charge,0)+isnull(a.cc_free,0)-isnull(a.roundoff,0) ) as Total ");
            s.Append(" from sales a left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join inpatient c on a.ipdno=c.ipdno ");
            s.Append(" where a.hospid=@hospid ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and A.SALESTYPE<>'SC' ");
            s.Append(" AND ( A.MEMBER=1 or c.member=1) ");
            s.Append(" UNION all ");
            s.Append(" select a.claim_code, 2 as sn,a.ddate as dt, a.cr_No as inv, a.ddate, b.bs_date,a.CR_NO AS inv_no, 0 , 'PRESCRIPTION DRUGS RETURN' AS servname, ");
            s.Append(" -A.amount AS AMOUNT, ");
            s.Append(" -A.discount AS DISCOUNT, ");
            s.Append(" -A.VAT as Tax, ");
            s.Append(" -(a.amount-a.discount-(a.rd+a.claim+a.extra)-a.scheme+a.vat+a.cc_charge+a.cc_free-isnull(a.roundoff,0) ) as Total ");
            s.Append(" from CRNOTE a left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join inpatient c on a.ipdno=c.ipdno ");
            s.Append(" where a.hospid=@hospid ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and ( A.SALESTYPE='UR' OR A.SALESTYPE='XD' ) ");
            s.Append(" AND ( A.MEMBER=1 or c.member=1) ");
            s.Append(" order by dt, inv ");



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


    //


}