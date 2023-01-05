using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class PeriodicChangeRegisterModify
    {
        public void PeriodicChangeRegisterSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_ChangeRegisterSelectByDateRange(@initdate DateTime, @finaldate DateTime) ");
            s.Append(" as ");
            s.Append(" select a.*, b.pname, c.bs_date, d.username, e.username as receivedby ");
            s.Append(" from change a left join ");
            s.Append(" member b on a.hospid=b.hospid left join calendar c on a.ddate=c.ad_Date ");
            s.Append(" left join userlist d on a.[user]=d.userid ");
            s.Append(" left join userlist e on a.user1=e.userid ");
            s.Append(" where a.ddate>=@initdate and a.ddate<=@finaldate ");




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