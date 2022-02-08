namespace TaxiBack.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TelephonNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsDriver { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
