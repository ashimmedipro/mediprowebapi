using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class IpdRequistion_dt
    {
        public string pcode { get; set; }
        public DateTime ddate { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public DateTime dob { get; set; }
        public string remarks { get; set; }
        public string patno { get; set; }
        public string bedno { get; set; }
       // public int refid { get; set; }
        //public int wardno { get; set; }
        public string particular { get; set; }
        public string referer { get; set; }
        public string req_no { get; set; }
        public string username { get; set; }

    }
    public class IpdRequistionDetail_dt
    {
        //public string req_no { get; set; }
        public int md_code { get; set; }
        public int qty { get; set; }
    }

    public class IpdRequistionDetail1_dt
    {
        public string req_no { get; set; }
        public int md_code { get; set; }
        public int qty { get; set; }
    }
    public class IpdRequsitionAll_dt
    {
        public string pcode { get; set; }
        public DateTime ddate { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public DateTime dob { get; set; }
        public string remarks { get; set; }
        public string patno { get; set; }
        public string bedno { get; set; }
        public string wardname { get; set; }
        public string referer { get; set; }
        public string req_no { get; set; }
        public string username { get; set; }
        public List<IpdRequistionDetail_dt> details { get; set; }
    }

    
}