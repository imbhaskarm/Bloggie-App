using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class AuthDbContext:IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options):base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seed the roles (User.admin,superadmin)

            var adminRoleId = "8f54bf6e-ac63-45cb-a565-1cd61647e66e";
            var superAdminRoleId = "415e0755-aff5-4a1e-9eab-65ad2ea8d08f";
            var userRoleId = "2f1bff2d-7311-4c7b-be28-5605d55ba0b6";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name="Admin",
                    NormalizedName="Admin",
                    Id=adminRoleId,
                    ConcurrencyStamp=adminRoleId
                },
                new IdentityRole
                {
                    Name="SuperAdmin",
                    NormalizedName="SuperAdmin",
                    Id=superAdminRoleId,
                    ConcurrencyStamp=adminRoleId
                },
                new IdentityRole
                {
                    Name="User",
                    NormalizedName="User",
                    Id=userRoleId,
                    ConcurrencyStamp=userRoleId
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            //Seed SuperAdminUser

            var superAdminId = "1374ab7b-c7c6-4efc-ac08-7698d15e9ba9";
            var superAdminUser = new IdentityUser { 
                UserName="superadmin@bloggie.com",
                Email="superadmin@bloggie.com",
                NormalizedEmail="superadmin@bloggie.com".ToUpper(),
                NormalizedUserName= "superadmin@bloggie.com".ToUpper(),
                Id=superAdminId
            };

            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(superAdminUser, "Superadmin@123");
            builder.Entity<IdentityUser>().HasData(superAdminUser);

            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId=adminRoleId,
                    UserId=superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId=superAdminRoleId,
                    UserId=superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId=userRoleId,
                    UserId=superAdminId
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);
        }


    }
}
