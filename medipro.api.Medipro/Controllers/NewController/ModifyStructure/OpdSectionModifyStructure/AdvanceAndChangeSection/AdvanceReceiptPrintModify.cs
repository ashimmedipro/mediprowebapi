using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceReceiptPrintModify
    {
        public void AdvanceReceiptPrintSelect()
        {

            StringBuilder s = new StringBuilder();


            s.Append(" Create procedure sp_AdvanceReceiptPrintGetBySn @sn int ");
            s.Append(" as ");
            s.Append(" select A.SN, a.ddate, A.HOSPID, a.amount, b.pname, a.Remarks, ");
            s.Append(" c.bs_date, d.username, b.address, b.telephone, b.contact, b.dob, b.sex ");
            s.Append(" from advance a left join member b on a.hospid=b.hospid ");
            s.Append(" left join calendar c on a.ddate=c.ad_date left join userlist d on a.[user]=d.userid ");
            s.Append(" where a.sn=@sn ");





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