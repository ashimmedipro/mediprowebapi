using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue
{
    public class ServicePanelController : ApiController
    {
        [HttpGet]
        [Route("api/servicepanelview")]
        public IHttpActionResult ServicePanel()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServicePanelView_dt>
                ("sp_SalesPanelSelect").ToList();
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
        [Route("api/ServicePanelInsert")]
        public IHttpActionResult Insert(ServicePanelInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SalesPanelInsert", model);
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
        [Route("api/ServicePanelUpdate")]
        public IHttpActionResult Update(ServicePanelUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_ServicePanelUpdate", model);
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
        [Route("api/ServicePanelSelectByGrpid")]
        public IHttpActionResult SelectByGrpid(int grpid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServicePanelGetByGrpid_dt>
                ("sp_ServicePanelGetByGrpid", new { grpid = grpid}).ToList();
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
        //[Route("api/ServicePanel/SelectGroup")]
        //public IHttpActionResult SelectGroup()
        //{
        //    var list = DapperHelper.QueryStoredProcedure<ServicePanelGetGroup_dt>
        //        ("sp_ServicePanelSelectGroup").ToList();
        //    return Ok(list);
        //}

        [HttpGet]
        [Route("api/ServicePanel/SelectExternalCode")]
        public IHttpActionResult SelectCode(int firm)
        {
            var list = DapperHelper.QueryStoredProcedure<ServicePanelGetCode_dt>
                ("sp_ServicePanelSelectCode", new { firm = firm }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/ServicePanel/SelectUser")]
        public IHttpActionResult SelectUser()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServicePanelGetUser_dt>
                ("sp_SalesPanelSelectUser").ToList();
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
        //[Route("api/RefererSelect")]
        //public IHttpActionResult SelectReferer()
        //{
        //    var list = DapperHelper.QueryStoredProcedure<ServicePanelGetReferer_dt>
        //        ("sp_SalesPanelSelectReferer").ToList();//change 
        //    return Ok(list);
        //}

        [HttpGet]
        [Route("api/ServiceCheckSelectByServid1")]
        public IHttpActionResult SelectByServid1(int servid1)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceCheckView_dt>
                ("sp_ServiceCheckSelect", new { servid1 = servid1 }).ToList();
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
        [Route("api/ServiceCheckInsert")]
        public IHttpActionResult Insert(ServiceCheckInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_ServiceCheckInsert", model);
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
        [Route("api/ServiceCheckSelect")]
        public IHttpActionResult ServiceCheckSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceCheckSelect_dt>
                ("sp_ServiceCheckSelectServid1").ToList();
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
        [Route("api/ServiceCheckSelectServid2")]
        public IHttpActionResult SelectServid2(int servid1)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceCheckSelectServid2_dt>
                ("sp_ServiceCheckSelectServid2", new { servid1 = servid1 }).ToList();
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
        [Route("api/ServiceCheck/Delete")]
        public IHttpActionResult Delete(ServiceCheckInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_ServiceCheckDelete", model);
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

        //Report

        [HttpGet]
        [Route("api/ServicePanel/Report")]
        public IHttpActionResult Report()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServPanelReport_dt>
                    ("sp_ServicePanelSetupReport").ToList();
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

        //add inculsion list

        [HttpGet]
        [Route("api/ServicePanel/InclusionList")]
        public IHttpActionResult List()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServInculaionList_dt>
                    ("sp_ServInclusionAddList").ToList();
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

        //servname list report 

        [HttpGet]
        [Route("api/ServicePanel/ServiceName/List")]
        public IHttpActionResult ServnameGet()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServiceNameRpt_dt>
                    ("sp_ServnameReport").ToList();
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
