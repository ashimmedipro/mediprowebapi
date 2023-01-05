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
    public class DermatologyDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/DermatologyDetails/Update")]
        public IHttpActionResult Update(DermatologyDetails_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsUpdate", model);
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
        [Route("api/DermatologyDetails")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DermatologyDetailsSelect_dt>
                ("sp_Dermatology_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/DermatologyDetails/Delete")]
        public IHttpActionResult Delete(DermatologyDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsDelete", model);
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
