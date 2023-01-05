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
    public class KesUserMenuController : ApiController
    {
        //usermenu insert 
        [HttpPost]
        [Route("api/KesUsermenuInsert")]
        public IHttpActionResult Post(KesUserMenuInsert_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_InsertAllMenuMaster", model);

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


        //user menu edit

        [HttpPost]
        [Route("api/KesUsermenuUpdate")]
        public IHttpActionResult Update(KesUserMenuEdit_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_KesUserMenuEdit", model);

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

        // post select all

        [HttpPost]
        [Route("api/KesUsermenuPostSelectAll")]
        public IHttpActionResult PostSelectAll(KesUserMenuInsert_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_KesUserMenuSelectAll", model);

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

        // post unselect all

        [HttpPost]
        [Route("api/KesUsermenuPostUnSelectAll")]
        public IHttpActionResult PostUnSelectAll(KesUserMenuInsert_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_KesUserMenuUnSelectAll", model);

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





        //user menu select by userid

        [HttpGet]
        [Route("api/kesUserMenuSelectByUserid")]
        public IHttpActionResult GetByUserid(int userid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<KesUserMenuSelect_dt>
                    ("sp_KesUserMenuSelectByUserid", new { userid = userid }).ToList();
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

        //select all 


        [HttpGet]
        [Route("api/kesUserMenuSelectAll")]
        public IHttpActionResult GetAll()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<KesUserMenuSelect_dt>
                    ("sp_KesUserMenuSelect").ToList();
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
