using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure
{
    public class ChallanModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/Challan")] 
        public IHttpActionResult Get()
        {
            ChallanModify cm = new ChallanModify();
            cm.challanParty();//executed
            cm.ChallanMdCodeSelect();//executed
            cm.StbalSelectByMdcode();//executed
            cm.StbalSelectByDate();
            cm.ChallanInsert();
            cm.ChallanSelectByDate();
            cm.ChallanSelectByInvno();



            return Ok();

        }


    }
}
