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
    public class CSIdetailsController : ApiController
    {
       [HttpPost]
       [Route("api/CsiAll")]
       public IHttpActionResult Post(CSIAll_dt model)
        {
            try
            {

            
            CSIdetailsInsert_dt model1 = new CSIdetailsInsert_dt();
            InsertCSI(model, model1);
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
        [Route("api/CsiAll/Update")]
        public IHttpActionResult Update(CSIAll_dt model)
        {
            try
            {

            
            CSIdetailsDelete_dt model_new = new CSIdetailsDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsDelete", model_new);
            CSIdetailsInsert_dt model1 = new CSIdetailsInsert_dt();
            InsertCSI(model, model1);
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

        private static void InsertCSI(CSIAll_dt model, CSIdetailsInsert_dt model1)
        {

            model1.mrdno = model.mrdno;
            model1.ddate = model.ddate;
            model1.hospid = model.hospid;

            model1.title = "hbsag_react_tick";
            model1.result = "";
            model1.tick_mark = model.hbsag_react_tick;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);


            model1.title = "hcv_react_tick";
            model1.result = "";
            model1.tick_mark = model.hcv_react_tick;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);


            model1.title = "hiv_tick";
            model1.result = "";
            model1.tick_mark = model.hiv_tick;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);


            model1.title = "bs_fbs_tick";
            model1.result = "";
            model1.tick_mark = model.bs_fbs_tick;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);


            model1.title = "bs_pp_tick";
            model1.result = "";
            model1.tick_mark = model.bs_pp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);

            model1.title = "bs_rbs_tick";
            model1.result = "";
            model1.tick_mark = model.bs_rbs_tick;
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);


            if ((model.k1od is null ? "" : model.k1od).Length > 0)
            {
                model1.title = "k1od";
                model1.result = model.k1od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.k1os is null ? "" : model.k1os).Length > 0)
            {
                model1.title = "k1os";
                model1.result = model.k1os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }
            if ((model.k2od is null ? "" : model.k2od).Length > 0)
            {
                model1.title = "k2od";
                model1.result = model.k2od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.k2os is null ? "" : model.k2os).Length > 0)
            {
                model1.title = "k2os";
                model1.result = model.k2os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.axial_od is null ? "" : model.axial_od).Length > 0)
            {
                model1.title = "axial_od";
                model1.result = model.axial_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.axial_os is null ? "" : model.axial_os).Length > 0)
            {
                model1.title = "axial_os";
                model1.result = model.axial_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.iol_od is null ? "" : model.iol_od).Length > 0)
            {
                model1.title = "iol_od";
                model1.result = model.iol_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.iol_os is null ? "" : model.iol_os).Length > 0)
            {
                model1.title = "iol_os";
                model1.result = model.iol_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.blood_report is null ? "" : model.blood_report).Length > 0)
            {
                model1.title = "blood_report";
                model1.result = model.blood_report;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.remarks is null ? "" : model.remarks).Length > 0)
            {
                model1.title = "remarks";
                model1.result = model.remarks;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.bs_rbs is null ? "" : model.bs_rbs).Length > 0)
            {
                model1.title = "bs_rbs";
                model1.result = model.bs_rbs;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.bs_fbs is null ? "" : model.bs_fbs).Length > 0)
            {
                model1.title = "bs_fbs";
                model1.result = model.bs_fbs;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.bs_pp is null ? "" : model.bs_pp).Length > 0)
            {
                model1.title = "bs_pp";
                model1.result = model.bs_pp;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.a_constant_od is null ? "" : model.a_constant_od).Length > 0)
            {
                model1.title = "a_constant_od";
                model1.result = model.a_constant_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }

            if ((model.a_constant_os is null ? "" : model.a_constant_os).Length > 0)
            {
                model1.title = "a_constant_os";
                model1.result = model.a_constant_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_csi_detailsInsert", model1);
            }
        }

        [HttpGet]
        [Route("api/CsiAll")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CSIDetailsSelect_dt>
                ("sp_csi_detailsSelect", new { mrdno = mrdno }).ToList();
            CSIAll_dt model_new = new CSIAll_dt();
            foreach(var x in list)
            {
                model_new.ddate = x.ddate;
                model_new.mrdno = x.mrdno;


                if (x.title == "k1od")
                {
                    model_new.k1od = x.result;
                }

                if (x.title == "k1os")
                {
                    model_new.k1os = x.result;
                }

                if (x.title == "k2od")
                {
                    model_new.k2od = x.result;
                }

                if (x.title == "k2os")
                {
                    model_new.k2os = x.result;
                }

                if (x.title == "axial_od")
                {
                    model_new.axial_od = x.result;
                }

                if (x.title == "axial_os")
                {
                    model_new.axial_os = x.result;
                }

                if (x.title == "iol_od")
                {
                    model_new.iol_od = x.result;
                }

                if (x.title == "iol_os")
                {
                    model_new.iol_os = x.result;
                }

                if (x.title == "blood_report")
                {
                    model_new.blood_report = x.result;
                }

                if (x.title == "hbsag_react_tick")
                {
                    model_new.hbsag_react_tick = x.tick_mark;
                }

                if (x.title == "hcv_react_tick")
                {
                    model_new.hcv_react_tick = x.tick_mark;
                }

                if (x.title == "hiv_tick")
                {
                    model_new.hiv_tick = x.tick_mark;
                }

                if (x.title == "bs_fbs_tick")
                {
                    model_new.bs_fbs_tick = x.tick_mark;
                }

                if (x.title == "bs_pp_tick")
                {
                    model_new.bs_pp_tick = x.tick_mark;
                }

                if (x.title == "remarks")
                {
                    model_new.remarks = x.result;
                }

                if (x.title == "bs_rbs_tick")
                {
                    model_new.bs_rbs_tick = x.tick_mark;
                }

                if (x.title == "bs_rbs")
                {
                    model_new.bs_rbs = x.result;
                }

                if (x.title == "bs_fbs")
                {
                    model_new.bs_fbs = x.result;
                }

                if (x.title == "bs_pp")
                {
                    model_new.bs_pp = x.result;
                }

                if (x.title == "a_constant_od")
                {
                    model_new.a_constant_od = x.result;
                }

                if (x.title == "a_constant_os")
                {
                    model_new.a_constant_os = x.result;
                }
            }
            return Ok(model_new);

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
        [Route("api/CsiDetails/Delete")]
        public IHttpActionResult Delete(CSIdetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_csi_detailsDelete", model);
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
