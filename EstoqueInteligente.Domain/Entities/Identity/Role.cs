using Microsoft.AspNetCore.Identity;

namespace EstoqueInteligente.Domain.Entities.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
