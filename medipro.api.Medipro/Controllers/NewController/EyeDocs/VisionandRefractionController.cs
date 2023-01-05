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
    public class VisionandRefractionController : ApiController
    {
        [HttpPost]
        [Route("api/VisionandRefractionAll")]
        public IHttpActionResult Post(VisionandRefractionInsertAll_dt model) // paramer 33 
        {
            try
            {

            
            VisionandRefractionDetailsInsert_dt model1 = new VisionandRefractionDetailsInsert_dt();
            InsertVision(model, model1);
            // DapperHelper.ExecuteStoredProcedure("sp_VisionandRefractionInsert", model);
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
        [Route("api/VisionandRefractionAll/Update")]
        public IHttpActionResult UpdateAll(VisionandRefractionInsertAll_dt model)
        {
            try
            {

            
            VisionandRefractionDetailsDelete_dt model_new = new VisionandRefractionDetailsDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsDelete ", model_new);
            VisionandRefractionDetailsInsert_dt model1 = new VisionandRefractionDetailsInsert_dt();
            InsertVision(model, model1);
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

        private static void InsertVision(VisionandRefractionInsertAll_dt model, VisionandRefractionDetailsInsert_dt model1)
        {
            model1.hospid = model.hospid;
            model1.ddate = model.ddate;
            model1.mrdno = model.mrdno;
            model1.title = "distance_glasses_tick";
            model1.result = "";
            model1.tick_mark = model.distance_glasses_tick;
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);

            model1.title = "near_glasses_tick";
            model1.result = "";
            model1.tick_mark = model.near_glasses_tick;
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);

            model1.title = "glasses_regularity_tick";
            model1.result = "";
            model1.tick_mark = model.glasses_regularity_tick;
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);



            // model.pva_distance_od = string.Empty;
            //var x = model.pva_distance_od is null ? "" : model.pva_distance_od;
            if ((model.pva_distance_od is null ? "" : model.pva_distance_od).Length > 0)
            {
                model1.title = "pva_distance_od";
                model1.result = model.pva_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }


            if ((model.pv_distance_od is null ? "" : model.pv_distance_od).Length > 0)
            {
                model1.title = "pv_distance_od";
                model1.result = model.pv_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pva_distance_os is null ? "" : model.pva_distance_os).Length > 0)
            {
                model1.title = "pva_distance_os";
                model1.result = model.pva_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }


            if ((model.pv_distance_os is null ? "" : model.pv_distance_os).Length > 0)
            {
                model1.title = "pv_distance_os";
                model1.result = model.pv_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pva_near_od is null ? "" : model.pva_near_od).Length > 0)
            {
                model1.title = "pva_near_od";
                model1.result = model.pva_near_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }


            if ((model.pv_near_od is null ? "" : model.pva_near_od).Length > 0)
            {
                model1.title = "pv_near_od";
                model1.result = model.pv_near_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pva_near_os is null ? "" : model.pva_near_os).Length > 0)
            {
                model1.title = "pva_near_os";
                model1.result = model.pva_near_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }


            if ((model.pv_near_os is null ? "" : model.pv_near_os).Length > 0)
            {
                model1.title = "pv_near_os";
                model1.result = model.pv_near_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_distance_od is null ? "" : model.spherical_distance_od).Length > 0)
            {
                model1.title = "spherical_distance_od";
                model1.result = model.spherical_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_distance_od_value is null ? "" : model.spherical_distance_od_value).Length > 0)
            {
                model1.title = "spherical_distance_od_value";
                model1.result = model.spherical_distance_od_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.cylindrical_distance_od is null ? "" : model.cylindrical_distance_od).Length > 0)
            {
                model1.title = "cylindrical_distance_od";
                model1.result = model.cylindrical_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.cylindrical_distance_od_value is null ? "" : model.cylindrical_distance_od_value).Length > 0)
            {
                model1.title = "cylindrical_distance_od_value";
                model1.result = model.cylindrical_distance_od_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.axis_distance_od is null ? "" : model.axis_distance_od).Length > 0)
            {
                model1.title = "axis_distance_od";
                model1.result = model.axis_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.axis_distance_os is null ? "" : model.axis_distance_os).Length > 0)
            {
                model1.title = "axis_distance_os";
                model1.result = model.axis_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_distance_os is null ? "" : model.spherical_distance_os).Length > 0)
            {
                model1.title = "spherical_distance_os";
                model1.result = model.spherical_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_distance_os_value is null ? "" : model.spherical_distance_os_value).Length > 0)
            {
                model1.title = "spherical_distance_os_value";
                model1.result = model.spherical_distance_os_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.cylindrical_distance_os is null ? "" : model.cylindrical_distance_os).Length > 0)
            {
                model1.title = "cylindrical_distance_os";
                model1.result = model.cylindrical_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.cylindrical_distance_os_value is null ? "" : model.cylindrical_distance_os_value).Length > 0)
            {
                model1.title = "cylindrical_distance_os_value";
                model1.result = model.cylindrical_distance_os_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }


            if ((model.spherical_near_od is null ? "" : model.spherical_near_od).Length > 0)
            {
                model1.title = "spherical_near_od";
                model1.result = model.spherical_near_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_near_od_value is null ? "" : model.spherical_near_od_value).Length > 0)
            {
                model1.title = "spherical_near_od_value";
                model1.result = model.spherical_near_od_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_near_os is null ? "" : model.spherical_near_os).Length > 0)
            {
                model1.title = "spherical_near_os";
                model1.result = model.spherical_near_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.spherical_near_os_value is null ? "" : model.spherical_near_os_value).Length > 0)
            {
                model1.title = "spherical_near_os_value";
                model1.result = model.spherical_near_os_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.vanc_distance_od is null ? "" : model.vanc_distance_od).Length > 0)
            {
                model1.title = "vanc_distance_od";
                model1.result = model.vanc_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.vanc_distance_os is null ? "" : model.vanc_distance_os).Length > 0)
            {
                model1.title = "vanc_distance_os";
                model1.result = model.vanc_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.vanc_near_od is null ? "" : model.vanc_near_od).Length > 0)
            {
                model1.title = "vanc_near_od";
                model1.result = model.vanc_near_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.vanc_near_os is null ? "" : model.vanc_near_os).Length > 0)
            {
                model1.title = "vanc_near_os";
                model1.result = model.vanc_near_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_distance_od is null ? "" : model.pg_spherical_distance_od).Length > 0)
            {
                model1.title = "pg_spherical_distance_od";
                model1.result = model.pg_spherical_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_distance_od_value is null ? "" : model.pg_spherical_distance_od_value).Length > 0)
            {
                model1.title = "pg_spherical_distance_od_value";
                model1.result = model.pg_spherical_distance_od_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_cylindrical_distance_od is null ? "" : model.pg_cylindrical_distance_od).Length > 0)
            {
                model1.title = "pg_cylindrical_distance_od";
                model1.result = model.pg_cylindrical_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_cylindrical_distance_od_value is null ? "" : model.pg_cylindrical_distance_od_value).Length > 0)
            {
                model1.title = "pg_cylindrical_distance_od_value";
                model1.result = model.pg_cylindrical_distance_od_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_axis_distance_od is null ? "" : model.pg_axis_distance_od).Length > 0)
            {
                model1.title = "pg_axis_distance_od";
                model1.result = model.pg_axis_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_axis_distance_os is null ? "" : model.pg_axis_distance_os).Length > 0)
            {
                model1.title = "pg_axis_distance_os";
                model1.result = model.pg_axis_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_distance_os is null ? "" : model.pg_spherical_distance_os).Length > 0)
            {
                model1.title = "pg_spherical_distance_os";
                model1.result = model.pg_spherical_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_distance_os_value is null ? "" : model.pg_spherical_distance_os_value).Length > 0)
            {
                model1.title = "pg_spherical_distance_os_value";
                model1.result = model.pg_spherical_distance_os_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_cylindrical_distance_os is null ? "" : model.pg_cylindrical_distance_os).Length > 0)
            {
                model1.title = "pg_cylindrical_distance_os";
                model1.result = model.pg_cylindrical_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_cylindrical_distance_os_value is null ? "" : model.pg_cylindrical_distance_os_value).Length > 0)
            {
                model1.title = "pg_cylindrical_distance_os_value";
                model1.result = model.pg_cylindrical_distance_os_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_near_od is null ? "" : model.pg_spherical_near_od).Length > 0)
            {
                model1.title = "pg_spherical_near_od";
                model1.result = model.pg_spherical_near_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_near_od_value is null ? "" : model.pg_spherical_near_od_value).Length > 0)
            {
                model1.title = "pg_spherical_near_od_value";
                model1.result = model.pg_spherical_near_od_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_near_os is null ? "" : model.pg_spherical_near_os).Length > 0)
            {
                model1.title = "pg_spherical_near_os";
                model1.result = model.pg_spherical_near_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.pg_spherical_near_os_value is null ? "" : model.pg_spherical_near_os_value).Length > 0)
            {
                model1.title = "pg_spherical_near_os_value";
                model1.result = model.pg_spherical_near_os_value;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.visacu_preglass_near_od is null ? "" : model.visacu_preglass_near_od).Length > 0)
            {
                model1.title = "visacu_preglass_near_od";
                model1.result = model.visacu_preglass_near_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.visacu_preglass_distance_od is null ? "" : model.visacu_preglass_distance_od).Length > 0)
            {
                model1.title = "visacu_preglass_distance_od";
                model1.result = model.visacu_preglass_distance_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.visacu_preglass_near_os is null ? "" : model.visacu_preglass_near_os).Length > 0)
            {
                model1.title = "visacu_preglass_near_os";
                model1.result = model.visacu_preglass_near_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

            if ((model.visacu_preglass_distance_os is null ? "" : model.visacu_preglass_distance_os).Length > 0)
            {
                model1.title = "visacu_preglass_distance_os";
                model1.result = model.visacu_preglass_distance_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_VisionandRefraction_detailsInsert", model1);
            }

        }

        [HttpGet]
        [Route("api/VisionandRefractionAll")]
        public IHttpActionResult GetAll(string mrdno)
        {
            try
            {

            

            var list = DapperHelper.QueryStoredProcedure<VisionandRefractionDetailsSelect_dt>
                ("sp_VisionandRefraction_detailsSelect", new { mrdno = mrdno }).ToList();

            VisionandRefractionInsertAll_dt model_new = new VisionandRefractionInsertAll_dt();



            foreach (var x in list)
            {
                model_new.mrdno = x.mrdno;
                model_new.ddate = x.ddate;

                if (x.title == "distance_glasses_tick") { model_new.distance_glasses_tick = x.tick_mark; }
                if (x.title == "near_glasses_tick") { model_new.near_glasses_tick = x.tick_mark; }
                if (x.title == "glasses_regularity_tick") { model_new.glasses_regularity_tick = x.tick_mark; }
                if (x.title == "pva_distance_od") { model_new.pva_distance_od = x.result; }
                if (x.title == "pv_distance_od") { model_new.pv_distance_od = x.result; }
                if (x.title == "pva_distance_os") { model_new.pva_distance_os = x.result; }
                if (x.title == "pv_distance_os") { model_new.pv_distance_os = x.result; }
                if (x.title == "pva_near_od") { model_new.pva_near_od = x.result; }
                if (x.title == "pv_near_od") { model_new.pv_near_od = x.result; }
                if (x.title == "pva_near_os") { model_new.pva_near_os = x.result; }
                if (x.title == "pv_near_os") { model_new.pv_near_os = x.result; }
                if (x.title == "spherical_distance_od") { model_new.spherical_distance_od = x.result; }
                if (x.title == "spherical_distance_od_value") { model_new.spherical_distance_od_value = x.result; }
                if (x.title == "cylindrical_distance_od") { model_new.cylindrical_distance_od = x.result; }
                if (x.title == "cylindrical_distance_od_value") { model_new.cylindrical_distance_od_value = x.result; }
                if (x.title == "axis_distance_od") { model_new.axis_distance_od = x.result; }
                if (x.title == "axis_distance_os") { model_new.axis_distance_os = x.result; }
                if (x.title == "spherical_distance_os") { model_new.spherical_distance_os = x.result; }
                if (x.title == "spherical_distance_os_value") { model_new.spherical_distance_os_value = x.result; }
                if (x.title == "cylindrical_distance_os") { model_new.cylindrical_distance_os = x.result; }
                if (x.title == "cylindrical_distance_os_value") { model_new.cylindrical_distance_os_value = x.result; }
                if (x.title == "spherical_near_od") { model_new.spherical_near_od = x.result; }
                if (x.title == "spherical_near_od_value") { model_new.spherical_near_od_value = x.result; }
                if (x.title == "spherical_near_os") { model_new.spherical_near_os = x.result; }
                if (x.title == "spherical_near_os_value") { model_new.spherical_near_os_value = x.result; }
                if (x.title == "vanc_distance_od") { model_new.vanc_distance_od = x.result; }
                if (x.title == "vanc_distance_os") { model_new.vanc_distance_os = x.result; }
                if (x.title == "vanc_near_od") { model_new.vanc_near_od = x.result; }
                if (x.title == "vanc_near_os") { model_new.vanc_near_os = x.result; }
                if (x.title == "pg_spherical_distance_od") { model_new.pg_spherical_distance_od = x.result; }
                if (x.title == "pg_spherical_distance_od_value") { model_new.pg_spherical_distance_od_value = x.result; }
                if (x.title == "pg_cylindrical_distance_od") { model_new.pg_cylindrical_distance_od = x.result; }
                if (x.title == "pg_cylindrical_distance_od_value") { model_new.pg_cylindrical_distance_od_value = x.result; }
                if (x.title == "pg_axis_distance_od") { model_new.pg_axis_distance_od = x.result; }
                if (x.title == "pg_axis_distance_os") { model_new.pg_axis_distance_os = x.result; }
                if (x.title == "pg_spherical_distance_os") { model_new.pg_spherical_distance_os = x.result; }
                if (x.title == "pg_spherical_distance_os_value") { model_new.pg_spherical_distance_os_value = x.result; }
                if (x.title == "pg_cylindrical_distance_os") { model_new.pg_cylindrical_distance_os = x.result; }
                if (x.title == "pg_cylindrical_distance_os_value") { model_new.pg_cylindrical_distance_os_value = x.result; }
                if (x.title == "pg_spherical_near_od") { model_new.pg_spherical_near_od = x.result; }
                if (x.title == "pg_spherical_near_od_value") { model_new.pg_spherical_near_od_value = x.result; }
                if (x.title == "pg_spherical_near_os") { model_new.pg_spherical_near_os = x.result; }
                if (x.title == "pg_spherical_near_os_value") { model_new.pg_spherical_near_os_value = x.result; }
                if (x.title == "visacu_preglass_near_od") { model_new.visacu_preglass_near_od = x.result; }
                if (x.title == "visacu_preglass_distance_od") { model_new.visacu_preglass_distance_od = x.result; }
                if (x.title == "visacu_preglass_near_os") { model_new.visacu_preglass_near_os = x.result; }
                if (x.title == "visacu_preglass_distance_os") { model_new.visacu_preglass_distance_os = x.result; }
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
        [Route("api/VisionandRefraction")]
        public IHttpActionResult Post(VisionandRefractionInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefractionInsert", model);
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
        [Route("api/VisionandRefraction/Update")]
        public IHttpActionResult Update(VisionandRefractionUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefractionUpdate", model);
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
        [Route("api/VisionandRefraction")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<VisionandRefractionSelect_dt>
                ("sp_VisionandRefractionSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/VisionandRefraction/Delete")]
        public IHttpActionResult Delete(VisionandRefractionDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_VisionandRefractionDelete ", model);
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

