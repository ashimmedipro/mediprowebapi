using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EmergencyDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EmergencyDocs
{
    public class EmergencyFormDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/EmergencyFormDetails")]
        public IHttpActionResult Post(EmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model);
           
            return Ok();
        }

        

        [HttpPost]
        [Route("api/EmergencyFormDetails/Update")]
        public IHttpActionResult Update(EmergencyFormDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/EmergencyFormDetails")]

        public IHttpActionResult Get(int emergency_id)
        {
            var list = DapperHelper.QueryStoredProcedure<EmergencyFormDetailsGetData_dt>
                ("sp_EmergencyFormDetailsGetdata", new { emergency_id = emergency_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/EmergencyFormDetails/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsDelete", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/EmergencyFormAll")]
        public IHttpActionResult Post(EmergencyFormAll_dt model)
        {

            EmergencyFormDetailsInsert_dt model1 = new EmergencyFormDetailsInsert_dt();
            model1.emergency_id = model.emergency_id;
            model1.date_time = model.discharge_ddate;

            model1.text_title = "hbtcdc_tick";
            model1.note = "";
            model1.tick_mark = model.hbtcdc_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "blodgroupingncross_tick";
            model1.note = "";
            model1.tick_mark = model.blodgroupingncross_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "matching_tick";
            model1.note = "";
            model1.tick_mark = model.matching_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "blodsugar_tick";
            model1.note = "";
            model1.tick_mark = model.blodsugar_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "ures_tick";
            model1.note = "";
            model1.tick_mark = model.ures_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "creatinine_tick";
            model1.note = "";
            model1.tick_mark = model.creatinine_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "lft_tick";
            model1.note = "";
            model1.tick_mark = model.lft_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "amylase_tick";
            model1.note = "";
            model1.tick_mark = model.amylase_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "cpkmb_tick";
            model1.note = "";
            model1.tick_mark = model.cpkmb_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "electrolysis_tick";
            model1.note = "";
            model1.tick_mark = model.electrolysis_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "urineketone_tick";
            model1.note = "";
            model1.tick_mark = model.urineketone_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "stooltest_tick";
            model1.note = "";
            model1.tick_mark = model.stooltest_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = " pregnancytest_tick";
            model1.note = "";
            model1.tick_mark = model.pregnancytest_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "ecg_tick";
            model1.note = "";
            model1.tick_mark = model.ecg_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "xray_tick";
            model1.note = "";
            model1.tick_mark = model.xray_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "ctscanmri_tick";
            model1.note = "";
            model1.tick_mark = model.ctscanmri_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);

            model1.text_title = "others_tick";
            model1.note = "";
            model1.tick_mark = model.others_tick;
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);



            if ((model.vital_pulse is null ? "" : model.vital_pulse).Length > 0)
            {
                model1.text_title = "vital_pulse";
                model1.note = model.vital_pulse;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.vital_temp is null ? "" : model.vital_temp).Length > 0)
            {
                model1.text_title = "vital_temp";
                model1.note = model.vital_temp;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.vital_resp is null ? "" : model.vital_resp).Length > 0)
            {
                model1.text_title = "vital_resp";
                model1.note = model.vital_resp;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.vital_bp is null ? "" : model.vital_bp).Length > 0)
            {
                model1.text_title = "vital_bp";
                model1.note = model.vital_bp;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.vital_spo2 is null ? "" : model.vital_spo2).Length > 0)
            {
                model1.text_title = "vital_spo2";
                model1.note = model.vital_spo2;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.gcs_e is null ? "" : model.gcs_e).Length > 0)
            {
                model1.text_title = "gcs_e";
                model1.note = model.gcs_e;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.gcs_m is null ? "" : model.gcs_m).Length > 0)
            {
                model1.text_title = "gcs_m";
                model1.note = model.gcs_m;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.gcs_v is null ? "" : model.gcs_v).Length > 0)
            {
                model1.text_title = "gcs_v";
                model1.note = model.gcs_v;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.provdiag_history is null ? "" : model.provdiag_history).Length > 0)
            {
                model1.text_title = "provdiag_history";
                model1.note = model.provdiag_history;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.provdiag_examination is null ? "" : model.provdiag_examination).Length > 0)
            {
                model1.text_title = "provdiag_examination";
                model1.note = model.provdiag_examination;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.provdiag_emergencytreatment is null ? "" : model.provdiag_emergencytreatment).Length > 0)
            {
                model1.text_title = "provdiag_emergencytreatment";
                model1.note = model.provdiag_emergencytreatment;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.provdiag_adviceondischarge is null ? "" : model.provdiag_adviceondischarge).Length > 0)
            {
                model1.text_title = "provdiag_adviceondischarge";
                model1.note = model.provdiag_adviceondischarge;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.admtward_no is null ? "" : model.admtward_no).Length > 0)
            {
                model1.text_title = "admtward_no";
                model1.note = model.admtward_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.condition is null ? "" : model.condition).Length > 0)
            {
                model1.text_title = "condition";
                model1.note = model.condition;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.doc_name is null ? "" : model.doc_name).Length > 0)
            {
                model1.text_title = "doc_name";
                model1.note = model.doc_name;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.doc_no is null ? "" : model.doc_no).Length > 0)
            {
                model1.text_title = "doc_no";
                model1.note = model.doc_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }

            if ((model.doc_signature is null ? "" : model.doc_signature).Length > 0)
            {
                model1.text_title = "doc_signature";
                model1.note = model.doc_signature;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormDetailsInsert", model1);
            }
            return Ok();
        }

        /*[HttpPost]
        [Route("api/EmergencyFormAll/Update")]
        public IHttpActionResult Update(EmergencyFormAll_dt model)
        {

            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormdelete", model);
            EmergencyFormDetailsInsert_dt model1 = new EmergencyFormDetailsInsert_dt();
          
            return Ok();
        }*/                     



        [HttpGet]
        [Route("api/EmergencyFormAll")]
        public IHttpActionResult GetAll(int emergency_id)
        {
            var list = DapperHelper.QueryStoredProcedure<EmergencyFormGetdata_dt>
                ("sp_EmergencyFormGetdata", new { emergency_id = emergency_id }).ToList();
            EmergencyFormAll_dt model_new = new EmergencyFormAll_dt();
            foreach (var x in list)
            {
                model_new.emergency_id = x.emergency_id;
                model_new.hospid = x.hospid;
                model_new.ddate = x.ddate;
                model_new.userid = x.userid;
                model_new.patient_name = x.patient_name;
                model_new.phone = x.phone;
                model_new.brought_by = x.brought_by;
                model_new.relationship = x.relationship;
                model_new.ttime = x.ttime;
                model_new.age = x.age;
                model_new.sex = x.sex;
                model_new.occupation = x.occupation;
                model_new.address = x.address;
                model_new.bed_no = x.bed_no;
            }

            var list1 = DapperHelper.QueryStoredProcedure<EmergencyFormDetailsGetData_dt>
                ("sp_EmergencyFormDetailsGetdata", new { emergency_id = emergency_id }).ToList();          
            foreach (var x in list1)
            {
                model_new.emergency_id = x.emergency_id;
                model_new.discharge_ddate = x.date_time;


                if (x.text_title == "vital_pulse")
                {
                    model_new.vital_pulse = x.note;
                }

                if (x.text_title == "vital_temp")
                {
                    model_new.vital_temp = x.note;
                }

                if (x.text_title == "vital.Resp")
                {
                    model_new.vital_resp = x.note;
                }

                if (x.text_title == "vital_bp")
                {
                    model_new.vital_bp = x.note;
                }

                if (x.text_title == "vital_spo2")
                {
                    model_new.vital_spo2 = x.note;
                }

                if (x.text_title == "gcs_e")
                {
                    model_new.gcs_e = x.note;
                }

                if (x.text_title == "gcs_m")
                {
                    model_new.gcs_m = x.note;
                }

                if (x.text_title == "gcs_v")
                {
                    model_new.gcs_v = x.note;
                }

                if (x.text_title == "provdiag_history")
                {
                    model_new.provdiag_history = x.note;
                }

                if (x.text_title == "provdiag_examination")
                {
                    model_new.provdiag_examination = x.note;
                }

                if (x.text_title == "provdiag_emergencytreatment")
                {
                    model_new.provdiag_emergencytreatment = x.note;
                }

                if (x.text_title == "provdiag_adviceondischarge")
                {
                    model_new.provdiag_adviceondischarge = x.note;
                }


                if (x.text_title == "hbtcdc_tick")
                {
                    model_new.hbtcdc_tick = x.tick_mark;
                }


                if (x.text_title == "blodgroupingncross_tick")
                {
                    model_new.blodgroupingncross_tick = x.tick_mark;
                }

                if (x.text_title == "matching_tick")
                {
                    model_new.matching_tick = x.tick_mark;
                }

                if (x.text_title == "blodsugar_tick")
                {
                    model_new.blodsugar_tick = x.tick_mark;
                }

                if (x.text_title == "ures_tick")
                {
                    model_new.ures_tick = x.tick_mark;
                }

                if (x.text_title == "creatinine_tick")
                {
                    model_new.creatinine_tick = x.tick_mark;
                }

                if (x.text_title == "lft_tick")
                {
                    model_new.lft_tick = x.tick_mark;
                }

                if (x.text_title == "amylase_tick")
                {
                    model_new.amylase_tick = x.tick_mark;
                }

                if (x.text_title == "cpkmb_tick")
                {
                    model_new.cpkmb_tick = x.tick_mark;
                }

                if (x.text_title == "electrolysis_tick")
                {
                    model_new.electrolysis_tick = x.tick_mark;
                }

                if (x.text_title == "urineketone_tick")
                {
                    model_new.urineketone_tick = x.tick_mark;
                }

                if (x.text_title == "stooltest_tick")
                {
                    model_new.stooltest_tick = x.tick_mark;
                }

                if (x.text_title == " pregnancytest_tick")
                {
                    model_new.pregnancytest_tick = x.tick_mark;
                }

                if (x.text_title == "ecg_tick")
                {
                    model_new.ecg_tick = x.tick_mark;
                }

                if (x.text_title == "xray_tick")
                {
                    model_new.xray_tick = x.tick_mark;
                }

                if (x.text_title == "ctscanmri_tick")
                {
                    model_new.ctscanmri_tick = x.tick_mark;
                }

                if (x.text_title == "others_tick")
                {
                    model_new.others_tick = x.tick_mark;
                }


                if (x.text_title == "admtward_no")
                {
                    model_new.admtward_no = x.note;
                }

                if (x.text_title == "condition")
                {
                    model_new.condition = x.note;
                }

                if (x.text_title == "doc_name")
                {
                    model_new.doc_name = x.note;
                }

                if (x.text_title == "doc_no")
                {
                    model_new.doc_no = x.note;
                }

                if (x.text_title == "doc_signature")
                {
                    model_new.doc_signature = x.note;
                }
            }
            return Ok(model_new);
        }

        [HttpGet]
        [Route("api/EmergencyFormAllNew")]
        public IHttpActionResult GetAl(int emergency_id)
        {
            var list = DapperHelper.QueryStoredProcedure<EmergencyFormGetdata_dt>
                ("sp_EmergencyFormGetdata", new { emergency_id = emergency_id }).ToList();
            EmergencyFormAll_dt model_new = new EmergencyFormAll_dt();
            foreach (var x in list)
            {
                model_new.emergency_id = x.emergency_id;
                model_new.hospid = x.hospid;
                model_new.ddate = x.ddate;
                model_new.userid = x.userid;
                model_new.patient_name = x.patient_name;
                model_new.phone = x.phone;
                model_new.brought_by = x.brought_by;
                model_new.relationship = x.relationship;
                model_new.ttime = x.ttime;
                model_new.age = x.age;
                model_new.sex = x.sex;
                model_new.occupation = x.occupation;
                model_new.address = x.address;
                model_new.bed_no = x.bed_no;
            }

            var list1 = DapperHelper.QueryStoredProcedure<EmergencyFormDetailsGetData_dt>
                ("sp_EmergencyFormDetailsGetdata", new { emergency_id = emergency_id }).ToList();
            foreach (var x in list1)
            {

                model_new.emergency_id = x.emergency_id;
                model_new.discharge_ddate = x.date_time;

                if (x.note !=null)
                {
                   // x.note.Add(model_new);
                }

                if (x.tick_mark) { 
                //x.tick_mark.Add(model_new);
                }             
            }
            return Ok(model_new);

        }    
    }
}
