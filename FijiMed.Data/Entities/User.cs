using System.Collections.Generic;

namespace FijiMed.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserUserRole { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; }
    }
}
