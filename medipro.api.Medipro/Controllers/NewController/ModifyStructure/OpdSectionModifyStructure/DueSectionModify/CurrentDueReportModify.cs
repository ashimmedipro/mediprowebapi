using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.DueSectionModify
{
    public class CurrentDueReportModify
    {

        public void tOpdBillDue()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create table tOpdbillDue( ");
            s.Append(" inv_no varchar(11) , ddate datetime, bs_date varchar(10) , pname , invamt,due, username, referer, reg ");
            s.Append(" ) ");


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


            s.Append(" create procedure sp_RefererSpecialitySelect ");
            s.Append(" as ");
            s.Append(" select a.*, b.detail from referer a with (nolock) left join speciality b with (nolock) on a.sp_id=b.sp_id ");
            s.Append(" where ( a.referer like '%%' or a.regno like '%%' ) ");
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

        public void CurrentDueReportSelect()
        {
            StringBuilder s = new StringBuilder();




            s.Append(" create procedure sp_CurrentDueReportSelect @ddate datetime, @p_type varchar(10),@firm int ");
            s.Append(" as ");
            s.Append(" drop table tOpdbillDue1 ");
            s.Append(" select a.inv_no,a.ddate,c.bs_date, b.pname , cast( (a.amount+a.vat-a.discount - isnull(a.roundoff,0) - sum( isnull( e.discount,0) ) ) as numeric(12,2) ) as invamt, ");
            s.Append(" (cast( (a.amount- a.discount- sum( isnull( e.discount,0) )- isnull(a.roundoff,0) + a.vat)as numeric(12,2) )) - cast(a.paid as numeric(12,2) ) as due, d.username, f.referer, a.reg ");
            s.Append(" INTO tOpdbillDue1 ");
            s.Append(" from opdbill a ");
            s.Append(" left join calendar c on a.ddate=c.ad_Date ");
            s.Append(" left join member b on a.hospid=b.hospid ");
            s.Append(" left join userlist d on a.[user]=d.userid ");
            s.Append(" left join invoiceDiscount e on a.inv_no=e.inv_no ");
            s.Append(" left join referer f on a.refid=f.refid ");
            s.Append(" where ");
            s.Append(" a.ddate<=@ddate ");
            s.Append(" and a.p_type=@p_type ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and b.pname like '%%' ");
            s.Append(" group by a.inv_no, a.ddate, c.bs_date, b.pname, a.amount, a.discount, a.roundoff , a.vat, d.username, a.paid, f.referer, a.reg ");
            s.Append(" having ((cast( (a.amount-a.discount- sum( isnull( e.discount,0) )+a.vat- isnull(a.roundoff,0))as numeric(12,2) ) ) <> cast(a.paid as numeric(12,2) )) ");
            s.Append(" order by a.ddate, a.inv_no ");
            s.Append(" select * from tOpdbillDue1 ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void TOpdbillDue1Select()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_tOpdbillDue1Select ");
            s.Append(" as ");
            s.Append(" select * from tOpdbillDue1 ");
            s.Append(" where pname like '%%' ");
            s.Append(" order by ddate, inv_no ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void TOpdbillDue1TotalSelect()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_tOpdbillDue1TotalSelect ");
            s.Append(" as ");
            s.Append(" select sum(invamt) as invamt, sum(due) as due ");
            s.Append(" from tOpdbillDue1 ");
            s.Append(" where pname like '%%' ");





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