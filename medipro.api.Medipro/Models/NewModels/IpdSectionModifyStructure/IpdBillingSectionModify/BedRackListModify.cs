using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdBillingSectionModify
{
    public class BedRackListModify
    {
        public void BedRackSelect()
        {

            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_BedrackSelect ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select a.*, b.particular, d.pname, e.bs_date, (select 'Y' from bedrack where a.bedno=bedno and booked=1 ) as book ");
            s.Append(" from ");
            s.Append(" bedrack a left join ward b on a.wardno=b.wardno ");
            s.Append(" left join inpatient c on a.ipdno=c.ipdno ");
            s.Append(" left join member d on c.hospid=d.hospid ");
            s.Append(" left join calendar e on a.admitdate=e.ad_date and a.ipdno>0 where a.remarkstype<>'Inactive' and a.bedno like '%%' or d.pname like '%%' ");
            s.Append(" order by b.wardno, a.bedno ");
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