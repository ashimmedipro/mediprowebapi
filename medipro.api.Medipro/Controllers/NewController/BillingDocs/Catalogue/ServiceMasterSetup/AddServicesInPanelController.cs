using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.ServiceMasterSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.ServiceMasterSetup
{
    public class AddServicesInPanelController : ApiController
    {
         
        //search
        [HttpGet]
        [Route("api/AddServPanel/Search")]
        public IHttpActionResult Search(string search="")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<AddServicePanelSearch_dt>
                    ("sp_GetServicePanelList", new { Search=search }).ToList();
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

        //get by panel id 

        [HttpGet]
        [Route("api/AddServPanel/SelectByPanelId")]
        public IHttpActionResult PanelIdGet(int panelid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<AddServPanelGetByPanelid_dt>
                    ("sp_GetServicePanelDetails", new { panelid = panelid }).ToList();
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

        //get total

        [HttpGet]
        [Route("api/AddServPanel/Total")]
        public IHttpActionResult Total(int panelid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<TotalGet_dt>
                    ("sp_GetServiceDetailsSum", new { panelid = panelid }).ToList();
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

        //search service name
        //api already created 

        //Add Service Panel
        [HttpPost]
        [Route("api/AddServPanel/Insert")]
        public IHttpActionResult PostServGroup(ServicePanelPost_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_ServicePanelAdd", model);
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

        //Service panel Update

        [HttpPost]
        [Route("api/AddServPanel/Update")]
        public IHttpActionResult Update(ServicePanelUpdate_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_ServicePanelEdit", model);
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

        //Servname get 

        [HttpGet]
        [Route("api/ServanameGet")]
        public IHttpActionResult ServnameGet(string search="")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServNameGet_dt>
                    ("ServiceRptServGet ", new { search = search }).ToList();
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


        //report

        [HttpGet]
        [Route("api/ServPanel/Report")]
        public IHttpActionResult ServnameRpt()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServPanelRpt_dt>
                    ("sp_ServicePanelReport ").ToList();
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
