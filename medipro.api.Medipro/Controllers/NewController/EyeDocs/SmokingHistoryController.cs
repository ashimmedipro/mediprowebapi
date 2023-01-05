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
    public class SmokingHistoryController : ApiController
    {
        [HttpPost]
        [Route("api/SmokingHistoryAll")]
        public IHttpActionResult Post(SmokingHistoryAll_dt model)
        {
            try
            {

            
            SmokingHistoryDetailsInsert_dt model1 = new SmokingHistoryDetailsInsert_dt();
            InsertSmoking(model, model1);

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
        [Route("api/SmokingHistoryAll/Update")]
        public IHttpActionResult UpdateAll(SmokingHistoryAll_dt model)
        {
            try
            {

            
            SmokingHistoryDetailsDelete_dt model_new = new SmokingHistoryDetailsDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsDelete", model_new);
            SmokingHistoryDetailsInsert_dt model1 = new SmokingHistoryDetailsInsert_dt();
            InsertSmoking(model, model1);
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

        private static void InsertSmoking(SmokingHistoryAll_dt model, SmokingHistoryDetailsInsert_dt model1)
        {
            model1.mrdno = model.mrdno;
            model1.ddate = model.ddate;
            model1.hospid = model.hospid;

            if ((model.smkcig_tick == 0))
            {
                model1.title = "smkcig_tick";
                model1.result = "Never Smoker";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            else if ((model.smkcig_tick == 1))
            {
                model1.title = "smkcig_tick";
                model1.result = "present smoker";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }
            else
            {
                model1.title = "smkcig_tick";
                model1.result = "Past Smoker";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_tick == 0))
            {
                model1.title = "alccon_tick";
                model1.result = "Never Drinker";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            else if ((model.alccon_tick == 1))
            {
                model1.title = "alccon_tick";
                model1.result = "present Drinker";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }
            else
            {
                model1.title = "alccon_tick";
                model1.result = "Past Drinker";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }



            model1.title = "househld_tick";
            model1.result = "";
            model1.tick_mark = model.househld_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pre_od_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pre_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pre_sd_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pre_sd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pre_cd_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pre_cd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pre_pan_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pre_pan_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pas_od_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pas_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pas_sd_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pas_sd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pas_cd_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pas_cd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "alccon_pas_pan_tick";
            model1.result = "";
            model1.tick_mark = model.alccon_pas_pan_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "oth_pre_bd_tick";
            model1.result = "";
            model1.tick_mark = model.oth_pre_bd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "oth_pre_tm_tick";
            model1.result = "";
            model1.tick_mark = model.oth_pre_tm_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "oth_pre_hka_tick";
            model1.result = "";
            model1.tick_mark = model.oth_pre_hka_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "oth_pas_bd_tick";
            model1.result = "";
            model1.tick_mark = model.oth_pas_bd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "oth_pas_tm_tick";
            model1.result = "";
            model1.tick_mark = model.oth_pas_tm_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            model1.title = "oth_pas_hka_tick";
            model1.result = "";
            model1.tick_mark = model.oth_pas_hka_tick;
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);

            if ((model.smkcig_ps_age is null ? "" : model.smkcig_ps_age).Length > 0)
            {
                model1.title = "smkcig_ps_age";
                model1.result = model.smkcig_ps_age;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_ps_year is null ? "" : model.smkcig_ps_year).Length > 0)
            {
                model1.title = "smkcig_ps_year";
                model1.result = model.smkcig_ps_year;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_ps_no is null ? "" : model.smkcig_ps_no).Length > 0)
            {
                model1.title = "smkcig_ps_no";
                model1.result = model.smkcig_ps_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_ps_yrs is null ? "" : model.smkcig_ps_yrs).Length > 0)
            {
                model1.title = "smkcig_ps_yrs";
                model1.result = model.smkcig_ps_yrs;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_ps_ddate is null ? "" : model.smkcig_ps_ddate).Length > 0)
            {
                model1.title = "smkcig_ps_ddate";
                model1.result = model.smkcig_ps_ddate;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_cs_age is null ? "" : model.smkcig_cs_age).Length > 0)
            {
                model1.title = "smkcig_cs_age";
                model1.result = model.smkcig_cs_age;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_cs_no is null ? "" : model.smkcig_cs_no).Length > 0)
            {
                model1.title = "smkcig_cs_no";
                model1.result = model.smkcig_cs_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_cs_yrs is null ? "" : model.smkcig_cs_yrs).Length > 0)
            {
                model1.title = "smkcig_cs_yrs";
                model1.result = model.smkcig_cs_yrs;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.smkcig_cs_ddate is null ? "" : model.smkcig_cs_ddate).Length > 0)
            {
                model1.title = "smkcig_cs_ddate";
                model1.result = model.smkcig_cs_ddate;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pre is null ? "" : model.alccon_pre).Length > 0)
            {
                model1.title = "alccon_pre";
                model1.result = model.alccon_pre;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pre_usn is null ? "" : model.alccon_pre_usn).Length > 0)
            {
                model1.title = "alccon_pre_usn";
                model1.result = model.alccon_pre_usn;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pre_noyr is null ? "" : model.alccon_pre_noyr).Length > 0)
            {
                model1.title = "alccon_pre_noyr";
                model1.result = model.alccon_pre_noyr;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pre_qt is null ? "" : model.alccon_pre_qt).Length > 0)
            {
                model1.title = "alccon_pre_qt";
                model1.result = model.alccon_pre_qt;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pre_pan is null ? "" : model.alccon_pre_pan).Length > 0)
            {
                model1.title = "alccon_pre_pan";
                model1.result = model.alccon_pre_pan;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }
            if ((model.alccon_pas is null ? "" : model.alccon_pas).Length > 0)
            {
                model1.title = "alccon_pas";
                model1.result = model.alccon_pas;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pas_usn is null ? "" : model.alccon_pas_usn).Length > 0)
            {
                model1.title = "alccon_pas_usn";
                model1.result = model.alccon_pas_usn;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pas_stop is null ? "" : model.alccon_pas_stop).Length > 0)
            {
                model1.title = "alccon_pas_stop";
                model1.result = model.alccon_pas_stop;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pas_noyr is null ? "" : model.alccon_pas_noyr).Length > 0)
            {
                model1.title = "alccon_pas_noyr";
                model1.result = model.alccon_pas_noyr;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pas_qt is null ? "" : model.alccon_pas_qt).Length > 0)
            {
                model1.title = "alccon_pas_qt";
                model1.result = model.alccon_pas_qt;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.alccon_pas_pan is null ? "" : model.alccon_pas_pan).Length > 0)
            {
                model1.title = "alccon_pas_pan";
                model1.result = model.alccon_pas_pan;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.oth_pre_bd is null ? "" : model.oth_pre_bd).Length > 0)
            {
                model1.title = "oth_pre_bd";
                model1.result = model.oth_pre_bd;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.oth_pre_tm is null ? "" : model.oth_pre_tm).Length > 0)
            {
                model1.title = "oth_pre_tm";
                model1.result = model.oth_pre_tm;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.oth_pre_hka is null ? "" : model.oth_pre_hka).Length > 0)
            {
                model1.title = "oth_pre_hka";
                model1.result = model.oth_pre_hka;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.oth_pas_bd is null ? "" : model.oth_pas_bd).Length > 0)
            {
                model1.title = "oth_pas_bd";
                model1.result = model.oth_pas_bd;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.oth_pas_tm is null ? "" : model.oth_pas_tm).Length > 0)
            {
                model1.title = "oth_pas_tm";
                model1.result = model.oth_pas_tm;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }

            if ((model.oth_pas_hka is null ? "" : model.oth_pas_hka).Length > 0)
            {
                model1.title = "oth_pas_hka";
                model1.result = model.oth_pas_hka;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model1);
            }
        }

        [HttpPost]
        [Route("api/SmokingHistory")]
        public IHttpActionResult Post(SmokingHistoryInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_smoking_historyInsert", model);
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
        [Route("api/SmokingHistory/Update")]
        public IHttpActionResult Update(SmokingHistoryUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_smoking_historyUpdate", model);
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
        [Route("api/SmokingHistory")]
        public IHttpActionResult Get(int mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SmokingHistorySelect_dt>
                ("sp_smoking_historySelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/SmokingHistory/Delete")]
        public IHttpActionResult Delete(SmokingHistoryDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_smoking_historyDelete", model);
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
        [Route("api/SmokingHistoryAll")]
        public IHttpActionResult GetAll(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SmokingHistoryDetailsSelect_dt>
                ("sp_smoking_history_detailsSelect", new { mrdno = mrdno }).ToList();
            SmokingHistorySelectAll_dt model_new = new SmokingHistorySelectAll_dt();

            foreach(var x in list)
            {
                model_new.mrdno = x.mrdno;
                model_new.ddate = x.ddate;
                if (x.title == "smkcig_tick")
                {
                    model_new.smkcig_tick = x.result;
                }

                if (x.title == "smkcig_ps_age")
                {
                    model_new.smkcig_ps_age = x.result;
                }

                if (x.title == "smkcig_ps_year")
                {
                    model_new.smkcig_ps_year = x.result;
                }

                if (x.title == "smkcig_ps_no")
                {
                    model_new.smkcig_ps_no = x.result;
                }

                if (x.title == "smkcig_ps_yrs")
                {
                    model_new.smkcig_ps_yrs = x.result;
                }

                if (x.title == "smkcig_ps_ddate")
                {
                    model_new.smkcig_ps_ddate = x.result;
                }

                if (x.title == "smkcig_cs_age")
                {
                    model_new.smkcig_cs_age = x.result;
                }

                if (x.title == "smkcig_cs_no")
                {
                    model_new.smkcig_cs_no = x.result;
                }

                if (x.title == "smkcig_cs_yrs")
                {
                    model_new.smkcig_cs_yrs = x.result;
                }

                if (x.title == "smkcig_cs_ddate")
                {
                    model_new.smkcig_cs_ddate = x.result;
                }

                if (x.title == "househld_tick")
                {
                    model_new.househld_tick = x.tick_mark;
                }

                if (x.title == "alccon_tick")
                {
                    model_new.alccon_tick = x.result;
                }

                if (x.title == "alccon_pre")
                {
                    model_new.alccon_pre = x.result;
                }

                if (x.title == "alccon_pre_od_tick")
                {
                    model_new.alccon_pre_od_tick = x.tick_mark;
                }

                if (x.title == "alccon_pre_sd_tick")
                {
                    model_new.alccon_pre_sd_tick = x.tick_mark;
                }

                if (x.title == "alccon_pre_cd_tick")
                {
                    model_new.alccon_pre_cd_tick = x.tick_mark;
                }

                if (x.title == "alccon_pre_usn")
                {
                    model_new.alccon_pre_usn = x.result;
                }

                if (x.title == "alccon_pre_noyr")
                {
                    model_new.alccon_pre_noyr = x.result;
                }

                if (x.title == "alccon_pre_qt")
                {
                    model_new.alccon_pre_qt = x.result;
                }

                if (x.title == "alccon_pre_pan_tick")
                {
                    model_new.alccon_pre_pan_tick = x.tick_mark;
                }

                if (x.title == "alccon_pre_pan")
                {
                    model_new.alccon_pre_pan = x.result;
                }

                if (x.title == "alccon_pas")
                {
                    model_new.alccon_pas = x.result;
                }

                if (x.title == "alccon_pas_od_tick")
                {
                    model_new.alccon_pas_od_tick = x.tick_mark;
                }

                if (x.title == "alccon_pas_sd_tick")
                {
                    model_new.alccon_pas_sd_tick = x.tick_mark;
                }

                if (x.title == "alccon_pas_cd_tick")
                {
                    model_new.alccon_pas_cd_tick = x.tick_mark;
                }

                if (x.title == "alccon_pas_usn")
                {
                    model_new.alccon_pas_usn = x.result;
                }

                if (x.title == "alccon_pas_stop")
                {
                    model_new.alccon_pas_stop = x.result;
                }

                if (x.title == "alccon_pas_noyr")
                {
                    model_new.alccon_pas_noyr = x.result;
                }

                if (x.title == "alccon_pas_qt")
                {
                    model_new.alccon_pas_qt = x.result;
                }

                if (x.title == "alccon_pas_pan_tick")
                {
                    model_new.alccon_pas_pan_tick = x.tick_mark;
                }

                if (x.title == "alccon_pas_pan")
                {
                    model_new.alccon_pas_pan = x.result;
                }

                if (x.title == "oth_pre_bd_tick")
                {
                    model_new.oth_pre_bd_tick = x.tick_mark;
                }

                if (x.title == "oth_pre_bd")
                {
                    model_new.oth_pre_bd = x.result;
                }

                if (x.title == "oth_pre_tm_tick")
                {
                    model_new.oth_pre_tm_tick = x.tick_mark;
                }

                if (x.title == "oth_pre_tm")
                {
                    model_new.oth_pre_tm = x.result;
                }

                if (x.title == "oth_pre_hka_tick")
                {
                    model_new.oth_pre_hka_tick = x.tick_mark;
                }

                if (x.title == "oth_pre_hka")
                {
                    model_new.oth_pre_hka = x.result;
                }

                if (x.title == "oth_pas_bd_tick")
                {
                    model_new.oth_pas_bd_tick = x.tick_mark;
                }

                if (x.title == "oth_pas_bd")
                {
                    model_new.oth_pas_bd = x.result;
                }

                if (x.title == "oth_pas_tm_tick")
                {
                    model_new.oth_pas_tm_tick = x.tick_mark;
                }

                if (x.title == "oth_pas_tm")
                {
                    model_new.oth_pas_tm = x.result;
                }

                if (x.title == "oth_pas_hka_tick")
                {
                    model_new.oth_pas_hka_tick = x.tick_mark;
                }

                if (x.title == "oth_pas_hka")
                {
                    model_new.oth_pas_hka = x.result;
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
    }
}
