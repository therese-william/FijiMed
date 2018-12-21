using System.Collections.Generic;

namespace FijiMed.Data.Entities
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public ICollection<UserRolePermission> UserRolePermissions { get; set; }
    }
}
