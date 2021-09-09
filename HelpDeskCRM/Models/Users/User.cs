
namespace HelpDeskTask.Models.Users
{
    public class User : Base
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string stringSource { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string LastDirectoryUpdate { get; set; }
        public string UserImage { get; set; }
        public string InsertDate { get; set; }
        public string InsertUserId { get; set; }
        public string UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
        public string IsActive { get; set; }
        public string PassPHP { get; set; }

        public Identity identity { get; set; }

    }
}
