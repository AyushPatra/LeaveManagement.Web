using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "33d1df689-a82c-486a-8280-0eb4256fa9e6",
                    Email = "patra@gmail.com",
                    NormalizedEmail = "PATRA@GMAIL.COM",
                    NormalizedUserName = "PATRA@GMAIL.COM",
                    UserName = "patra@gmail.com",
                    Firstname = "Ayush",
                    Lastname = "Patra",
                    PasswordHash = hasher.HashPassword(null, "Qwe12#"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "997f9f48-fa38-421b-947e-bee5092d1ae7",
                    Email = "ayush@gmail.com",
                    NormalizedEmail = "AYUSH@GMAIL.COM",
                    NormalizedUserName = "AYUSH@GMAIL.COM",
                    UserName = "ayush@gmail.com",
                    Firstname = "Ayush",
                    Lastname = "Patra",
                    PasswordHash = hasher.HashPassword(null, "Qwe12#"),
                    EmailConfirmed = true
                }
                );
        }
    }
}