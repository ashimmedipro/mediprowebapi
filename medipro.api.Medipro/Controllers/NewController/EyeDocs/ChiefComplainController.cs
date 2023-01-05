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
    public class ChiefComplainController : ApiController
    {
        [HttpPost]
        [Route("api/ChiefComplainAll")]
        public IHttpActionResult PostAll(ChiefComplainAll_dt model)
        {
            try
            {


                ChiefComplainDetailsInsert_dt model1 = new ChiefComplainDetailsInsert_dt();
                InsertChief(model, model1);

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
        [Route("api/ChiefComplainAll/Update")]
        public IHttpActionResult Update(ChiefComplainAll_dt model)
        {
            try
            {

            
            ChiefComplainDetailsDelete_dt model_new = new ChiefComplainDetailsDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsDelete", model_new);
            ChiefComplainDetailsInsert_dt model1 = new ChiefComplainDetailsInsert_dt();
            InsertChief(model, model1);
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


        private static void InsertChief(ChiefComplainAll_dt model, ChiefComplainDetailsInsert_dt model1)
        {


            
            model1.mrdno = model.mrdno;
            model1.ddate = model.ddate;
            model1.hospid = model.hospid;
            model1.title = "cheye_devi_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_devi_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_pain_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_pain_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_water_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_water_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_fbsen_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_fbsen_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_itch_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_itch_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_ptb_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_ptb_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_flo_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_flo_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_fla_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_fla_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_dip_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_dip_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_sco_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_sco_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_colha_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_colha_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_oth_od_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_oth_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_devi_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_devi_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_pain_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_pain_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_water_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_water_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_fbsen_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_fbsen_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_itch_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_itch_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_ptb_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_ptb_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_flo_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_flo_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_fla_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_fla_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_dip_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_dip_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_sco_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_sco_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_colha_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_colha_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "cheye_oth_os_tick";
            model1.result = "";
            model1.tick_mark = model.cheye_oth_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "eyeconsult_tick";
            model1.result = "";
            model1.tick_mark = model.eyeconsult_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "eyeconsult_yes_pharmacy_tick";
            model1.result = "";
            model1.tick_mark = model.eyeconsult_yes_pharmacy_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "eyeconsult_yes_health_i_tick";
            model1.result = "";
            model1.tick_mark = model.eyeconsult_yes_health_i_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "eyeconsult_eye_clinic_tick";
            model1.result = "";
            model1.tick_mark = model.eyeconsult_eye_clinic_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);

            model1.title = "eyeconsult_eye_hospital_tick";
            model1.result = "";
            model1.tick_mark = model.eyeconsult_eye_hospital_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);


            if ((model.cheye_devi_od is null ? "" : model.cheye_devi_od).Length > 0)
            {
                model1.title = "cheye_devi_od";
                model1.result = model.cheye_devi_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_red_od is null ? "" : model.cheye_red_od).Length > 0)
            {
                model1.title = "cheye_red_od";
                model1.result = model.cheye_red_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_water_od is null ? "" : model.cheye_water_od).Length > 0)
            {
                model1.title = "cheye_water_od";
                model1.result = model.cheye_water_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_fbsen_od is null ? "" : model.cheye_fbsen_od).Length > 0)
            {
                model1.title = "cheye_fbsen_od";
                model1.result = model.cheye_fbsen_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_ptb_od is null ? "" : model.cheye_ptb_od).Length > 0)
            {
                model1.title = "cheye_ptb_od";
                model1.result = model.cheye_ptb_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_flo_od is null ? "" : model.cheye_flo_od).Length > 0)
            {
                model1.title = "cheye_flo_od";
                model1.result = model.cheye_flo_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_fla_od is null ? "" : model.cheye_fla_od).Length > 0)
            {
                model1.title = "cheye_fla_od";
                model1.result = model.cheye_fla_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_dip_od is null ? "" : model.cheye_dip_od).Length > 0)
            {
                model1.title = "cheye_dip_od";
                model1.result = model.cheye_dip_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_sco_od is null ? "" : model.cheye_sco_od).Length > 0)
            {
                model1.title = "cheye_sco_od";
                model1.result = model.cheye_sco_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_colha_od is null ? "" : model.cheye_colha_od).Length > 0)
            {
                model1.title = "cheye_colha_od";
                model1.result = model.cheye_colha_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_oth_od is null ? "" : model.cheye_oth_od).Length > 0)
            {
                model1.title = "cheye_oth_od";
                model1.result = model.cheye_oth_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_devi_os is null ? "" : model.cheye_devi_os).Length > 0)
            {
                model1.title = "cheye_devi_os";
                model1.result = model.cheye_devi_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_red_os is null ? "" : model.cheye_red_os).Length > 0)
            {
                model1.title = "cheye_red_os";
                model1.result = model.cheye_red_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_water_os is null ? "" : model.cheye_water_os).Length > 0)
            {
                model1.title = "cheye_water_os";
                model1.result = model.cheye_water_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_fbsen_os is null ? "" : model.cheye_fbsen_os).Length > 0)
            {
                model1.title = "cheye_fbsen_os";
                model1.result = model.cheye_fbsen_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_ptb_os is null ? "" : model.cheye_ptb_os).Length > 0)
            {
                model1.title = "cheye_ptb_os";
                model1.result = model.cheye_ptb_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_flo_os is null ? "" : model.cheye_flo_os).Length > 0)
            {
                model1.title = "cheye_flo_os";
                model1.result = model.cheye_flo_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_fla_os is null ? "" : model.cheye_fla_os).Length > 0)
            {
                model1.title = "cheye_fla_os";
                model1.result = model.cheye_fla_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_dip_os is null ? "" : model.cheye_dip_os).Length > 0)
            {
                model1.title = "cheye_dip_os";
                model1.result = model.cheye_dip_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_sco_os is null ? "" : model.cheye_sco_os).Length > 0)
            {
                model1.title = "cheye_sco_os";
                model1.result = model.cheye_sco_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_colha_os is null ? "" : model.cheye_colha_os).Length > 0)
            {
                model1.title = "cheye_colha_os";
                model1.result = model.cheye_colha_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.cheye_oth_os is null ? "" : model.cheye_oth_os).Length > 0)
            {
                model1.title = "cheye_oth_os";
                model1.result = model.cheye_oth_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.eyeconsult_no_lt is null ? "" : model.eyeconsult_no_lt).Length > 0)
            {
                model1.title = "eyeconsult_no_lt";
                model1.result = model.eyeconsult_no_lt;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.eyeconsult_no_lm is null ? "" : model.eyeconsult_no_lm).Length > 0)
            {
                model1.title = "eyeconsult_no_lm";
                model1.result = model.eyeconsult_no_lm;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.eyeconsult_no_lc is null ? "" : model.eyeconsult_no_lc).Length > 0)
            {
                model1.title = "eyeconsult_no_lc";
                model1.result = model.eyeconsult_no_lc;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }

            if ((model.eyeconsult_no_o is null ? "" : model.eyeconsult_no_o).Length > 0)
            {
                model1.title = "eyeconsult_no_o";
                model1.result = model.eyeconsult_no_o;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Chief_Complain_detailsInsert", model1);
            }


        }

        [HttpPost]
        [Route("api/ChiefComplain")]
        public IHttpActionResult Post(ChiefComplainInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Chief_ComplainInsert", model);
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
        [Route("api/ChiefComplain/Update")]
        public IHttpActionResult Update(ChiefComplainUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Chief_ComplainUpdate", model);
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
        [Route("api/ChiefComplain")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ChiefComplainSelect_dt>
                ("sp_Chief_ComplainSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/ChiefComplain/Delete")]
        public IHttpActionResult Delete(ChiefComplainDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Chief_ComplainDelete ", model);
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
        [Route("api/ChiefComplainAll")]
        public IHttpActionResult GetAll(string mrdno)
        {
            try
            {
            
            
            var list = DapperHelper.QueryStoredProcedure<ChiefComplainDetailsSelect_dt>
                ("sp_Chief_Complain_detailsSelect", new { mrdno = mrdno }).ToList();
            ChiefComplainAll_dt model_new = new ChiefComplainAll_dt();
            foreach (var x in list)
            {
                model_new.mrdno = x.mrdno;
                if (x.title == "cheye_devi_od_tick") { model_new.cheye_devi_od_tick = x.tick_mark; }
                if (x.title == "cheye_devi_od") { model_new.cheye_devi_od = x.result; }
                if (x.title == "cheye_pain_od_tick") { model_new.cheye_pain_od_tick = x.tick_mark; }
                if (x.title == "cheye_red_od") { model_new.cheye_red_od = x.result; }
                if (x.title == "cheye_water_od_tick") { model_new.cheye_water_od_tick = x.tick_mark; }
                if (x.title == "cheye_water_od") { model_new.cheye_water_od = x.result; }
                if (x.title == "cheye_fbsen_od_tick") { model_new.cheye_fbsen_od_tick = x.tick_mark; }
                if (x.title == "cheye_fbsen_od") { model_new.cheye_fbsen_od = x.result; }
                if (x.title == "cheye_itch_od_tick") { model_new.cheye_itch_od_tick = x.tick_mark; }
                if (x.title == "cheye_itch_od") { model_new.cheye_itch_od = x.result; }
                if (x.title == "cheye_ptb_od_tick") { model_new.cheye_ptb_od_tick = x.tick_mark; }
                if (x.title == "cheye_ptb_od") { model_new.cheye_ptb_od = x.result; }
                if (x.title == "cheye_flo_od_tick") { model_new.cheye_flo_od_tick = x.tick_mark; }
                if (x.title == "cheye_flo_od") { model_new.cheye_flo_od = x.result; }
                if (x.title == "cheye_fla_od_tick") { model_new.cheye_fla_od_tick = x.tick_mark; }
                if (x.title == "cheye_fla_od") { model_new.cheye_fla_od = x.result; }
                if (x.title == "cheye_dip_od_tick") { model_new.cheye_dip_od_tick = x.tick_mark; }
                if (x.title == "cheye_dip_od") { model_new.cheye_dip_od = x.result; }
                if (x.title == "cheye_sco_od_tick") { model_new.cheye_sco_od_tick = x.tick_mark; }
                if (x.title == "cheye_sco_od") { model_new.cheye_sco_od = x.result; }
                if (x.title == "cheye_colha_od_tick") { model_new.cheye_colha_od_tick = x.tick_mark; }
                if (x.title == "cheye_colha_od") { model_new.cheye_colha_od = x.result; }
                if (x.title == "cheye_oth_od_tick") { model_new.cheye_oth_od_tick = x.tick_mark; }
                if (x.title == "cheye_oth_od") { model_new.cheye_oth_od = x.result; }
                if (x.title == "cheye_devi_os_tick") { model_new.cheye_devi_os_tick = x.tick_mark; }
                if (x.title == "cheye_devi_os") { model_new.cheye_devi_os = x.result; }
                if (x.title == "cheye_pain_os_tick") { model_new.cheye_pain_os_tick = x.tick_mark; }
                if (x.title == "cheye_red_os") { model_new.cheye_red_os = x.result; }
                if (x.title == "cheye_water_os_tick") { model_new.cheye_water_os_tick = x.tick_mark; }
                if (x.title == "cheye_water_os") { model_new.cheye_water_os = x.result; }
                if (x.title == "cheye_fbsen_os_tick") { model_new.cheye_fbsen_os_tick = x.tick_mark; }
                if (x.title == "cheye_fbsen_os") { model_new.cheye_fbsen_os = x.result; }
                if (x.title == "cheye_itch_os_tick") { model_new.cheye_itch_os_tick = x.tick_mark; }
                if (x.title == "cheye_itch_os") { model_new.cheye_itch_os = x.result; }
                if (x.title == "cheye_ptb_os_tick") { model_new.cheye_ptb_os_tick = x.tick_mark; }
                if (x.title == "cheye_ptb_os") { model_new.cheye_ptb_os = x.result; }
                if (x.title == "cheye_flo_os_tick") { model_new.cheye_flo_os_tick = x.tick_mark; }
                if (x.title == "cheye_flo_os") { model_new.cheye_flo_os = x.result; }
                if (x.title == "cheye_fla_os_tick") { model_new.cheye_fla_os_tick = x.tick_mark; }
                if (x.title == "cheye_fla_os") { model_new.cheye_fla_os = x.result; }
                if (x.title == "cheye_dip_os_tick") { model_new.cheye_dip_os_tick = x.tick_mark; }
                if (x.title == "cheye_dip_os") { model_new.cheye_dip_os = x.result; }
                if (x.title == "cheye_sco_os_tick") { model_new.cheye_sco_os_tick = x.tick_mark; }
                if (x.title == "cheye_sco_os") { model_new.cheye_sco_os = x.result; }
                if (x.title == "cheye_colha_os_tick") { model_new.cheye_colha_os_tick = x.tick_mark; }
                if (x.title == "cheye_colha_os") { model_new.cheye_colha_os = x.result; }
                if (x.title == "cheye_oth_os_tick") { model_new.cheye_oth_os_tick = x.tick_mark; }
                if (x.title == "cheye_oth_os") { model_new.cheye_oth_os = x.result; }
                if (x.title == "eyeconsult_tick") { model_new.eyeconsult_tick = x.tick_mark; }
                if (x.title == "eyeconsult_no_lt") { model_new.eyeconsult_no_lt = x.result; }
                if (x.title == "eyeconsult_no_lm") { model_new.eyeconsult_no_lm = x.result; }
                if (x.title == "eyeconsult_no_lc") { model_new.eyeconsult_no_lc = x.result; }
                if (x.title == "eyeconsult_no_o") { model_new.eyeconsult_no_o = x.result; }
                if (x.title == "eyeconsult_yes_pharmacy_tick") { model_new.eyeconsult_yes_pharmacy_tick = x.tick_mark; }
                if (x.title == "eyeconsult_yes_health_i_tick") { model_new.eyeconsult_yes_health_i_tick = x.tick_mark; }
                if (x.title == "eyeconsult_eye_clinic_tick") { model_new.eyeconsult_eye_clinic_tick = x.tick_mark; }
                if (x.title == "eyeconsult_eye_hospital_tick") { model_new.eyeconsult_eye_hospital_tick = x.tick_mark; }
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
    }
}
