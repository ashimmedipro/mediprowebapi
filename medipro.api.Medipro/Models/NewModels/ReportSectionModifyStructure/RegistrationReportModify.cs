using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class RegistrationReportModify 
    {
        public void RegReport()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_registrationSelect @init datetime, @final datetime, @search varchar(100), @type char(3), @userid int ");
            s.Append(" as ");
            s.Append(" select ROW_NUMBER() over (order by a.ddate, a.inv_no) as sn, c.bs_date, a.ddate, a.inv_no, a.hospid, b.pname, a.ageday/365 as age, b.sex, ");
            s.Append(" d.servname, e.referer, f.referer as consultant, a.amount, a.new as new1, a.old, a.er,a.insurance, a.member, a.p_type, a.billmode ");
            s.Append(" from registration a ");
            s.Append(" left join member b on a.hospid=b.hospid ");
            s.Append(" left join calendar c on a.ddate=c.ad_date ");
            s.Append(" left join service d on a.servid=d.servid ");
            s.Append(" left join referer e on a.refid=e.refid ");
            s.Append(" left join referer f on a.consid=f.refid ");
            s.Append(" where a.ddate between @init and @final ");
            s.Append(" and a.new = case when @type='New' then 1 else a.new end ");
            s.Append(" and a.old = case when @type='Old' then 1 else a.old end ");
            s.Append(" and a.er = case when @type='Er' then 1 else a.er end ");
            s.Append(" and a.userid = case when @userid=0 then a.userid else @userid end ");
            s.Append(" and (b.pname like '%'+@search+'%' or a.hospid like '%'+@search+'%' ) ");
            s.Append(" order by a.ddate, a.inv_no ");

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