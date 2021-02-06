using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHomeChildcare.Models
{
    class ReportScreen
    {
        public string ChildName { get; set; }
        public DateTime in_time { get; set; }
        public string GuardianInName { get; set; }
        public DateTime out_time { get; set; }
        public string GuardianOutName { get; set; }
        public string Duration { get; set; }
    }

    class ReportData
    {
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public string in_out { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
        public string timestamp { get; set; }
    }
}
