using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy
{
    public class ServicewiseReprotModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%ServiceRptServGet%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc ServiceRptServGet  ");
            s.Append(" end ");


            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_ServiceRptGetByDateRange%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_ServiceRptGetByDateRange  ");
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



        public void ServRptServGet()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create proc ServiceRptServGet @search varchar(50) ");
            s.Append(" as ");
            s.Append(" Select A.*, B.AC_CODE as grpAc_code,b.disc_code,b.plid, ");
            s.Append(" a.ratea+(a.ratea*a.vat/100) as NetFee, b.groupname ");
            s.Append(" from Service A, SERVGROUP B where A.GRPID=B.GRPID AND ");
            s.Append(" a.status='Active' and ( ");
            s.Append(" A.servname like '%'+@search+'%' ");
            s.Append(" or a.servid like '%'+@search+'%' ) ");
            s.Append(" order by a.servname ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void ServwiseRptGet()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create proc sp_ServiceRptGetByDateRange (@servid int, @init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" select a.ddate, b.bs_date,a.inv_no, a.servid, c.Pname, e.OrgName, ");
            s.Append(" a.qty*a.rate as amount, ");
            s.Append(" a.qty*a.rate*a.disc/100 as discount, ");
            s.Append(" ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100 as Tax, ");
            s.Append(" ((a.qty*a.rate)-(a.qty*a.rate*a.disc/100)+(((a.qty*a.rate)-(a.qty*a.rate*a.disc/100))*a.vat/100)) as Total ");
            s.Append(" from opdrec a, calendar b, Member c, opdbill d, Organiz e ");
            s.Append(" where a.hospid=c.hospid ");
            s.Append(" and a.ddate=b.ad_date ");
            s.Append(" and a.servid=@servid ");
            s.Append(" and a.ddate>=@init ");
            s.Append(" and a.ddate<=@final ");
            s.Append(" and a.inv_no=d.inv_no ");
            s.Append(" and d.p_type='Credit' ");
            s.Append(" and c.orgid=e.orgid ");

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