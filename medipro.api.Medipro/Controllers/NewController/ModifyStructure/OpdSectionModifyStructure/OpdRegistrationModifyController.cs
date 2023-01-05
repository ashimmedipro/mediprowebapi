using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class OpdRegistrationModifyController : ApiController
    {

        [HttpGet] 
        [Route("api/ModifyStructure/OpdRegistrationModify")]
        public IHttpActionResult Get()
        {

            OpdRegistrationModify o = new OpdRegistrationModify();

            o.ServiceSelect();
            o.OpdRegServiceSelect();
            o.OpdRegHospidGeneralSelect();
            o.MemberSearch();
            o.OpdRegMemberSelect();
            o.OrganizeSelectMember();
            o.OpdRegDepartmentSelect();
            o.OpdRegConsultantSelect();
            o.OdRegReferedBySelect();
            o.OpdRegInsert();


            return Ok();

        }
    }
}
