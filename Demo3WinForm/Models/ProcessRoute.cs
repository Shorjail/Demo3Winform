using System.Collections.Generic;

namespace Demo3WinForm.Models
{
    public class ProcessRoute
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public int ProductId { get; set; } 
        public virtual Product Product { get; set; } 
        public virtual ICollection<Process> Processes { get; set; }
    }
}
