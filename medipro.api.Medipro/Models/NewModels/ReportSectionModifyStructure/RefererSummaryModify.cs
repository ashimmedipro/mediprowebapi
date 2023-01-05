using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class RefererSummaryModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_RefererSpecialitySelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_RefererSpecialitySelect  ");
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
        public void RefererSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create proc sp_RefererSpecialitySelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select top(100) a.*, b.detail from referer a with (nolock) left join speciality b with (nolock) on a.sp_id=b.sp_id ");
            s.Append(" where ( a.referer like '%'+@search+'%' or a.regno like '%'+@search+'%' ) ");
            s.Append(" AND a.status='Active' ");
            s.Append(" order by referer ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void RefererSmryDetail()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_RefererSummaryGetDetailbyDate(@init datetime, @final datetime, @refid int ,@firm int) ");
            s.Append(" as ");
            s.Append(" select e.inv_no, (e.qty*e.rate) as Amount,e.qty, e.disc_amt as Discount, ");
            s.Append(" e.vatamt as Vat, ");
            s.Append(" b.referer, c.bs_date , e.ddate, d.pname, f.servname from ");
            s.Append(" opdrec e ");
            s.Append(" left join opdbill a on e.inv_no=a.inv_no ");
            s.Append(" left join referer b on a.refid=b.refid ");
            s.Append(" left join calendar c on e.ddate=c.ad_date ");
            s.Append(" left join member d on e.hospid=d.hospid ");
            s.Append(" left join service f on e.servid=f.servid ");
            s.Append(" where ");
            s.Append(" e.ddate>=@init and e.ddate<=@final and ");
            s.Append(" a.refid=@refid ");
            s.Append(" and a.firm=@firm ");
            s.Append(" order by e.inv_no ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void GrpwiseSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create proc sp_RefererSummaryGetGroupwisebyDateRange(@refid int, @init datetime, @final datetime, @firm int) ");
            s.Append(" as ");
            s.Append(" select c.grpid, d.groupname, sum(a.qty) as Nob, sum((a.qty*a.rate)-a.disc_amt ) as namt ");
            s.Append(" from opdrec a left join opdbill b on a.inv_no=b.inv_no left join ");
            s.Append(" service c on a.servid=c.servid ");
            s.Append(" left join servgroup d on c.grpid=d.grpid ");
            s.Append(" where b.refid=@refid and a.ddate>=@init and a.ddate<=@final and a.firm=@firm ");
            s.Append(" group by c.grpid, d.groupname ");


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