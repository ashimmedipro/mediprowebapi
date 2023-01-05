using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class PatientRecordModify
    {
        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_PatientRecMemberGet%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_PatientRecMemberGet  ");
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

        //
        public void PatientRecMemGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create proc sp_PatientRecMemberGet @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select top 100 0 as ac_code, d.Detail as district, e.nagar_vdc, 0 as member_code, c.fileno, a.*, datediff(year, dob, getdate()) as age, ' ' as orgname, ");
            s.Append(" ' ' as account_name, ' ' as account_name1, b.discount_name, b.type as discount_type from member a WITH (NOLOCK) ");
            s.Append(" left join discount_name b WITH (NOLOCK) on a.discount_id=b.discount_id left join PatientFileNo c WITH (NOLOCK) on a.hospid=c.hospid ");
            s.Append(" LEFT JOIN District d on A.dis_id=d.Dis_id ");
            s.Append(" left join nagar_vdc e on A.nagar_vdc_id=e.sn ");
            s.Append(" where ");
            s.Append(" 1=1 and ");
            s.Append(" member=0 and ");
            s.Append(" locked=0 and ( pname like '%'+@search+'%' or A.hospid like '%'+@search+'%') ");
            s.Append(" and ( address like '%%' and telephone like '%%' ) ");
            s.Append(" and a.hospid= case when 0=0 then a.hospid else 0 end ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void MemOpdRec()
        {
            StringBuilder s = new StringBuilder();
            //query encrypted

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void MemPharmaRec()
        {
            StringBuilder s = new StringBuilder();
            //query encrypted

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void ServvsPatient()
        {
            StringBuilder s = new StringBuilder();

            //query encrypted

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