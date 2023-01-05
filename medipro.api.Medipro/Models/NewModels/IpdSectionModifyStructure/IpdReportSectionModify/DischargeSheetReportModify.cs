using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdReportSectionModify
{
    public class DischargeSheetReportModify
    {
        public void DischargeSheetReport()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DischargeSheetReportByDateRange (@init datetime, @final datetime,@firm int ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.*, c.hospid, c.pname, c.address, b.bedno, b.ageday, c.telephone, d.bs_date, c.sex, c.dob, c.member, ");
            s.Append(" h.ddate as ad_discharge_date, i.bs_date as bs_discharge_date, ");
            s.Append(" b.ddate as ad_admit_date, b.contact, h.dischargeno, ");
            s.Append(" e.bs_date as bs_admit_date, f.referer, g.username, ");
            s.Append(" m.referer as consultant, m.regno as cons_nmc, o.bs_date as cons_bs_Date, ");
            s.Append(" n.referer as medical, n.regno as medi_nmc, p.bs_date as medi_bs_date, ");
            s.Append(" q.referer as consultant1, q.regno as cons_nmc1, r.bs_date as cons_bs_date1 ");
            s.Append(" from discharge_sheet a ");
            s.Append(" left join inpatient b on a.ipdno=b.ipdno ");
            s.Append(" left join member c on b.hospid=c.hospid ");
            s.Append(" left join calendar d on a.ddate=d.ad_date ");
            s.Append(" left join calendar e on b.ddate=e.ad_date ");
            s.Append(" left join referer f on a.refid=f.refid ");
            s.Append(" left join userlist g on a.userid=g.userid ");
            s.Append(" left join discharge h on a.ipdno=h.ipdno ");
            s.Append(" left join calendar i on h.ddate=i.ad_date ");
            s.Append(" left join referer m on a.consid=m.refid ");
            s.Append(" left join referer n on a.mediid=n.refid ");
            s.Append(" left join calendar o on a.cons_date=o.ad_date ");
            s.Append(" left join calendar p on a.medi_date=p.ad_date ");
            s.Append(" left join referer q on a.consid1=q.refid ");
            s.Append(" left join calendar r on a.cons_date1=r.ad_date ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=@firm ");
            s.Append(" and c.pname like '%%' ");
            s.Append(" order by a.ddate , a.inv_no ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
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