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
    public class CalendarController : ApiController
    {
        [HttpPost]
        [Route("api/Calendar")]
        public IHttpActionResult Post(Calendar_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CalendarInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Calendar/Update")]
        public IHttpActionResult Update(Calendar_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CalendarUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Calendar")]
        public IHttpActionResult Get(DateTime ad_date)
        {
            CalendarList_dt Calendar = new CalendarList_dt();
            var list = DapperHelper.QueryStoredProcedure<Calendar_dt>
                ("sp_CalendarSelect", new { ad_date = ad_date }).ToList();
            Calendar.Calendar = list;
            return Ok(Calendar);
        }

        [HttpGet]
        [Route("api/Calendarselectbyad")]
        public IHttpActionResult Getad(DateTime ad_date)
        {
            var list = DapperHelper.QueryStoredProcedure<CalendarSelectbyAd_dt>
                ("sp_CalendarSelectbyAd_date", new { ad_date = ad_date }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Calendar/Delete")]
        public IHttpActionResult Delete(CalendarDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CalendarDelete", model);
            return Ok();
        }
    }
}
