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
    public class CmplistVsSupController : ApiController
    {
        [HttpGet]
        [Route("api/CmplistVsSup/{ac_code}/{compcode}/{search}")]
        public IHttpActionResult Search(int ac_code, int compcode, string search)
        {
            CmplistVsSupList_dt CompanyVsSupplier = new CmplistVsSupList_dt();
            var list = DapperHelper.QueryStoredProcedure<CmplistVsSupSelect_dt>
                ("sp_CmplistVsSupSelect", new {ac_code = ac_code, compcode = compcode,  search = search }).ToList();
            CompanyVsSupplier.CompanyVsSupplier = list;
            return Ok(CompanyVsSupplier);
        }   
    }
}
