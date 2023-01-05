using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs
{
   

        public class OpdTempInsert_dt
        {
            public int sn { get; set; }
            public int servid { get; set; }
            public int grpid { get; set; }
            public int disc_code { get; set; }
            public int plid { get; set; }
            public string servname { get; set; }
            public int qty { get; set; }
            public double rate { get; set; }
            public double disc { get; set; }
            public double amount { get; set; }
            public double disc_amt { get; set; }
            public double net { get; set; }
            public bool panel { get; set; }
            public bool formatted { get; set; }
            public int lines { get; set; }
            public double dueamt { get; set; }
            public double process { get; set; }
            public string type { get; set; }
            public int serial { get; set; }
            public double vatamt { get; set; }
            public double vat { get; set; }
            public double cost { get; set; }
            public bool done { get; set; }
            public string roomno { get; set; }
            public int userid { get; set; }
        }




    public class OpdTmpGet_dt
    {
        public int sn { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no1 { get; set; }
        public int servid { get; set; }
        public int grpid { get; set; }
        public int disc_code { get; set; }
        public int plid { get; set; }
        public string servname { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double disc { get; set; }
        public double amount { get; set; }
        public double vat { get; set; }
        public string inv_no { get; set; }
        public bool done { get; set; }
        public string roomno { get; set; }
        public bool panel { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
        public DateTime finish_date { get; set; }
        public string finish_time { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public double disc2 { get; set; }
        public double disc_amt { get; set; }
        public double net { get; set; }
        public double vatamt { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public double process { get; set; }
        public string type { get; set; }
        public int serial { get; set; }
        public string r_no { get; set; }
        public DateTime rdate { get; set; }
        public double duepaid { get; set; }
        public string due { get; set; }
        public bool sample_collected { get; set; }
        public DateTime sample_date { get; set; }
        public int sample_userid { get; set; }
        public double cost { get; set; }
        public double xchange { get; set; }
        public string testnote { get; set; }
        public bool refund { get; set; }
        public string sample_no { get; set; }
        public DateTime report_DateTime { get; set; }
        public int result_id { get; set; }
        public int verified_id { get; set; }
        public int report_userid { get; set; }
        public bool resulted { get; set; }
        public bool verified { get; set; }
        public bool reported { get; set; }
        public int pathologist_id { get; set; }
        public int technician_id { get; set; }
        public int assistant_id { get; set; }
        public double tax { get; set; }
        public double netamt { get; set; }
        public int userid { get; set; }
    }




    //MISSING APIS
    public class receiptPost_dt
    {
        public DateTime ddate { get; set; }
        public string r_no { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public string billtime { get; set; }
        public string due { get; set; }
        public string remarks { get; set; }
        public int hospid { get; set; }
        public int nuser { get; set; }
        public int firm { get; set; }
        public double amount { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public int ipdno { get; set; }
        public bool ipd { get; set; }
        public int serialno { get; set; }
        public bool refund { get; set; }
        public double rebate { get; set; }
    }

   
    public class OpdBillInsert_dt
    {
       
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int ac_code { get; set; }
        public int refid { get; set; }
        public int firm { get; set; }
        public int userid { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double paid { get; set; }
        public double advance { get; set; }
        public double tender { get; set; }
        public double due { get; set; }
        public float ageday { get; set; }
        public bool member { get; set; }
        public bool posted { get; set; }
        public string billtime { get; set; }
        public string billmode { get; set; }
        public string p_type { get; set; }
        public string remarks { get; set; }
        public string contact { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public bool ipd { get; set; }
        public string bedno { get; set; }
        public string labno { get; set; }
        public int grpid { get; set; }
        public int scheme { get; set; }
        public string clinical { get; set; }
        public bool er { get; set; }
        public DateTime collection_date { get; set; }
        public DateTime report_date { get; set; }
        public int technician { get; set; }
        public int pathologist { get; set; }
        public string appointment_id { get; set; }
        public string regtype { get; set; }
        public string martialstatus { get; set; }
        public string occupation { get; set; }
        public bool reg { get; set; }
        public string email { get; set; }
        public int consid { get; set; }
        public bool foreigner { get; set; }
        public string appby { get; set; }
        public string telno { get; set; }
        public string reqby { get; set; }
        public string organization { get; set; }
        public int dpid { get; set; }
        public double xchange { get; set; }
        public string foreign_currenty { get; set; }
        public double foreign_amount { get; set; }
        public double foreign_discount { get; set; }
        public double foreign_vat { get; set; }
        public string barcode { get; set; }
        public string prev_inv_no { get; set; }
        public bool refund { get; set; }
        public int service_type_id { get; set; }
        public int freehealth_id { get; set; }
        public string salestype { get; set; }
        public double roundoff { get; set; }
        public int dailynumber { get; set; }
        public string pf { get; set; }
        public string speciality { get; set; }
        public string patienttype { get; set; }
        public string mrlocation { get; set; }
        public string patient_category { get; set; }
        public bool insurance { get; set; }
        public bool night { get; set; }
        public string patient_type { get; set; }
        public int claim_code { get; set; }
        public string branch_center { get; set; }
        public int return_id { get; set; }
        public bool ssf { get; set; }
        public int ssf_scheme_id { get; set; }
        public double ssf_pc { get; set; }
        public double insurance_amount { get; set; }
    }



    public class tmpopdrecSum_Dt
    {
        public double tamount { get; set; }
        public double tdiscount { get; set; }
        public double dueamt { get; set; }
        public double vatamt { get; set; }
        public double vatamt1 { get; set; }

    }








}