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

        //readonly property to populate a single child's full name.
        // this is a "Get" only property
        public string DisplayName
        {
            get =>
                $"{LastName}, {FirstName}";
        }
    }
}
