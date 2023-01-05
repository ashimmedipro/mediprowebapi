using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class MedicineInstructionController : ApiController
    {
        [HttpPost]
        [Route("api/MedicineInstruction")]
        public IHttpActionResult Post(MedicineInstruction_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_medicine_instruction_Insert", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/MedicineInstruction")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<MedicineInstructionSelect_dt>
                ("sp_medicine_instructionSelect").ToList();
            return Ok(list);
        }
    }
}
