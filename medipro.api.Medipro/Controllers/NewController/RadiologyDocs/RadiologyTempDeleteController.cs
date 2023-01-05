using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.RadiologyDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static medipro.api.Medipro.Models.NewModels.RadiologyDocs.RadiologyTempDelete;

namespace medipro.api.Medipro.Controllers.NewController.RadiologyDocs
{
    public class RadiologyTempDeleteController : ApiController
{

    [HttpPost]
    [Route("api/deleteReportTemplate")]
    public IHttpActionResult Post(reportTemplateDelete_dt model)
    {
        DapperHelper.ExecuteStoredProcedure("sp_DeleteReportTemplateBySn", model);
        return Ok();
    }


}
}