using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class MemberStatementModify
    {

        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_MemberStatemtGetMember%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_MemberStatemtGetMember  ");
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
        public void GetMember()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_MemberStatemtGetMember @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select CAST( b.ref_code+ REPLICATE('0',4-len(a.ref_code))+a.ref_code AS VARCHAR(100)) as new_ref_code, b.ac_code as ac_code1, ");
            s.Append(" a.ac_code as member_code, A.*, B.ORGNAME, c.particular as account_name, ");
            s.Append(" d.particular as account_name1, b.pharma_disc1, b.pharma_disc2, b.insurance, b.ssf_member, b.insurance_product ");
            s.Append(" from MEMBER A with (nolock) left join ORGANIZ B with (nolock) on A.ORGID=B.ORGID ");
            s.Append(" left join ac_code c with (nolock) on a.ac_code=c.ac_code ");
            s.Append(" left join ac_code d with (nolock) on b.ac_code=d.ac_code ");
            s.Append(" where a.orgid=case when 0=0 then a.orgid else 0 end and a.member=1 and ( a.policyid like '%'+@search+'%' or a.ref_code like '%'+@search+'%' ");
            s.Append(" OR A.PNAME like '%'+@search+'%' or a.hospid like '%'+@search+'%' or a.telephone like '%'+@search+'%' or b.ref_code+ REPLICATE('0',4-len( a.ref_code))+a.ref_code ");
            s.Append(" like '%%' ) ");
            s.Append(" order by a.hospid ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }


            


        }


        //dobToYEar

        public void DobToYear()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_dob2year @date datetime ");
            s.Append(" as ");
            s.Append(" DECLARE ");
            s.Append(" @tmpdate datetime, @years int, @months int, @days int ");
            s.Append(" SELECT @tmpdate = @date ");
            s.Append(" SELECT @years = DATEDIFF(yy, @tmpdate, GETDATE()) - CASE WHEN (MONTH(@date) > MONTH(GETDATE())) OR (MONTH(@date) = MONTH(GETDATE()) AND DAY(@date) > DAY(GETDATE())) THEN 1 ELSE 0 END ");
            s.Append(" SELECT @tmpdate = DATEADD(yy, @years, @tmpdate) ");
            s.Append(" SELECT @months = DATEDIFF(m, @tmpdate, GETDATE()) - CASE WHEN DAY(@date) > DAY(GETDATE()) THEN 1 ELSE 0 END ");
            s.Append(" SELECT @tmpdate = DATEADD(m, @months, @tmpdate) ");
            s.Append(" SELECT @days = DATEDIFF(d, @tmpdate, GETDATE()) ");
            s.Append(" SELECT @years as yr, @months as mnt, @days as dy ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OrgMemberReport()
        {
            //query encrypted
        }


        public void OrgMemberReportSmry()
        {
            //query encrypted
        }


    }
}