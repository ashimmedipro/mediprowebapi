using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.RefererPaySetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.RefererPaySetup
{
    public class ConsultantOpdDepartmentSetupController : ApiController
    {
        [HttpGet]
        [Route("api/RefererSetup/ConsultantOpdDeptSetup/RefererGet")]
        public IHttpActionResult RefGet(string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererGet_dt>
                    ("sp_OpdSetupGetReferer", new { search = search }).ToList();
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
        [Route("api/RefererSetup/ConsultantOpdDeptSetup/DeptGet")]
        public IHttpActionResult DeptGet(string search = "")
        {
            try
            {

                var list = DapperHelper.QueryStoredProcedure<DepartmentGet_dt>
                    ("sp_OpdSetupGetDepartment", new { search = search }).ToList();
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
        [Route("api/RefererSetup/ConsultantOpdDeptSetup/RefererDeptGet")]
        public IHttpActionResult RefDeptGet(int refid)
        {
            try
            {

                var list = DapperHelper.QueryStoredProcedure<Ref_DepartmentGet_dt>
                    ("sp_RefererDepartmentGet", new { refid = refid }).ToList();
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
