using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class PatientHistoryModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_PatientHistoryHospidSelect%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_PatientHistoryHospidSelect  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_PatientHistoryGetByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_PatientHistoryGetByDate  ");
            s.Append(" end ");

            //
            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_PatientHistoryDiscountByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_PatientHistoryDiscountByDate  ");
            s.Append(" end ");

            //

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_PatientHistorySumByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_PatientHistorySumByDate  ");
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
        public void PatientHisHospidGet()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create proc sp_PatientHistoryHospidSelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select top(100)*, datediff(year, dob,getdate()) as age from member where ");
            s.Append(" ( pname like '%'+@search+'%' or hospid like '%'+@search+'%') order by pname ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void PatientHisGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_PatientHistoryGetByDate(@init datetime, @final datetime, @firm int, @hospid int) ");
            s.Append(" as ");
            s.Append(" select c.bs_Date, a.ddate, a.inv_no, b.pname, a.amount, ");
            s.Append(" a.discount+isnull( sum(d.discount),0 ) as discount, ");
            s.Append(" a.amount-a.discount-isnull( sum(d.discount),0 ) ");
            s.Append(" as Taxable,a.vat, a.amount-a.discount+a.vat as Net ");
            s.Append(" from opdbill a ");
            s.Append(" left join member b on a.hospid=b.hospid ");
            s.Append(" left join calendar c on a.ddate=c.ad_date ");
            s.Append(" left join invoicediscount d on a.inv_no=d.inv_no ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm and a.hospid=@hospid ");
            s.Append(" group by c.bs_Date, a.ddate, a.inv_no, b.pname, a.amount, a.discount, a.vat ");
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

        public void PatientHisDis()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_PatientHistoryDiscountByDate(@init datetime, @final datetime, @firm int, @hospid int) ");
            s.Append(" as ");
            s.Append(" select Sum(a.discount) as Discount ");
            s.Append(" from invoicediscount a ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=@firm and a.inv_no in (select inv_no from opdbill ");
            s.Append(" where ddate>=@init and ddate<=@final and firm=@firm and hospid=@hospid ) ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void PatientHisSum()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_PatientHistorySumByDate(@init datetime, @final datetime, @firm int, @hospid int) ");
            s.Append(" as ");
            s.Append(" select sum(a.amount) as Amount, Sum(a.discount) as Discount, Sum(a.amount-a.discount) ");
            s.Append(" as Taxable, SUm(a.vat) as Vat, Sum(a.amount-a.discount+a.vat) as Net ");
            s.Append(" from opdbill a ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=@firm and a.hospid=@hospid ");



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