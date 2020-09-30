using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models
{
  public  class DistrictPatientData
    {

        public class Datum
        {
            public string id { get; set; }
            public string name { get; set; }
            public string age { get; set; }
            public string district { get; set; }
            public string contact { get; set; }
            public string gender { get; set; }
            public string diagnosisDate { get; set; }
            public string patientType { get; set; }
            public int socialEconomicAssessment { get; set; }
            public string addedBy { get; set; }
        }

        public class Districtpatient
        {
            public string status { get; set; }
            public string message { get; set; }
            public List<Datum> data { get; set; }
        }
    }
}
