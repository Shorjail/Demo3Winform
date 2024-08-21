
namespace Demo3WinForm.Models
{
    public class ProcessParameters
    {
        public int Id { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public int Version { get; set; }
        public int ProcessId { get; set; }

        public Process Process { get; set; }
    }
}
