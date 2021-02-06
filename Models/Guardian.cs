namespace GreatHomeChildcare.Models
{
    public class Guardian
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int PinNumber { get; set; }
        public int isAdmin { get; set; }

        //readonly property to populate a single guardian's full name.
        // this is a "Get" only property
        public string DisplayName
        {
            get =>
                $"{LastName}, {FirstName}";
        }
    }
}
