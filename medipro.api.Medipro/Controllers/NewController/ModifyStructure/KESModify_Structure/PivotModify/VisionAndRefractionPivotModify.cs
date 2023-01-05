using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class VisionAndRefractionPivotModify
    {



        public void VisionRefractionDetailsView()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create view visionandrefraction_details_view ");
            s.Append(" as ");
            s.Append(" select title from visionandrefraction_details ");
            s.Append(" group by title ");








            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void VisionRefractionPivot()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_VisionvisionandRefractionDetailsPivotSelect ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" DECLARE ");
            s.Append(" @columns NVARCHAR(MAX) = '', ");
            s.Append(" @sql NVARCHAR(MAX) = ''; ");
            s.Append(" SELECT ");
            s.Append(" @columns+=QUOTENAME(title) + ',' ");
            s.Append(" FROM ");
            s.Append(" ( ");
            s.Append(" select title from visionandrefraction_details group by title ");
            s.Append(" ) a ");
            s.Append(" where len(title)>0 ");
            s.Append(" ORDER BY ");
            s.Append(" title; ");
            s.Append(" SET @columns = LEFT(@columns, LEN(@columns) - 1); ");
            s.Append(" print @columns ");
            s.Append(" SET @sql =' ");
            s.Append(" SELECT * FROM ");
            s.Append(" ( ");
            s.Append(" SELECT ");
            s.Append(" p.mrdno, ");
            s.Append(" p.result, ");
            s.Append(" p.title, ");
            s.Append(" e.clusterNo, ");
            s.Append(" e.kesId, ");
            s.Append(" p.ddate ");
            s.Append(" FROM ");
            s.Append(" visionandrefraction_details p ");
            s.Append(" INNER JOIN visionandrefraction_details_view c ");
            s.Append(" ON c.title = p.title ");
            s.Append(" left join eye_registration e on p.mrdno=e.mrdno ");
            s.Append(" ) t ");
            s.Append(" PIVOT( ");
            s.Append(" max(result) ");
            s.Append(" FOR title IN ('+ @columns +') ");
            s.Append(" ) AS pivot_table;'; ");
            s.Append("  ");
            s.Append(" print @sql ");
            s.Append(" EXECUTE sp_executesql @sql; ");
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