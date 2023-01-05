using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs.KesId_ClusterNoDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class SummaryResultsController : ApiController
    {
        [HttpGet]
        [Route("api/EyeRegistration/LiteracyReport")]
        public IHttpActionResult Literacy()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<EducationSummaryResults_dt>
                    ("sp_KesLiteracyDetails").ToList();
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
        [Route("api/EyeRegistration/EthnicityReport")]
        public IHttpActionResult Ethnicity()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<EthnicitySummaryResults_dt>
                    ("sp_KesEthnicityDetails").ToList();
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
        [Route("api/EyeRegistration/OccupationReport")]
        public IHttpActionResult Occ()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<OccupationSummaryResults_dt>
                    ("sp_KesOccupationDetails").ToList();
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
        [Route("api/EyeRegistration/ReligionReport")]
        public IHttpActionResult Religion()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ReligionSummaryResults_dt>
                    ("sp_KesReligionDetails").ToList();
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
        [Route("api/EyeRegistration/HypertensionReport")]
        public IHttpActionResult Hypertension()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<HypertensionSummaryResults_dt>
                    ("sp_KesHypertensionDetails").ToList();
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
        [Route("api/EyeRegistration/bmiReport")]
        public IHttpActionResult bmi()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<BmiSummaryResults_dt>
                    ("sp_KesBmiDetails").ToList();
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
