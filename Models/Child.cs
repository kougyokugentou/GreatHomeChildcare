using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHomeChildcare.Models
{
    public class Child
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string address { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public byte[] photo { get; set; }

        //readonly property to populate the found student searchbox.
        // this is a "Get" only property
        public string DisplayName
        {
            get =>
                $"{LastName}, {FirstName} - Child ID: {id}";
        }
    }
}
