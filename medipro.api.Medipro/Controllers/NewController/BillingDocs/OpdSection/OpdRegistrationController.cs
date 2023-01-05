using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.OpdRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.OpdSection
{
    public class OpdRegistrationController : ApiController
    {


        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/Service/Select")]
        public IHttpActionResult ServSelect()
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<ServSelectByReg_dt>
                ("sp_ServiceSelectByReg").ToList();
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
        [Route("api/OpdSection/OpdRegistration/Registration/Select")]
        public IHttpActionResult MemberSelect(DateTime init, DateTime final, string search, string type, int userid)
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OpdRegMemberSelect_dt>
    ("sp_registrationSelect", new { init = init, final = final, search = search, type = type, userid = userid }).ToList();
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
        [Route("api/OpdSection/OpdRegistration/GeneralMember/Select")]
        public IHttpActionResult GeneralSelect(string search)
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OpdRegMemberSelect_dt>
    ("sp_OpdRegHospidSelect", new { search = search }).ToList();
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

        //without search
        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/GeneralMember/Select")]
        public IHttpActionResult GeneralSelect1()
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OpdRegMemberSelect_dt>
    ("sp_OpdRegHospidSelect", new { search = " " }).ToList();
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

        //without search 
        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/Department/Select")]
        public IHttpActionResult DepartmentSelect()
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OpdRegDepartmentSelect_dt>
    ("sp_OpdRegDepartmentSelect", new { search=" " }).ToList();
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

        //with search 

        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/Department/Select")]
        public IHttpActionResult DepartmentSelect(string search)
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OpdRegDepartmentSelect_dt>
    ("sp_OpdRegDepartmentSelect", new { search = search }).ToList();
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


        //


        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/Consultant/Select")]
        public IHttpActionResult ConsultantSelect()
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OpdRegConsultantSelect_dt>
    ("sp_OpdRegConsultantSelect").ToList();
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

        //[HttpGet]
        //[Route("api/OpdSection/OpdRegistration/ReferedBy/Select")]
        //public IHttpActionResult ReferedSelect()
        //{
        //    var list = DapperHelper.QueryStoredProcedure<OpdRegConsultantSelect_dt>
        //        ("sp_OpdRegReferedBySelect").ToList();//
        //    return Ok(list);
        //}

        [HttpPost]
        [Route("api/OpdSection/OpdRegistration/Insert")]
        public IHttpActionResult PostOpdTempRec(OpdRegInsert_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_OpdRegistrationInsert", model);
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

        //without search 
        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/Member/Select")]
        public IHttpActionResult MemberSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<MemberSelect_dt>
                    ("sp_OpdRegHospidSelectMember", new { search =" "}).ToList();
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


        //with search 
        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/Member/Select")]
        public IHttpActionResult MemberSelect1(string search)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<MemberSelect_dt>
                    ("sp_OpdRegHospidSelectMember", new { search = search }).ToList();
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
        [Route("api/OpdSection/OpdRegistration/Organiz/Select")]
        public IHttpActionResult OrgSelect()
        {
            try
            {
                var list = DapperHelper.QueryStoredProcedure<OrganizSelect_dt>
                    ("sp_OrganizeSelect").ToList();
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
