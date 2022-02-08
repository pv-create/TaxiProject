namespace back.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public string StartPlace { get; set; } = string.Empty;
        public string FinishPlace { get; set; } = string.Empty;
    }
}
