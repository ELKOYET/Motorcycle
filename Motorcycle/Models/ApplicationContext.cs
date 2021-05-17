using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motorcycle.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
       

        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<Message> Messages { get; set; }


       


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminLogin = "admin";
            string adminPassword = "admin";




            // создаем роли
            RoleModel adminRole = new RoleModel { Id = 1, Name = adminRoleName };
            RoleModel userRole = new RoleModel { Id = 2, Name = userRoleName };

            // и юзера
            UserModel adminUser = new UserModel { Id = 1, Login = adminLogin, Password = adminPassword, RoleId = adminRole.Id, Name = "Кирилл5к" };

            modelBuilder.Entity<RoleModel>().HasData(new RoleModel[] { adminRole, userRole });
            modelBuilder.Entity<UserModel>().HasData(new UserModel[] { adminUser });


            


            // ------------------------------------------------------------------------

           


            base.OnModelCreating(modelBuilder);
        }
    }
}
