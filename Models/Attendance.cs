namespace GreatHomeChildcare.Models
{
    class Attendance
    {
        int id { get; set; }
        int child_id { get; set; }
        int guardian_id { get; set; }
        public string in_out { get; set; }
        public string timestamp { get; set; }
    }
}
