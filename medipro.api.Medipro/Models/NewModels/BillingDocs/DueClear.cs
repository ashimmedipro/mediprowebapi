using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs
{
    public class DueClear_dt
    {
        public DateTime ddate { get; set; }
        public string r_no { get; set; }
        public string inv_no { get; set; }
        public string billtime { get; set; }
        public string due { get; set; }
        public string remarks { get; set; }
        public int hospid { get; set; }
        public int nuser { get; set; }
        public double amount { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public int ipdno { get; set; }
        public bool ipd { get; set; }
        public int serialno { get; set; }
        public bool refund { get; set; }
        public double rebate { get; set; }
        public string fy { get; set; }
        public int firm { get; set; }
    }

    public class DueClearSelectInvno_dt
    {
        public string inv_no { get; set; }
    }





    public class DueClearView_dt
    {
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public int ac_code { get; set; }
        public int refid { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double paid { get; set; }
        public double tender { get; set; }
        public int user { get; set; }
        public string billtime { get; set; }
        public bool member { get; set; }
        public double due { get; set; }
        public string billmode { get; set; }
        public string p_type { get; set; }
        public string remarks { get; set; }
        public bool posted { get; set; }
        public string contact { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public float ageday { get; set; }
        public int firm { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public double advance { get; set; }
        public bool ipd { get; set; }
        public int ipdno { get; set; }
        public int pathologist { get; set; }
        public int technician { get; set; }
        public string bedno { get; set; }
        public string labno { get; set; }
        public DateTime collection_date { get; set; }
        public DateTime report_date { get; set; }
        public int grpid { get; set; }
        public int scheme { get; set; }
        public string clinical { get; set; }
        public string footer { get; set; }
        public bool er { get; set; }
        public string inv_no1 { get; set; }
        public int hospid1 { get; set; }
        public string appointment_id { get; set; }
        public string regtype { get; set; }
        public string martialstatus { get; set; }
        public string occupation { get; set; }
        public bool reg { get; set; }
        public string email { get; set; }
        public int consid { get; set; }
        public int assistant { get; set; }
        public bool foreigner { get; set; }
        public string appby { get; set; }
        public string telno { get; set; }
        public string reqby { get; set; }
        public string organization { get; set; }
        public int dpid { get; set; }
        public double xchange { get; set; }
        public string foreign_currently { get; set; }
        public double foreign_amount { get; set; }
        public double foreign_discount { get; set; }
        public double foreign_vat { get; set; }
        public string barcode { get; set; }
        public bool sms { get; set; }
        public string collection_time { get; set; }
        public string report_time { get; set; }
        public string prev_inv_no { get; set; }
        public bool refund { get; set; }
        public int print_count { get; set; }
        public int cancel_id { get; set; }
        public DateTime cancel_date { get; set; }
        public string edited { get; set; }
        public int nagar_vdc_id { get; set; }
        public int ethinic_code { get; set; }
        public int service_type_id { get; set; }
        public string note { get; set; }
        public bool pathologist_pw { get; set; }
        public bool assistant_pw { get; set; }
        public bool technician_pw { get; set; }
        public int freehealth_id { get; set; }
        public string salestype { get; set; }
        public double roundoff { get; set; }
        public bool sync_with_ird { get; set; }
        public bool is_realtime { get; set; }
        public int dailynumber { get; set; }
        public string pf { get; set; }
        public string speciality { get; set; }
        public string patienttype { get; set; }
        public string mrlocation { get; set; }
        public string patient_category { get; set; }
        public DateTime ird_DateTime { get; set; }
        public bool insurance { get; set; }
        public bool night { get; set; }
        public string note1 { get; set; }
        public string note2 { get; set; }
        public string patient_type { get; set; }
        public int claim_code { get; set; }
        public string branch_center { get; set; }
        public int return_id { get; set; }
        public bool labsms { get; set; }
        public bool telemedicine { get; set; }
        public int telemedicineid { get; set; }
        public long barcode1 { get; set; }
        public bool lab_report_upload { get; set; }
        public DateTime lab_report_upload_time { get; set; }
        public bool website { get; set; }
        public bool ssf { get; set; }
        public int ssf_scheme_id { get; set; }
        public double ssf_pc { get; set; }
        public bool fileupload { get; set; }
        public double insurance_amount { get; set; }
        public string pname { get; set; }
        public double ndue { get; set; }
    }
}