using System.ComponentModel.DataAnnotations;

namespace Jwt
{
    public class Permissions
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<RolesPermission> RolePermissions { get; set; }
    }
}
