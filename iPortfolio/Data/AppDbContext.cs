using iPortfolio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;

namespace iPortfolio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        //Properties to create in the Database
       public DbSet<Contact> tbl_Contacts { get; set; }
        public DbSet<Education> tbl_Education { get; set; }
        public DbSet<Experiance> tbl_Experiance { get; set; }
        public DbSet<Facts> tbl_Facts { get; set; }
        public DbSet<Skill> tbl_Skill { get; set; }
        public DbSet<Service> tbl_Service { get; set; }
        public DbSet<Profile> tbl_Profile { get; set; }
        public DbSet<SocialNetwork> tbl_SocialNetwork { get; set; }
        public DbSet<Testimonial> tbl_Testimonial { get; set; }
    }
}
