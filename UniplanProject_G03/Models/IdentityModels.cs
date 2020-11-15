using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace UniplanProject_G03.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Nick { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string StudentID { get; set; }
        public string University { get; set; }
        public string Institute { get; set; }
        public string Branch { get; set; }
        public string Year { get; set; }
        public string Motto { get; set; }
        public string Url { get; set; }

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
            : base("UniplansEntities", throwIfV1Schema: false)
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationDbContext>());
        }


        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        //public virtual DbSet<GoalType> GoalTypes { get; set; }
        public virtual DbSet<Planner> Planners { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<MoodTracker> MoodTrackers { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}