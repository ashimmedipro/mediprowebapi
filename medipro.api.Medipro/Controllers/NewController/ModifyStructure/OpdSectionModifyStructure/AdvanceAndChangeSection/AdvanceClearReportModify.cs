using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceClearReportModify
    {

        public void AdvanceClearReportSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_AdvClrRptSelectByDateRng(@initdate DateTime, @finaldate DateTime) ");
            s.Append(" as ");
            s.Append(" select a.*, b.pname, c.bs_date, d.username, e.username as receivedby, f.bs_date as inv_date ");
            s.Append(" from advance a left join ");
            s.Append(" member b on a.hospid=b.hospid left join calendar c on a.Clear_date=c.ad_Date ");
            s.Append(" left join userlist d on a.[user]=d.userid ");
            s.Append(" left join userlist e on a.user1=e.userid ");
            s.Append(" left join calendar f on a.ddate=f.ad_date ");
            s.Append(" where a.clear_date>=@initdate and a.clear_date<=@finaldate ");
            s.Append(" order by a.clear_date ");







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