using Microsoft.AspNetCore.Identity;

namespace EstoqueInteligente.Domain.Entities.Identity
{
    public class User : IdentityUser<int>
    {
        public string Apelido { get; set; } = string.Empty;
        public string Member { get; set; } = "Member";
        public int CodigoOrganizacao { get; set; } 
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
