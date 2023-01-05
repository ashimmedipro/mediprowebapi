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
    public class AdmissionRecordsDetailController : ApiController
    {
        [HttpPost]
        [Route("api/AdmissionRecordsDetail")]
        public IHttpActionResult Post(AdmissionRecordsAll_dt model)
        {
            AdmissionRecordsdetailsInsert_dt model1 = new AdmissionRecordsdetailsInsert_dt();
            model1.admission_id = model.admission_id;
            model1.ddate = model.ddate;
            model1.userid = model1.userid;
            model1.refid = model1.refid;
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);

            if ((model.re_admission is null ? "" : model.re_admission).Length > 0)
            {
                model1.title = "re_admission";
                model1.result = model.re_admission;              
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.date_admission is null ? "" : model.date_admission).Length > 0)
            {
                model1.title = "date_admission";
                model1.result = model.date_admission;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.time_admission is null ? "" : model.time_admission).Length > 0)
            {
                model1.title = "time_admission";
                model1.result = model.time_admission;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.date_discharge is null ? "" : model.date_discharge).Length > 0)
            {
                model1.title = "date_discharge";
                model1.result = model.date_discharge;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.time_discharge is null ? "" : model.time_discharge).Length > 0)
            {
                model1.title = "time_discharge";
                model1.result = model.time_discharge;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.prov_diag is null ? "" : model.prov_diag).Length > 0)
            {
                model1.title = "prov_diag";
                model1.result = model.prov_diag;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.final_diag is null ? "" : model.final_diag).Length > 0)
            {
                model1.title = "final_diag";
                model1.result = model.final_diag;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.sec_diag is null ? "" : model.sec_diag).Length > 0)
            {
                model1.title = "sec_diag";
                model1.result = model.sec_diag;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.op_procedure is null ? "" : model.op_procedure).Length > 0)
            {
                model1.title = "op_procedure";
                model1.result = model.op_procedure;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.cause_death is null ? "" : model.cause_death).Length > 0)
            {
                model1.title = "cause_death";
                model1.result = model.cause_death;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.result is null ? "" : model.result).Length > 0)
            {
                model1.title = "result";
                model1.result = model.result;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.final_summary is null ? "" : model.final_summary).Length > 0)
            {
                model1.title = "final_summary";
                model1.result = model.final_summary;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.police_case is null ? "" : model.police_case).Length > 0)
            {
                model1.title = "police_case";
                model1.result = model.police_case;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }

            if ((model.remark is null ? "" : model.remark).Length > 0)
            {
                model1.title = "remark";
                model1.result = model.remark;
                DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailInsert", model1);
            }
            return Ok();
        }

        [HttpPost]
        [Route("api/AdmissionRecordsDetail/Update")]
        public IHttpActionResult Update(AdmissionRecordsdetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailUpdate", model);
            return Ok();
        }

        /*[HttpGet]
        [Route("api/AdmissionRecordsDetail")]
        public IHttpActionResult get(int admission_id)
        {
            var list = DapperHelper.QueryStoredProcedure<AdmissionRecordsdetailsGetData_dt>
                ("sp_AdmissionRecordsDetailGetdata", new { admission_id = admission_id }).ToList();
            return Ok(list);
        }*/


        [HttpPost]
        [Route("api/AdmissionRecordsDetail/Delete")]
        public IHttpActionResult Delete(AdmissionRecordsdetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDetailDelete", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AdmissionRecordsDetail")]
        public IHttpActionResult Get(int admission_id)
        {
            var list = DapperHelper.QueryStoredProcedure<AdmissionRecordsdetailsGetData_dt>
                ("sp_AdmissionRecordsDetailGetdata", new { admission_id = admission_id }).ToList();
            AdmissionRecordsAll_dt model1 = new AdmissionRecordsAll_dt();
            foreach (var x in list)
            {
                model1.admission_id = x.admission_id;
                model1.ddate = x.ddate;
                model1.refid = x.refid;

                if (x.title == "date_admission")
                {
                    model1.date_admission = x.result;
                }

                if (x.title == "time_admission")
                {
                    model1.time_admission = x.result;
                }

                if (x.title == "date_discharge")
                {
                    model1.date_discharge = x.result;
                }

                if (x.title == "time_discharge")
                {
                    model1.time_discharge = x.result;
                }

                if (x.title == "re_admission")
                {
                    model1.re_admission = x.result;
                }

                if (x.title == "prov_diag")
                {
                    model1.prov_diag = x.result;
                }

                if (x.title == "prov_diag")
                {
                    model1.prov_diag = x.result;
                }

                if (x.title == "final_diag")
                {
                    model1.final_diag = x.result;
                }

                if (x.title == "sec_diag")
                {
                    model1.sec_diag = x.result;
                }

                if (x.title == "op_procedure")
                {
                    model1.op_procedure = x.result;
                }

                if (x.title == "cause_death")
                {
                    model1.cause_death = x.result;
                }

                if (x.title == "result")
                {
                    model1.result = x.result;
                }

                if (x.title == "final_summary")
                {
                    model1.final_summary = x.result;
                }

                if (x.title == "police_case")
                {
                    model1.police_case = x.result;
                }

                if (x.title == "remark")
                {
                    model1.remark = x.result;
                }
                
            }
            return Ok(model1);
        }
    }
}

           
        



