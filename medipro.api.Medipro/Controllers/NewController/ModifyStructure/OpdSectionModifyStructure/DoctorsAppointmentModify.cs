using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class DoctorsAppointmentModify
    {

        public void DoctorAppForm()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DoctorAppointmentForm(@app_date datetime) ");
            s.Append(" as ");
            s.Append(" select 'OFF-LINE' AS TY, a.intime+' - '+a.outtime as timing, ");
            s.Append(" d.bs_date, a.app_date, a.hospid, a.pname, a.address, a.sex, a.age , a.remarks, ");
            s.Append(" a.telephone, a.appointment_id, cast( 1 as bit) as review ");
            s.Append(" from appointment a ");
            s.Append(" left join calendar d on a.app_date=d.ad_date ");
            s.Append(" where a.app_date=@app_date and a.refid= case when 0=0 then a.refid else 0 END ");
            s.Append(" UNION ALL ");
            s.Append(" select 'ON-LINE' AS TY, a.appointment_time as timing, ");
            s.Append(" d.bs_date, a.appointment_date as app_date, 0 as hospid, a.pname, a.address, a.sex, a.age , cast( a.remarks as varchar(200)) as remarks, ");
            s.Append(" a.mobile as telephone, ltrim(str(a.sn)) as appointment_id, review ");
            s.Append(" from online_appointment a ");
            s.Append(" left join calendar d on CAST( a.appointment_date AS DATE)=d.ad_date ");
            s.Append(" where CAST( a.appointment_date AS DATE)=@app_date and a.refid= case when 0=0 then a.refid else 0 END ");
            s.Append(" order by timing ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void AllDocSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" Create procedure sp_AllDoctorSelect ");
            s.Append(" as ");
            s.Append(" select a.refid, a.referer, a.sp_id, a.ac_code , b.detail, a.min, case a.oncall WHEN 1 THEN 'Oncall' ELSE '' END as OnCall, a.qualification ");
            s.Append(" from referer a left join speciality b on a.sp_id=b.sp_id ");
            s.Append(" where a.referer like '%%' ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void DocAppAllTimSlotByDaySelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DoctorAppntSelectAllTimeSlotsByDay(@dayname varchar(15)) ");
            s.Append(" as ");
            s.Append(" select intime, outtime from doctor_schedual where substring(dayname,2,20)=@dayname ");
            s.Append(" group by intime, outtime order by intime, outtime ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void DocTimeSlotbyRefidSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DoctorTimeSlotGetByRefId(@refid int) ");
            s.Append(" as ");
            s.Append(" select intime+'-'+outtime as timeslot from doctor_schedual ");
            s.Append(" where ref_id=@refid group by intime, outtime, intime+'-'+outtime order by intime, outtime ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void DocDayAvilableByRefidSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_DocDaysAvailableGetbyRefid(@refid int) ");
            s.Append(" as ");
            s.Append(" select substring(a.dayname, 1,1) as sn, substring(a.dayname,2,15) as dayname ");
            s.Append(" from doctor_schedual a where a.ref_id=@refid group by substring(a.dayname, 1,1), substring(a.dayname,2,15) ");


            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void DoctorAvailableTimeByDay()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_DoctorAvailableTimeSlotByDay(@refid int, @dayname varchar(15)) ");
            s.Append(" as ");
            s.Append(" select intime+' - '+outtime as timeslot, * from doctor_schedual ");
            s.Append(" where ref_id=@refid and substring(dayname,2,15)=@dayname order by intime , outtime ");

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