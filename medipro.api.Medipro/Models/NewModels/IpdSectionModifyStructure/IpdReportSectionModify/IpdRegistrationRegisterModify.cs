using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdReportSectionModify
{
    public class IpdRegistrationRegisterModify
    {
        public void IpdRegSelect()
        {

            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_IpdRegistrationSelectByDateRange (@init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select c.Particular as ward, a.* from ( ");
            s.Append(" select ");
            s.Append(" isnull( (select top 1 bedno from bedrec where a.ipdno=ipdno order by ddate, billtime ), ");
            s.Append(" a.bedno) as bedno, ");
            s.Append(" a.ddate, a.ipdno, a.hospid, d.fileno, b.pname, b.telephone, a.refid, a.member, a.discharge, e.referer, c.bs_date, ");
            s.Append(" isnull((select sum(amount) as deposit from deposit where a.ipdno=ipdno and a.ddate=ddate and firm=1), 0 ) as deposit ");
            s.Append(" from inpatient a left join member b on a.hospid=b.hospid ");
            s.Append(" left join calendar c on a.ddate=c.ad_date ");
            s.Append(" left join patientfileno d on a.hospid=d.hospid ");
            s.Append(" LEFT JOIN REFERER e on a.refid=e.refid ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=1 ");
            s.Append(" and ( a.ipdno like '%' or b.pname like '%%' ) ");
            s.Append(" ) a ");
            s.Append(" left join bedrack b on a.bedno=b.bedno ");
            s.Append(" left join ward c on b.Wardno=c.wardno ");
            s.Append(" order by a.ddate , a.ipdno ");
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

        public void IpdRegCount()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_IpdRegistrationCountByDateRange(@init datetime, @final datetime) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select count(*) as cnt ");
            s.Append(" from inpatient a left join member b on a.hospid=b.hospid ");
            s.Append(" left join calendar c on a.ddate=c.ad_date ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and a.firm=1 ");
            s.Append(" and ( a.ipdno like '%' or b.pname like '%%' ) ");
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