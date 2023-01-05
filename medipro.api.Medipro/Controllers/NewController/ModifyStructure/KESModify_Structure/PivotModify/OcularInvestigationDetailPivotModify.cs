using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class OcularInvestigationDetailPivotModify
    {
        public void OcularInvView()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create view ocular_investigation_Detail_view ");
            s.Append(" as ");
            s.Append(" select title from ocular_investigation_Detail ");
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


        public void OcularInvPivot()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_OcularInvestigationPivotSelect ");
            s.Append(" as ");
            s.Append(" DECLARE ");
            s.Append(" @columns NVARCHAR(MAX) = '', ");
            s.Append(" @sql NVARCHAR(MAX) = ''; ");
            s.Append(" SELECT ");
            s.Append(" @columns+=QUOTENAME(title) + ',' ");
            s.Append(" FROM ");
            s.Append(" ( ");
            s.Append(" select title from ocular_investigation_Detail group by title ");
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
            s.Append(" ocular_investigation_Detail p ");
            s.Append(" INNER JOIN ocular_investigation_Detail_view c ");
            s.Append(" ON c.title = p.title ");
            s.Append(" left join eye_registration e ");
            s.Append(" on p.mrdno=e.mrdno ");
            s.Append(" ) t ");
            s.Append(" PIVOT( ");
            s.Append(" max(result) ");
            s.Append(" FOR title IN ('+ @columns +') ");
            s.Append(" ) AS pivot_table;'; ");
            s.Append(" print @sql ");
            s.Append(" EXECUTE sp_executesql @sql; ");


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