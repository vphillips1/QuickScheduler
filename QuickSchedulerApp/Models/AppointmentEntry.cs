using System.ComponentModel.DataAnnotations;

namespace QuickSchedulerApp.Models
{
    public class AppointmentEntry
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
       
    }
}
