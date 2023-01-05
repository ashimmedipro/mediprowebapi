using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.ServiceMasterSetup
{
    public class AddServicePanelSearch_dt
    {
        public int grpid { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float rateb { get; set; }
        public float ratec { get; set; }
        public double vat { get; set; }
        public bool vatincl { get; set; }
        public bool drpc { get; set; }
        public bool tds { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public int wardmin { get; set; }
        public int icumin { get; set; }
        public int opdmin { get; set; }
        public int postmin { get; set; }
        public int serial { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public float pc { get; set; }
        public int cons_code { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public string roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public int groupid { get; set; }
        public string footnote { get; set; }
        public string samplesource { get; set; }
        public int samplesoure { get; set; }
        public string ref_code { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool imageupload { get; set; }
        public string machinname { get; set; }
        public bool test_panel { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
        public double echs_rate { get; set; }
        public int ac_code { get; set; }
        public int disc_code { get; set; }
    }

    //get by panelid

    public class AddServPanelGetByPanelid_dt
    {
        public int plid { get; set; }
        public int servid { get; set; }
        public int panelid { get; set; }
        public string servname { get; set; }
        public string groupname { get; set; }
        public double ratea { get; set; }
        public double pc { get; set; }
        public double dist_rate { get; set; }
    }

    //get total

    public class TotalGet_dt
    {
        public double rateb { get; set; }
    }


    //service panel add

    public class ServicePanelPost_dt
    {
        public int panelid { get; set; }
        public int servid { get; set; }
    }


    //service panel update
    public class ServicePanelUpdate_dt
    {
        public int plid { get; set; }
        public int panelid { get; set; }
        public int servid { get; set; }
    }

    //get service name 
    public class ServNameGet_dt
    {
        public int grpid { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float rateb { get; set; }
        public float ratec { get; set; }
        public double vat { get; set; }
        public bool vatincl { get; set; }
        public bool drpc { get; set; }
        public bool tds { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public int wardmin { get; set; }
        public int icumin { get; set; }
        public int opdmin { get; set; }
        public int postmin { get; set; }
        public int serial { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public float pc { get; set; }
        public int cons_code { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public string roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public int groupid { get; set; }
        public string footnote { get; set; }
        public string samplesource { get; set; }
        public int samplesoure { get; set; }
        public string ref_code { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool imageupload { get; set; }
        public string machinname { get; set; }
        public bool test_panel { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
        public double echs_rate { get; set; }
        public int grpac_code { get; set; }
        public int disc_code { get; set; }
        public int plid { get; set; }
        public double netfee { get; set; }
        public string groupname { get; set; }
    }

    //report
    public class ServPanelRpt_dt
    {
        public int plid { get; set; }
        public int servid { get; set; }
        public int panelid { get; set; }
        public string panelname { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float disc { get; set; }
    }




    }