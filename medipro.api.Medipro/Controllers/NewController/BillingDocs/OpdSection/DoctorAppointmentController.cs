using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.OpdSection
{
    public class DoctorAppointmentController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/DoctorAppointment/FormSelect")]
        public IHttpActionResult FormSelect(DateTime app_date)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DoctorAppointment_dt>
                    ("sp_DoctorAppointmentForm", new { app_date = app_date }).ToList();
                return Ok(list);

            }

            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/OpdSection/DoctorAppointment/AllTimeSlotSelectByDay")]
        public IHttpActionResult AllTimeSlotSelectByDay(string dayname)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DoctorAppGetTimeSlot_dt>
                    ("sp_DoctorAppntSelectAllTimeSlotsByDay", new { dayname = dayname }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/OpdSection/DoctorAppointment/Doctors/Select")]
        public IHttpActionResult SelectDoctors()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DoctoAllSelect_dt>
                    ("sp_AllDoctorSelect").ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/OpdSection/DoctorAppointment/Doctor/TimeSlot/Select")]
        public IHttpActionResult SelectDoctorTimeSlot(int refid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DoctorTimeSlot_dt>
                    ("sp_DoctorTimeSlotGetByRefId", new { refid = refid }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/OpdSection/DoctorAppointment/Doctor/DaysAvailable/Select")]
        public IHttpActionResult SelectDoctorAvailableDays(int refid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<GetDoctorAvilabledays_dt>
                    ("sp_DocDaysAvailableGetbyRefid", new { refid = refid }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/OpdSection/DoctorAppointment/Doctor/TimeSlotAvailable/Select")]
        public IHttpActionResult SelectDoctorAvailableTimeSlot(int refid, string dayname)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<GetDoctorAvilableTimeSlotByDay_dt>
                    ("sp_DoctorAvailableTimeSlotByDay", new { refid = refid, dayname = dayname }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



    }
}
