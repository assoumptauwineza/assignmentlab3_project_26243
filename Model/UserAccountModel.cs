namespace foododering.Model
{
    public sealed class UserAccountModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public string AccountStatus { get; set; } = "Active";
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
