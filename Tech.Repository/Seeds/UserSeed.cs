using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.Core.Concrete;

namespace Tech.Repository.Seeds
{
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Email = "emre11@gmail.com", Password = "123456", ConfirmPassword = "123456", CreateDate = DateTime.Now },
                new User { Id = 2, Email = "ahmet@gmail.com", Password = "123456", ConfirmPassword = "123456", CreateDate = DateTime.Now });
        }
    }
}
