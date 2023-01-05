using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class DoctorsAppointmentModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/DoctorsAppointmentModify")]
        public IHttpActionResult Get()
        {
            DoctorsAppointmentModify d = new DoctorsAppointmentModify();

            d.DoctorAppForm();
            d.AllDocSelect();
            d.DocAppAllTimSlotByDaySelect();
            d.DocTimeSlotbyRefidSelect();
            d.DocDayAvilableByRefidSelect();
            d.DoctorAvailableTimeByDay();







            return Ok();

        }
    }
}
