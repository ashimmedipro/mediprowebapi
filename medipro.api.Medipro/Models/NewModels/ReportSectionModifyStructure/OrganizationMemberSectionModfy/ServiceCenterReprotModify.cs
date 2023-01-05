using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class ServiceCenterReprotModify
    {
        public void GrpName()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_ac_codeSelectbyGroupName ");
            s.Append("  ");
            s.Append(" as ");
            s.Append(" select * from servgroup ");
            s.Append(" where upper(groupname) like '%%' ");
            s.Append(" order by groupname ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void ServCenterRptGet()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" Create procedure sp_ServCenterRepGetByDateRange(@init datetime, @final datetime, @grpid int) ");
            s.Append(" as ");
            s.Append(" select a.ddate, b.bs_date,a.inv_no, a.servid, c.Pname, f.orgname, ");
            s.Append(" a.qty*a.rate as amount, ");
            s.Append(" a.qty*a.rate*a.disc/100 as discount, ");
            s.Append(" ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 as Tax, ");
            s.Append(" ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+(((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100)) as Total ");
            s.Append(" from opdrec a, calendar b, Member c, opdbill d, service e, organiz f ");
            s.Append(" where a.hospid=c.hospid ");
            s.Append(" and a.ddate=b.ad_date ");
            s.Append(" and a.servid=e.servid ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and a.inv_no=d.inv_no ");
            s.Append(" and d.p_type='Credit' ");
            s.Append(" and e.grpid=@grpid ");
            s.Append(" and c.orgid=f.orgid ");

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