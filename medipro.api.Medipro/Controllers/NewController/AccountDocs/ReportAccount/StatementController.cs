using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.AccountDocs.ReportAccount.Statement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.AccountDocs.ReportAccount
{
    public class StatementController : ApiController
    {
        [HttpGet]
        [Route("api/Account/ReportAccount/Statement/GroupStatement")]
        public IHttpActionResult GroupStatementGet(int firm, DateTime init, DateTime final, int gr_code)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<GroupStatement_dt>("sp_GroupStatementSelect",
                new { firm=firm, init= init, final= final , gr_code = gr_code }).ToList();
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
        [Route("api/Account/ReportAccount/Statement/SubGroupStatement")]
        public IHttpActionResult SubGroupStatementGet(int firm, DateTime init, DateTime final, int sb_code)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<GroupStatement_dt>("sp_SubGroupStatementSelect",
                new { firm = firm, init = init, final = final, sb_code = sb_code }).ToList();
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
