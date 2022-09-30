using System;
namespace ProjectRegistration.Models
{
    public class TimeRegistration
    {
        public int? Id { get; set; }
        public string Customer { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNumber { get; set; }
        public string Employee { get; set; }
        public DateTime RegistrationTime { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }

    }
}
