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
    public class PrescriptionGenerationController : ApiController
    {


        [HttpGet]
        [Route("api/OpdSection/PrescriptionGeneration/TempPrescriptionDrug/Select")]
        public IHttpActionResult ReferedSelect(int userid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<TempPrescriptionDrugSelect_dt>
                    ("sp_temp_prescription_drug_Select", new { userid = userid }).ToList();
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
        [Route("api/OpdSection/PrescriptionGeneration/LastPrescriptionDetailNote/Select")]
        public IHttpActionResult LastPrescriptionDetailNote(int hospid, int sn)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<LastPrescriptionDetailNote_dt>
                    ("sp_LastPrescriptionDetailNote", new { hospid = hospid, sn = sn }).ToList();
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

        [HttpPost]
        [Route("api/OpdSection/PrescriptionGeneration/TempPrescriptionDrug/Insert")]
        public IHttpActionResult TempPrescriptionDrugInsert(PrescriptionDrugTempInsert_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_PrescriptionDrugInsertTemp", model);
                return Ok();

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
        [Route("api/OpdSection/PrescriptionGeneration/DoctorEvent/Select")]
        public IHttpActionResult GetDoctorEvent(int refid, DateTime init)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DoctorEventGet_dt>
                    ("sp_DoctorEventCheck", new { refid = refid, init = init }).ToList();
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

        [HttpPost]
        [Route("api/OpdSection/PrescriptionGeneration/Delete")]
        public IHttpActionResult Delete(DeleteProc_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_DeleteProcedure", model);
                return Ok();
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

        [HttpPost]
        [Route("api/OpdSection/PrescriptionGeneration/Prescription/Insert")]
        public IHttpActionResult Insert(PrescriptionInsert_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_PrescriptionInsert", model);
                return Ok();
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


        [HttpPost]
        [Route("api/OpdSection/PrescriptionGeneration/PrescriptionService/Insert")]
        public IHttpActionResult PrescriptionServiceInsert(PrescriptionServiceInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_PrescriptionServiceInsert", model);
            return Ok();

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

        [HttpPost]
        [Route("api/OpdSection/PrescriptionGeneration/PrescriptionDrug/Insert")]
        public IHttpActionResult PrescriptionDrugInsert(PrescriptionServiceInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_PrescriptionDrugInsert", model);
            return Ok();
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
        [Route("api/OpdSection/PrescriptionGeneration/TempPrescriptionService/Select")]
        public IHttpActionResult TempPrescriptionService(int userid, int id)
        {
            try
            {
            
            
            var list = DapperHelper.QueryStoredProcedure<TempPrescriptionServiceSelect_dt>
                ("sp_temp_prescription_service_Select", new { userid = userid, id = id }).ToList();
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
        [Route("api/OpdSection/PrescriptionGeneration/PrescriptionTemplate/Select")]
        public IHttpActionResult PrescriptionTemplate( int id)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrescriptionTemplatesSelect_dt>
                ("sp_PrescriptionTemplatesById", new {  id = id }).ToList();
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


        [HttpPost]
        [Route("api/OpdSection/PrescriptionGeneration/Template/Insert")]
        public IHttpActionResult Template(TemplateInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_PrescriptionDrugInsert", model);
            return Ok();

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
