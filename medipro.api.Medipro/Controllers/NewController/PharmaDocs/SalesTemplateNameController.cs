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
    public class SalesTemplateNameController : ApiController
    {
        [HttpPost]
        [Route("api/SalesTemplateName")]
        public IHttpActionResult Post(SalesTemplateName_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_sales_template_nameInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/SalesTemplateName/Update")]
        public IHttpActionResult Update(SalesTemplateName_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_sales_template_nameUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/SalesTemplateName")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<SalesTemplateName_dt>
                ("sp_sales_template_nameSelect").ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/SalesTemplateName/Delete")]
        public IHttpActionResult Delete(SalesTemplateName_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_sales_template_nameDelete", model);
            return Ok();
        }
    }
}
