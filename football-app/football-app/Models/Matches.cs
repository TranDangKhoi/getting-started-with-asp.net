using System.ComponentModel.DataAnnotations;

namespace football_app.Models
{
    public class Matches
    {
        public int Id { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }

        [DataType(DataType.Date)]
        public DateTime ScheduleDate { get; set; }
    }
}
