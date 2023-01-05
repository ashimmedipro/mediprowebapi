using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.EyeDocs
{
    public class EyeRegistration_dt
    {
        public string mrdno { get; set; }
        public int hospid { get; set; }
        public int clusterNo { get; set; }
        public int kesId { get; set; }
        /*
        public string pname { get; set; }
        public date dob { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string wardNo { get; set; }
        public string maritalStatus { get; set; }
        public string occupation { get; set; }
        */
        public string tole { get; set; }
        public string contact { get; set; }
        public string contact1 { get; set; }
        public string education { get; set; }
        public string edu_specify { get; set; }
        public string ethnicity { get; set; }
        public string ethnic_specify { get; set; }
        public string religion { get; set; }
        public string religion_specify { get; set; }
        public string marital_specify { get; set; }
        public string occupation_specify { get; set; }
        public string familySize { get; set; }
        public int annualIncome { get; set; } //
        public bool examStatus { get; set; }
        public bool exam_healthIssues { get; set; }//
        public bool health_visionImpair { get; set; }
        public bool health_deaf { get; set; }
        public bool health_mentalhealth { get; set; }
        public bool health_intellectinjury { get; set; }
        public bool health_braininjury { get; set; }
        public bool health_autism { get; set; }
        public bool health_physicaldisability { get; set; }
        public bool health_others { get; set; }
        public string health_others_specify { get; set; }
        public bool exam_death { get; set; }
        public bool exam_migration { get; set; }
        public bool exam_notavail { get; set; }
        public bool exam_others { get; set; }
        public string exam_others_specify { get; set; }
        public bool pt_status { get; set; }
        public bool pt_abnormal_deaf { get; set; }
        public bool pt_abnormal_mentalhealth { get; set; }
        public bool pt_abnormal_intellectinjury { get; set; }
        public bool pt_abnormal_braininjury { get; set; }
        public bool pt_abnormal_autism { get; set; }
        public bool pt_abnormal_physicaldisability { get; set; }
        public bool pt_abnormal_others { get; set; }
        public string pt_abnormal_others_specify { get; set; }
        public decimal pt_wt { get; set; }
        public decimal pt_ht { get; set; }
        public int pt_bp_sys { get; set; }
        public int pt_bp_dias { get; set; }
        public string pt_bmi_status { get; set; }
        public string pt_bp_status { get; set; }
    }


    public class EyeRegistrationSelect_dt
    {
        public string mrdno { get; set; }
        public int hospid { get; set; }
        public int clusterNo { get; set; }//
        public int kesId { get; set; }
      /**  
        public string pname { get; set; }
        public DateTime dob { get; set; }//
        public string gender { get; set; }
        public string address { get; set; }
        public string wardNo { get; set; }
        public string maritalStatus { get; set; }
        public string occupation { get; set; }**/
        
        public string tole { get; set; }
        public string contact { get; set; }//
        public string contact1 { get; set; }
        public string education { get; set; }
        public string edu_specify { get; set; }
        public string ethnicity { get; set; }//
        public string ethnic_specify { get; set; }
        public string religion { get; set; }
        public string religion_specify { get; set; }
        public string marital_specify { get; set; }
        public string occupation_specify { get; set; }
        public string familySize { get; set; }
        public int annualIncome { get; set; }//
        public bool examStatus { get; set; }
        public bool exam_healthIssues { get; set; }
        public bool health_visionImpair { get; set; }
        public bool health_deaf { get; set; }
        public bool health_mentalhealth { get; set; }
        public bool health_intellectinjury { get; set; }
        public bool health_braininjury { get; set; }
        public bool health_autism { get; set; }
        public bool health_physicaldisability { get; set; }
        public bool health_others { get; set; }
        public string health_others_specify { get; set; }
        public bool exam_death { get; set; } //
        public bool exam_migration { get; set; }
        public bool exam_notavail { get; set; }
        public bool exam_others { get; set; }
        public string exam_others_specify { get; set; }
        public bool pt_status { get; set; }
        public bool pt_abnormal_deaf { get; set; }
        public bool pt_abnormal_mentalhealth { get; set; }
        public bool pt_abnormal_intellectinjury { get; set; }
        public bool pt_abnormal_braininjury { get; set; }
        public bool pt_abnormal_autism { get; set; }
        public bool pt_abnormal_physicaldisability { get; set; }
        public bool pt_abnormal_others { get; set; }
        public string pt_abnormal_others_specify { get; set; }
        public decimal pt_wt { get; set; }
        public decimal pt_ht { get; set; }
        public int pt_bp_sys { get; set; }
        public int pt_bp_dias { get; set; }
        public string pt_bmi_status { get; set; }
        public string pt_bp_status { get; set; }
    }

    public class EyeRegOpdBillSelect_dt
    {
        public int servid { get; set; }
        public string inv_no { get; set; }
        public int hospid { get; set; }
        public string pname { get; set; }
        public string sex { get; set; }
        public float ageday { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public int consid { get; set; }
        public string referer { get; set; }
        public string servname { get; set; }
        public DateTime dob { get; set; }
        public int clusterno { get; set; }
        public int kesid { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string pt_bmi_status { get; set; }
        public string pt_bp_status { get; set; }
        public string tole { get; set; }
        public string telephone { get; set; }
    }

    public class EyeRegistrationAllSelect_dt
    {
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public int clusterno { get; set; }
        public int kesid { get; set; }
        public string pname { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string  address { get; set; }
        public string tole { get; set; }
        public string wardno { get; set; }
        public string occupation { get; set; }
        public string contact { get; set; }
        public string contact1 { get; set; }
        public string education { get; set; }
        public string edu_specify { get; set; }
        public string ethnicity { get; set; }
        public string ethnic_specify { get; set; }
        public string religion { get; set; }
        public string religion_specify { get; set; }
        public string marital_specify { get; set; }
        public string occupation_specify { get; set; }
        public string familysize { get; set; }
        public int annualincome { get; set; }
        public bool examstatus { get; set; }
        public bool exam_healthissues { get; set; }
        public bool health_visionimpair { get; set; }
        public bool health_deaf { get; set; }
        public bool health_mentalhealth { get; set; }
        public bool health_intellectinjury { get; set; }
        public bool health_braininjury { get; set; }
        public bool health_autism { get; set; }
        public bool health_physicaldisability { get; set; }
        public bool health_others { get; set; }
        public string health_others_specify { get; set; }
        public bool exam_death { get; set; }
        public bool exam_migration { get; set; }
        public bool exam_notavail { get; set; }
        public bool exam_others { get; set; }
        public string exam_others_specify { get; set; }
        public bool pt_status { get; set; }
        public bool pt_abnormal_deaf { get; set; }
        public bool pt_abnormal_mentalhealth { get; set; }
        public bool pt_abnormal_intellectinjury { get; set; }
        public bool pt_abnormal_braininjury { get; set; }
        public bool pt_abnormal_autism { get; set; }
        public bool pt_abnormal_physicaldisability { get; set; }
        public bool pt_abnormal_others { get; set; }
        public string pt_abnormal_others_specify { get; set; }
        public double pt_wt { get; set; }
        public double pt_ht { get; set; }
        public int pt_bp_sys { get; set; }
        public int pt_bp_dias { get; set; }
        public string mrdno { get; set; }
        public string pt_bmi_status { get; set; }
        public string pt_bp_status { get; set; }



    }

    public class KesIdUpdate_dt
    {

        public string mrdno { get; set; }
        public int clusterno { get; set; }
        public int kesid { get; set; }
    }
}