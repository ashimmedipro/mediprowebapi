using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class PrintReceiptModify
    {
        public void PrintReceiptSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" Create Procedure sp_PrintReceiptSelectByRno @r_no varchar(11) ");
            s.Append(" as ");
            s.Append(" select c.bs_date,a.*,b.pname,d.username, e.firmname, e.regno ");
            s.Append(" from receipt a, member b, calendar c, userlist d, ");
            s.Append(" firms e ");
            s.Append(" where a.hospid=b.hospid ");
            s.Append(" and a.ddate=c.ad_date ");
            s.Append(" and a.[user]=d.userid ");
            s.Append(" and a.r_no=@r_no ");
            s.Append(" and a.firm=e.firm ");







            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void SerivceSelect()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_ServiceSelectByInvno @inv_no varchar(11) ");
            s.Append(" as ");
            s.Append(" select b.servname, a.* from opdrec a left join service b on a.servid=b.servid where inv_no=@inv_no ");





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