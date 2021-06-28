using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationUserIdentity : IdentityUser
    {
        public string UserImg { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int UId { get; set; }
    }
    public class ApplicationUserStore : UserStore<ApplicationUserIdentity>
    {
        public ApplicationUserStore() : base(new ApplicationDBContext())
        {

        }
        public ApplicationUserStore(DbContext db) : base(db)
        {

        }
    }
    public class ApplicationRoleManager : RoleManager<IdentityRole>
    {
        public ApplicationRoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDBContext()))
        {

        }
        public ApplicationRoleManager(DbContext db)
            : base(new RoleStore<IdentityRole>(db))
        {

        }
    }
    public class ApplicationUserManager : UserManager<ApplicationUserIdentity>
    {
        public ApplicationUserManager() : base(new ApplicationUserStore())
        {

        }
        public ApplicationUserManager(DbContext db) : base(new ApplicationUserStore(db))
        {

        }
    }


    public class ApplicationDBContext : IdentityDbContext<ApplicationUserIdentity>
    {

        public ApplicationDBContext() :
            base("name=DbConnection")
        {

        }
        public virtual DbSet<Film> Films { set; get; } 
        public virtual DbSet<Certificate> Certificates { set; get; } 
        public virtual DbSet<Director> Directors { set; get; } 
        public virtual DbSet<Genre> Genres { set; get; }
        public virtual DbSet<Language> Languages { set; get; }
        public virtual DbSet<Country> Countries { set; get; }
        public virtual DbSet<Cast> Casts { set; get; }
        public virtual DbSet<Actor> actor { set; get; }

    }
}