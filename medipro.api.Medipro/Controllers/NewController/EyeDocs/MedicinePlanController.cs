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
    public class MedicinePlanController : ApiController
    {
        [HttpPost]
        [Route("api/TempMedicinePlan/Insert")]
        public IHttpActionResult TempInsert(TempMedicinePlanInsert_dt model)
        {
            try
            {

            

            DapperHelper.ExecuteStoredProcedure("sp_tempKesMedicinePlanInsert", model);
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
        [Route("api/TempMedicinePlan/Select")]
        public IHttpActionResult SelectbyUid(int userid, string plantype, string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<TempMedicinePlanSelect_dt>
                ("sp_tempKesMedicinePlanSelectByUserId", new { userid = userid, plantype=plantype, mrdno=mrdno }).ToList();
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
        [Route("api/TempMedicinePlan/Delete")]
        public IHttpActionResult TempDelete(TempMedicinePlanDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_tempKesMedicinePlanDeleteBySn", model);
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
        [Route("api/MedicinePlan/Insert")]
        public IHttpActionResult Insert(MedicinePlanInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_KesMedicinePlanInsert", model);
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
        [Route("api/MedicinePlan/Select")]
        public IHttpActionResult Select(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MedicinePlanSelect_dt>
                ("sp_KesMedicinePlanSelectByMrdno", new { mrdno = mrdno }).ToList();
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
        [Route("api/MedicinePlan/MainToTemp/Post")]
        public IHttpActionResult MainToTemp(TempMedPlanInsertFromMain_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_KesMedicinePlanMainToTempInsert", model);
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
