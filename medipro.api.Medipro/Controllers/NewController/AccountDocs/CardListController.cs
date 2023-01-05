using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.AccountDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.AccountDocs
{
    public class CardListController : ApiController
    {
        [HttpPost]
        [Route("api/Cardlist")]
        public IHttpActionResult Post(CardList_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_cardlistinsert", model);
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
        [Route("api/Cardlist/Update")]
        public IHttpActionResult Update(CardList_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_cardlistinsert", model);
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
        [Route("api/CardlistSelect")]
        public IHttpActionResult CardlistSelect(string search, bool status)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CardListSelect_dt>
                ("sp_cardlistselect", new { search = search, status = status }).ToList();
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
        [Route("api/CardlistSelect")]
        public IHttpActionResult CardlistSelect( bool status)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<CardListSelect_dt>
                    ("sp_cardlistselect", new { search = "", status = status }).ToList();
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
