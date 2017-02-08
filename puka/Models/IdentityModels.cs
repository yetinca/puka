using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using puka.Models.DBModels;

namespace puka.Models
{
    public class IdentityModels
    {
    }

    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
           : base("PukaDB")
        {
        }

        public DbSet<AuthorsDBModel> Authors { get; set; } // to jest dla konkretnej tabeli
        public DbSet<BranchTypesDBModels> BranchTypes { get; set; }
        public DbSet<ReportsDBModels> Reports { get; set; }
        public DbSet<ReportsContentDBModels> ReportsContent { get; set; }
        public DbSet<TagRepAllocationDBModels> TagRepAllocation { get; set; }
        public DbSet<TagTypesDBModel> TagTypes { get; set; }
        public DbSet<TypesOfRepDBModel> TypesOfRep { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}