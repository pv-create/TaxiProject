namespace back.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CarNumber { get; set; } = string.Empty;
        public string TelephonNumber { get; set; } = string.Empty;
        public List<Purchase> purchases { get; set; }
    }
}
