using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class MemberSalesRegisterModify
    {
        public void MemSalesRegSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_MemberSalesRegisterSelect @init datetime,@final datetime,@firm int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select c.bs_Date, a.ddate, a.inv_no, b.pname, a.amount, a.discount, a.amount-a.discount ");
            s.Append(" as Taxable,a.vat, a.amount-a.discount+a.vat as Net ");
            s.Append(" from opdbill a, member b, calendar c ");
            s.Append(" where a.hospid=b.hospid and a.ddate=c.ad_date ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final and a.billmode='Member' ");
            s.Append(" and a.firm=@firm ");
            s.Append(" order by a.ddate, a.inv_no ");
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

        public void MemSalesRegSum()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_MemberSalesRegisterSum @init datetime,@final datetime,@firm int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select sum(a.amount) as Amount, Sum(a.discount) as Discount, Sum(a.amount-a.discount) ");
            s.Append(" as Taxable, SUm(a.vat) as Vat, Sum(a.amount-a.discount+a.vat) as Net ");
            s.Append(" from opdbill a ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=@firm and a.member=1 ");
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
    }
}