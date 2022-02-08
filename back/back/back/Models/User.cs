namespace back.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TelephonNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Purchase> purchases { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
