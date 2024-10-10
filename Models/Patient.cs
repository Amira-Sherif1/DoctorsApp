using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoctorsApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
