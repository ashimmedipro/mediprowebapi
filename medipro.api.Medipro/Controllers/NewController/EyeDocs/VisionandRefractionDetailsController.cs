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
    public class VisionandRefractionDetailsController : ApiController
    {
       
        [HttpPost]
        [Route("api/VisionandRefractionDetails")]
        public IHttpActionResult Post(VisionandRefractionDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model);
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
        [Route("api/VisionandRefractionDetails/Update")]
        public IHttpActionResult Update(VisionandRefractionDetailsUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsUpdate", model);

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
        [Route("api/VisionandRefractionDetails")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<VisionandRefractionDetailsSelect_dt>
                ("sp_VisionandRefraction_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/VisionandRefractionDetails/Delete")]
        public IHttpActionResult Delete(VisionandRefractionDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsDelete ", model);
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
        [Route("api/VisionandRefraction/TempVisionandRefractionDetailsInsert")]
        
        public IHttpActionResult InsertSingleVision(TempVisionandRefractionDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempVisionandRefraction_detailsInsert ", model);
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
        [Route("api/VisionandRefraction/VisionandRefractionBulkInsert")] 
        public IHttpActionResult VisionandRefractionBulkInsert(VisionandRefractionBulkInsert_dt model)
        {
            try
            {

            

            DapperHelper.ExecuteStoredProcedure("sp_TempVisionandRefraction_detailsBulkInsert ", model);
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
