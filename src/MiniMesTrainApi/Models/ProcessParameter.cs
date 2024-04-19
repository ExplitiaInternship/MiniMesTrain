namespace MiniMesTrainApi.Models
{
    public class ProcessParameter
    {
        public long Id { get; set; }
        public long ProcessId { get; set; }
        public int ParameterId { get; set; }
        public string Value { get; set; } = null!;

        public Process Process { get; set; } = null!;
        public Parameter Parameter { get; set; } = null!;
    }
}

