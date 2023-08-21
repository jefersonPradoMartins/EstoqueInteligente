using Microsoft.AspNetCore.Identity;

namespace EstoqueInteligente.Domain.Entities.Identity
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; } = new User();
      
        public Role Role { get; set; } = new Role();
    }
}
