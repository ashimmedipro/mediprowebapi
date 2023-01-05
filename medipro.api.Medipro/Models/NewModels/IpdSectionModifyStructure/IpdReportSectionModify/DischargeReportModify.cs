using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdReportSectionModify
{
    public class DischargeReportModify
    {
        public void DischargeReportSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DischargeReportSelectByDateRange (@init datetime, @final datetime,@firm int ,@discharge_type varchar(20)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select a.*, b.bs_date, d.pname, a.amount-a.discount as Net, a.amount-a.discount-a.paid as due, ");
            s.Append(" c.ddate as admit_date, e.bs_date as bs_admit_date, datediff( day, c.ddate, a.ddate ) as days, isnull( ");
            s.Append(" (select 'Y' from ipd_morbidity where a.dischargeno=inv_no group by inv_no ),' ' ) as IcdCode ");
            s.Append(" from discharge a left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join inpatient c on a.ipdno=c.ipdno ");
            s.Append(" left join member d on c.hospid=D.hospid ");
            s.Append(" left join calendar e on c.ddate=e.ad_date ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=@firm and d.pname like '%%' ");
            s.Append(" and a.discharge_type=case when @discharge_type='' then a.discharge_type else @discharge_type end ");
            s.Append(" order by a.ddate, a.dischargeno ");
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

        public void DischargeReportCount()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DischargeReportCountByDateRange (@init datetime, @final datetime,@firm int,@discharge_type varchar(20) ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select count(*) as cnt, sum(a.amount) as totamount , sum(a.deposit) as totdeposit, sum(a.paid) as totpaid, ");
            s.Append(" sum(a.discount) as discount, sum(a.amount-a.discount) as Net, sum(a.amount-a.discount-a.paid) as due ");
            s.Append(" from discharge a left join calendar b on a.ddate=b.ad_date ");
            s.Append(" left join inpatient c on a.ipdno=c.ipdno ");
            s.Append(" left join member d on c.hospid=D.hospid ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=@firm and d.pname like '%%' ");
            s.Append(" and a.discharge_type=@discharge_type ");
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