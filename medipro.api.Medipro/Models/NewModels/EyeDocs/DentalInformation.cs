using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class DentalInformationAll_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public bool allergy_tick { get; set; }
        public string allergy { get; set; }
        public bool diabetes_tick { get; set; }
        public bool bp_tick { get; set; }
        public bool heart_disease_tick { get; set; }
        public bool liver_disease_tick { get; set; }
        public bool kidney_disease_tick { get; set; }
        public bool medications_tick { get; set; }
        public bool other_history_tick { get; set; }
        public string other_history { get; set; }
        public string chief_complain { get; set; }
        public string hopi { get; set; }
        public string dental_history { get; set; }
        //public bool brushing_tick { get; set; }
        public bool alcohol_tick { get; set; }
        public bool smoking_tick { get; set; }
        public bool tobacco_tick { get; set; }
        public bool thumb_suck_tick { get; set; }
        public bool pan_masala_tick { get; set; }
        public bool mouth_breathe_tick { get; set; }
        public bool tongue_thrust_tick { get; set; }
        public bool clench_tick { get; set; }
        public bool bruxism_tick { get; set; }
        //public bool diet_tick { get; set; }
        public bool other_habit_tick { get; set; }
        public string other_habit { get; set; }
        public bool tmj_extra_oral_tick { get; set; }
        public bool masseter_extra_oral_tick { get; set; }
        public bool lymph_nodes_extra_oral_tick { get; set; }
        public bool others_extra_oral_tick { get; set; }
        public string others_extra_oral { get; set; }
        public bool buccal_mucosa_tick { get; set; }
        public bool tongue_intra_oral_tick { get; set; }
        public bool palate_intra_oral_tick { get; set; }
        public string bpe_score { get; set; }
        public bool teeth_tick { get; set; }
      //  public string a_18_to_11_teeth { get; set; }
       // public string a_21_to_28_teeth { get; set; }
        //public string a_38_to_31_teeth { get; set; }
       // public string a_41_to_48_teeth { get; set; }
        public string emergency_mgmt { get; set; }
        public string stabilization { get; set; }
        public string maintenance { get; set; }
        public string definitive_mgmt { get; set; }
        public string treatment_done { get; set; }
        public string brush_habit { get; set; }
        public string diet_habit { get; set; }
        public string teeth_11 { get; set; }
        public string teeth_12 { get; set; }
        public string teeth_13 { get; set; }
        public string teeth_14 { get; set; }
        public string teeth_15 { get; set; }
        public string teeth_16 { get; set; }
        public string teeth_17 { get; set; }
        public string teeth_18 { get; set; }
        public string teeth_21 { get; set; }
        public string teeth_22 { get; set; }
        public string teeth_23 { get; set; }
        public string teeth_24 { get; set; }
        public string teeth_25 { get; set; }
        public string teeth_26 { get; set; }
        public string teeth_27 { get; set; }
        public string teeth_28 { get; set; }      
        public string teeth_31 { get; set; }
        public string teeth_32 { get; set; }
        public string teeth_33 { get; set; }
        public string teeth_34 { get; set; }
        public string teeth_35 { get; set; }
        public string teeth_36 { get; set; }
        public string teeth_37 { get; set; }
        public string teeth_38 { get; set; }
        public string teeth_41 { get; set; }
        public string teeth_42 { get; set; }
        public string teeth_43 { get; set; }
        public string teeth_44 { get; set; }
        public string teeth_45 { get; set; }
        public string teeth_46 { get; set; }
        public string teeth_47 { get; set; }
        public string teeth_48 { get; set; }
        public string teeth_51 { get; set; }
        public string teeth_52 { get; set; }
        public string teeth_53 { get; set; }
        public string teeth_54 { get; set; }
        public string teeth_55 { get; set; }
        public string teeth_56 { get; set; }
        public string teeth_57 { get; set; }
        public string teeth_58 { get; set; }
        public string teeth_61 { get; set; }
        public string teeth_62 { get; set; }
        public string teeth_63 { get; set; }
        public string teeth_64 { get; set; }
        public string teeth_65 { get; set; }
        public string teeth_66 { get; set; }
        public string teeth_67 { get; set; }
        public string teeth_68 { get; set; }
        public string teeth_71 { get; set; }
        public string teeth_72 { get; set; }
        public string teeth_73 { get; set; }
        public string teeth_74 { get; set; }
        public string teeth_75 { get; set; }
        public string teeth_76 { get; set; }
        public string teeth_77 { get; set; }
        public string teeth_78 { get; set; }
        public string teeth_81 { get; set; }
        public string teeth_82 { get; set; }
        public string teeth_83 { get; set; }
        public string teeth_84 { get; set; }
        public string teeth_85 { get; set; }
        public string teeth_86 { get; set; }
        public string teeth_87 { get; set; }
        public string teeth_88 { get; set; }

    }

    public class DentalInformationInsert_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class DentalInformationUpdate_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class DentalInformationSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class DentalInformationDelete_dt
    {
        public string mrdno { get; set; }
    }
}