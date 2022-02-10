namespace back.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TelephonNumber { get; set; } = string.Empty;
        public string Password { get; set; }
        public string Email { get; set; } = string.Empty;
        public List<Purchase> purchases { get; set; }
    }
}
