using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class OcularExaminationDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/OcularExaminationDetail")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OcularExaminationDetailSelect_dt>
                ("Ocular_Examination_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/OcularExaminationDetail/delete")]
        public IHttpActionResult Delete(OcularExaminationDetailDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("Ocular_Examination_detailsDelete", model);
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

        //temp

        [HttpPost]
        [Route("api/OcularExamination/TempOcularExaminationDetailInsert")]
        public IHttpActionResult Insert(TempOcularExaminationDetailInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOcular_Examination_detailsInsert", model);
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
        [Route("api/OcularExamination/OcularExaminationDetailBulkInsert")]
        public IHttpActionResult Insert(OcularExaminationDetailBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOcular_Examination_detailsBulkInsert     ", model);
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
        [Route("api/OcularExamination/TempOcularExaminationDetail/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(TempOcularExaminationDetailDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOcular_Examination_details_Delete", model);
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
