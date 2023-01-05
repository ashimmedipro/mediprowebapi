using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection
{
    public class DoctorAppointment_dt
    {
        public string ty { get; set; }
        public string timing { get; set; }
        public string bs_date { get; set; }
        public DateTime app_date { get; set; }
        public int hospid { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string remarks { get; set; }
        public string telephone { get; set; }
        public string appointment_id { get; set; }
        public bool review { get; set; }
    }

    public class DoctorAppGetTimeSlot_dt
    {
        public string intime { get; set; }
        public string outtime { get; set; }
    }

    public class DoctoAllSelect_dt
    {
        public int refid { get; set; }
        public string referer { get; set; }
        public int sp_id { get; set; }
        public int ac_code { get; set; }
        public string detail { get; set; }
        public int min { get; set; }
        public string oncall { get; set; }
        public string qualification { get; set; }
    }

    public class DoctorTimeSlot_dt
    {
        public string timeslot { get; set; }
    }

    public class GetDoctorAvilabledays_dt
    {
        public string sn { get; set; }
        public string dayname { get; set; }
    }

    public class GetDoctorAvilableTimeSlotByDay_dt
    {
        public string timeslot { get; set; }
        public int sn { get; set; }
        public int ref_id { get; set; }
        public string dayname { get; set; }
        public string intime { get; set; }
        public string outtime { get; set; }
        public int inhr { get; set; }
        public int inmin { get; set; }
        public int outhr { get; set; }
        public int outmin { get; set; }
    }
}