using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Telefonen_Ukazatel.Models
{
    public class Telefonen_UkazatelDbContext : IdentityDbContext<ApplicationUser>
    {
        public Telefonen_UkazatelDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Article> Articles { get; set; }

        public static Telefonen_UkazatelDbContext Create()
        {
            return new Telefonen_UkazatelDbContext();
        }
    }
}