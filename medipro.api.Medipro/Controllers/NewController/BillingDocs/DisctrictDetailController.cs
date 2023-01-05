using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class DisctrictDetailController : ApiController
    {
        [HttpGet]
        [Route("api/DistrictDetailSelect")]
        public IHttpActionResult Get(string search="")
        {
            var list = DapperHelper.QueryStoredProcedure<DistrictDetailSelect_dt>("sp_DistrictDetailSelect", new { search=search
            }).ToList();
            return Ok(list); 
        }
    }
}
