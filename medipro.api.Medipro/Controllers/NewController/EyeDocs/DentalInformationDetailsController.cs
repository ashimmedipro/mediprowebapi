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
    public class DentalInformationDetailsController : ApiController
    {
        /*[HttpPost]
      [Route("api/DentalInformationDetails")]
      public IHttpActionResult Post(DentalInformationDetailsInsert_dt model)
      {
          DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model);
          return Ok();
      }

      [HttpPost]
      [Route("api/DentalInformationDetails/Update")]
      public IHttpActionResult Update(DentalInformationDetailsUpdate_dt model)
      {
          DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsUpdate", model);
          return Ok();
      }*/

        [HttpGet]
        [Route("api/DentalInformationDetails")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DentalInformationDetailsSelect_dt>
                ("sp_dental_information_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/DentalInformationDetails/Delete")]
        public IHttpActionResult Delete(DentalInformationDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsDelete", model);
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
