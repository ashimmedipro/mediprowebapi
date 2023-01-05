using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection
{
    public class TempPrescriptionDrugSelect_dt
    {
        public int sn { get; set; }
        public int md_code { get; set; }
        public string prodname { get; set; }
        public string remarks { get; set; }
        public int userid { get; set; }
        public string types { get; set; }
        public string days { get; set; }
        public string unit { get; set; }
        public int qty { get; set; }

    }


    public class LastPrescriptionDetailNote_dt
    {
        public string prescription_no { get; set; }
        public int sn { get; set; }
        public string text_title { get; set; }
        public string note { get; set; }
    }


    public class PrescriptionDrugTempInsert_dt
    {
        public string prescription_no { get; set; }
        public int userid { get; set; }
    }

    public class DoctorEventGet_dt
    {
        public string remarks1 { get; set; }
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int refid { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public string remarks { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
    }


    public class DeleteProc_dt
    {
        public string prescription_no { get; set; }
    }


    public class PrescriptionInsert_dt
    {
        public string prescription_no { get; set; }
        public string inv_no { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public string billtime { get; set; }
        public int servid { get; set; }
        public int hospid { get; set; }
        public int refid { get; set; }
        public int ageday { get; set; }
        public string contact { get; set; }
        public string note { get; set; }
        public int followupdays { get; set; }
        public DateTime followup_date { get; set; }
        public string icdcode { get; set; }
    }


    public class PrescriptionServiceInsert_dt //same obj for prescription drug
    {
        public string prescription_no { get; set; }
        public int userid { get; set; }
    }

    public class TempPrescriptionServiceSelect_dt
    {
        public int sn { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public int userid { get; set; }
        public int id { get; set; }
    }

    public class PrescriptionTemplatesSelect_dt
    {
        public int sn { get; set; }
        public int id { get; set; }
        public string shortname { get; set; }
        public string templatename { get; set; }
    }

    public class TemplateInsert_dt
    {
        public int sn { get; set; }
        public int id { get; set; }
        public string shortname { get; set; }
        public string templatename { get; set; }

    }





}