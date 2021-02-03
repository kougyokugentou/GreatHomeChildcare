namespace GreatHomeChildcare.Models
{
    public class Child
    {
        private string displayName;

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string address { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public byte[] photo { get; set; }

        /* Ppopulate a single child's full name.
         * "get" will return Lastname, Fistname if the lastname is not null.
         * otherwise it will return the variable displayName.
         * This is so we can insert "Everyone" into the list
         * of children for the reports form.
         */
        public string DisplayName
        {
            get
            {
                //This is so we can have "everyone" in the list of
                //children in the reports form.
                if (LastName != null)
                    { return $"{LastName}, {FirstName}"; }
                else
                    return displayName;
            }
                
            set
            {
                displayName = value;
            }
        }
    }
}
