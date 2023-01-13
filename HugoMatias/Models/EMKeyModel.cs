namespace HugoMatias.Models
{
    public class EMKeyModel
    {
        public List<int> Numbers { get; set; } = new();
        public List<int> Stars { get; set; } = new();
        public double Fee { get; set; }
        public string Prize { get; set; }
    }
}
