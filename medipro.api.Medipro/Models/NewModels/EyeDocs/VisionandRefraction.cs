using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{


    public class VisionandRefractionInsertAll_dt
    {
        public int hospid { get; set; }
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public bool distance_glasses_tick { get; set; }
        public bool near_glasses_tick { get; set; }
        public bool glasses_regularity_tick { get; set; }
        public string pva_distance_od { get; set; }
        public string pv_distance_od { get; set; }
        public string pva_distance_os { get; set; }
        public string pv_distance_os { get; set; }
        public string pva_near_od { get; set; }
        public string pv_near_od { get; set; }
        public string pva_near_os { get; set; }
        public string pv_near_os { get; set; }
        public string spherical_distance_od { get; set; }
        public string spherical_distance_od_value { get; set; }
        public string cylindrical_distance_od { get; set; }
        public string cylindrical_distance_od_value { get; set; }
        public string axis_distance_od { get; set; }
        public string axis_distance_os { get; set; }
        public string spherical_distance_os { get; set; }
        public string spherical_distance_os_value { get; set; }
        public string cylindrical_distance_os { get; set; }
        public string cylindrical_distance_os_value { get; set; }
        public string spherical_near_od { get; set; }
        public string spherical_near_od_value { get; set; }
        public string spherical_near_os { get; set; }
        public string spherical_near_os_value { get; set; }
        public string vanc_distance_od { get; set; }
        public string vanc_distance_os { get; set; }
        public string vanc_near_od { get; set; }
        public string vanc_near_os { get; set; }
        public string pg_spherical_distance_od { get; set; }
        public string pg_spherical_distance_od_value { get; set; }
        public string pg_cylindrical_distance_od { get; set; }
        public string pg_cylindrical_distance_od_value { get; set; }
        public string pg_axis_distance_od { get; set; }
        public string pg_axis_distance_os { get; set; }
        public string pg_spherical_distance_os { get; set; }
        public string pg_spherical_distance_os_value { get; set; }
        public string pg_cylindrical_distance_os { get; set; }
        public string pg_cylindrical_distance_os_value { get; set; }
        public string pg_spherical_near_od { get; set; }
        public string pg_spherical_near_od_value { get; set; }
        public string pg_spherical_near_os { get; set; }
        public string pg_spherical_near_os_value { get; set; }
        public string visacu_preglass_near_od { get; set; }
        public string visacu_preglass_distance_od { get; set; }
        public string visacu_preglass_near_os { get; set; }
        public string visacu_preglass_distance_os { get; set; }
    }

   

    public class VisionandRefractionInsert_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class VisionandRefractionUpdate_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class VisionandRefractionSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class VisionandRefractionDelete_dt
    {
        public string mrdno { get; set; }
    }

   public class Visionlist_dt
    {
        public List<VisionandRefractionInsertAll_dt> Vision { get; set; }
    }

}