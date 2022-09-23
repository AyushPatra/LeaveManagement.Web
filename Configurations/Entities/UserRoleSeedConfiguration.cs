using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3d1df689-b82c-486a-8280-0eb4256fa9e5",
                    UserId = "33d1df689-a82c-486a-8280-0eb4256fa9e6"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3d1df689-b74c-532c-7337-0eb4256fb6e5",
                    UserId = "997f9f48-fa38-421b-947e-bee5092d1ae7"
                }
                );
        }
    }
}