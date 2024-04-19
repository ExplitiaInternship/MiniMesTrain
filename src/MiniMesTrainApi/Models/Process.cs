namespace MiniMesTrainApi.Models
{
    public class Process
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; } = null!;
        public long OrderId { get; set; }
        public ProcessStatus Status { get; set; }
        public DateTime DateTime { get; set; }

        public Order Order { get; set; } = null!;
        public ICollection<ProcessParameter> ProcessParameters { get; set; } = null!;
    }
}

