using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class OrganizationMemberStatementModify
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
            s.Append(" where (name like '%sp_OrgMemberStatementDateRangeGet%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrgMemberStatementDateRangeGet  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_OrgMemberStatementSumDateRangeGet%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_OrgMemberStatementSumDateRangeGet  ");
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


        public void OrgMemStmtGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_OrgMemberStatementDateRangeGet(@init datetime, @final datetime, @orgid int ) ");
            s.Append(" as ");
            s.Append(" select Z.hospid, Z.pname, Z.policyid, ");
            s.Append(" isnull( (select sum(A.amount) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by A.hospid ),0)+ ");
            s.Append(" isnull( (select sum(A.amount) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid ),0)- ");
            s.Append(" isnull( (select sum(A.amount) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ),0) AS amount , ");
            s.Append(" isnull( (select sum(discount) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by A.hospid ),0)+ ");
            s.Append(" isnull( (select sum(discount) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid),0)- ");
            s.Append(" isnull( (select sum(discount) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ),0) AS discount , ");
            s.Append(" isnull( (select sum(vat) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by hospid ),0)+ ");
            s.Append(" isnull( (select sum(vat) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid ),0)- ");
            s.Append(" isnull( (select sum(vat) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ),0) AS Vat , ");
            s.Append(" isnull( (select sum(A.amount-discount+vat) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by A.hospid ),0)+ ");
            s.Append(" isnull( (select sum(A.amount-discount+vat) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid ),0)- ");
            s.Append(" isnull( (select sum(A.amount-discount+vat) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ");
            s.Append(" ),0) AS Net ");
            s.Append(" from member Z where Z.member=1 and Z.orgid=@orgid ");
            s.Append(" and ( Z.hospid in (select hospid from opdbill where p_type='Credit' and ddate>=@init and ddate<=@final ) or ");
            s.Append(" Z.hospid in (select hospid from sales where salestype<>'SC' and ddate>=@init and ddate<=@final ) or ");
            s.Append(" Z.hospid in (select hospid from CRNOTE where (SALESTYPE<>'VR' or SALESTYPE<>'YD') and ddate>=@init and ddate<=@final ) ) ");
            s.Append(" ORDER BY Z.PNAME ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }



        public void OrgMemStmtSumGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_OrgMemberStatementSumDateRangeGet(@init datetime, @final datetime, @orgid int ) ");
            s.Append(" as ");
            s.Append(" select sum(amount) as amount, sum(discount) as discount, sum(vat) as vat, sum(net) as net ");
            s.Append(" from ");
            s.Append(" ( ");
            s.Append(" select Z.hospid, Z.pname, Z.policyid, ");
            s.Append(" isnull( (select sum(A.amount) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by A.hospid ),0)+ ");
            s.Append(" isnull( (select sum(A.amount) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid ),0)- ");
            s.Append(" isnull( (select sum(A.amount) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ),0) AS amount , ");
            s.Append(" isnull( (select sum(discount) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by A.hospid ),0)+ ");
            s.Append(" isnull( (select sum(discount) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid),0)- ");
            s.Append(" isnull( (select sum(discount) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ),0) AS discount , ");
            s.Append(" isnull( (select sum(vat) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by hospid ),0)+ ");
            s.Append(" isnull( (select sum(vat) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid ),0)- ");
            s.Append(" isnull( (select sum(vat) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ),0) AS Vat , ");
            s.Append(" isnull( (select sum(A.amount-discount+vat) from opdbill A where a.hospid=Z.hospid and p_type='Credit' and ddate>=@init and ddate<=@final group by A.hospid ),0)+ ");
            s.Append(" isnull( (select sum(A.amount-discount+vat) from sales A LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and salestype<>'SC' and A.ddate>=@init and A.ddate<=@final and (A.member=1 OR B.MEMBER=1) group by a.hospid ),0)- ");
            s.Append(" isnull( (select sum(A.amount-discount+vat) from CRNOTE a LEFT JOIN INPATIENT B ON A.IPDNO=B.IPDNO where a.hospid=Z.hospid and (SALESTYPE<>'VR' OR SALESTYPE<>'YD') and a.ddate>=@init and a.ddate<=@final and ( a.member=1 or b.member=1) group by a.hospid ");
            s.Append(" ),0) AS Net ");
            s.Append(" from member Z where Z.member=1 and Z.orgid=@orgid ");
            s.Append(" and ( Z.hospid in (select hospid from opdbill where p_type='Credit' and ddate>=@init and ddate<=@final ) or ");
            s.Append(" Z.hospid in (select hospid from sales where salestype<>'SC' and ddate>=@init and ddate<=@final ) or ");
            s.Append(" Z.hospid in (select hospid from CRNOTE where (SALESTYPE<>'VR' or SALESTYPE<>'YD') and ddate>=@init and ddate<=@final ) ) ");
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