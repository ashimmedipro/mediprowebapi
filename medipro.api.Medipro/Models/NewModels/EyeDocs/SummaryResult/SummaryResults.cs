using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs.KesId_ClusterNoDetails
{
    public class EducationSummaryResults_dt
    {
        public string education { get; set; }
        public int number { get; set; }
        public double percentage { get; set; }

    }

    public class EthnicitySummaryResults_dt
    {
        public string ethnicity { get; set; }
        public int number { get; set; }
        public double percentage { get; set; }

    }

    public class OccupationSummaryResults_dt
    {
        public string occupation { get; set; }
        public int frequency { get; set; }
        public double percentage { get; set; }

    }

    public class ReligionSummaryResults_dt
    {
        public string religion { get; set; }
        public int number { get; set; }
        public double percentage { get; set; }

    }

    public class HypertensionSummaryResults_dt
    {
        public string category { get; set; }
        public int number { get; set; }
        public double percentage { get; set; }

    }

    public class BmiSummaryResults_dt
    {
        public string bmi_group { get; set; }
        public int frequency { get; set; }
        public double percentage { get; set; }

    }
}