using System.Collections.Generic;

namespace Demo3WinForm.Models
{
    public class Process
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int RouteId { get; set; } 
        public ProcessRoute Route { get; set; } 
        public ICollection<ProcessParameters> ProcessParameters { get; set; } 
    }
}
