using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController
{
    public class Userlist_CmplistController : ApiController
    {






        //post
        [HttpPost]
        [Route("api/UserCmplistInsert")]
        public IHttpActionResult TempPost(Temp_Urselist_CmplistInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_UserlistToCmplistInsert", model);
            return Ok();
        }


        //get 
        [HttpGet]
        [Route("api/UserCmplist/Get")]
        public IHttpActionResult Report(int userid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<UserCmplistGet_dt>
                    ("sp_UserCmpListGet", new { userid=userid}).ToList();
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

        //delete

        [HttpPost]
        [Route("api/UserCmplistDelete")]
        public IHttpActionResult TempDelete(Temp_Urselist_CmplistDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_UserCmpListDeleteBySn", model);
            return Ok();
        }

    }
}
