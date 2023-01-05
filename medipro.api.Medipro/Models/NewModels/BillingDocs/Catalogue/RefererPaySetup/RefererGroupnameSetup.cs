using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.RefererPaySetup
{
    //same model for insert and select and update
    public class Tempalate_dt
    {
        public int sn { get; set; }
        public string templatename { get; set; }
        public int typeid { get; set; }
    }


    //templatename select 

    public class TemplateNameSelect_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public double amt { get; set; }
        public double pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }
        public string appointment_endtime { get; set; }
        public int hospital_code { get; set; }
        public int appointment_limit { get; set; }
        public bool appointment { get; set; }
        public bool su { get; set; }
        public bool mo { get; set; }
        public bool tu { get; set; }
        public bool we { get; set; }
        public bool th { get; set; }
        public bool fr { get; set; }
        public bool sa { get; set; }
    }

    //on click groupname 

    public class GroupnameOnClick_dt
    {
        public int id { get; set; }
        public int servid { get; set; }
        public int sn { get; set; }
        public double pc { get; set; }
        public double amount { get; set; }
        public double tds { get; set; }
        public bool gross { get; set; }
        public double discount { get; set; }
        public int refid { get; set; }
        public string servname { get; set; }
    }


    //all update
    public class AllUpdate_dt
    {
        public int grpid { get; set; }
        public int sn { get; set; }
        public double pc { get; set; }
        public double amount { get; set; }
        public double tds { get; set; }
        public bool gross { get; set; }
        public double discount { get; set; }

    }

    //singleUpdate
    public class SingleUpdate_dt
    {
        public int servid { get; set; }
        public int sn { get; set; }
        public double pc { get; set; }
        public double amount { get; set; }
        public double tds { get; set; }
        public bool gross { get; set; }
        public double discount { get; set; }
    }

}