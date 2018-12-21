using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FijiMed.Data
{
    public class FijiMedSeeder
    {
        private readonly FijiMedContext _ctx;
        private readonly IHostingEnvironment _hosting;

        public FijiMedSeeder(FijiMedContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();
            if(!_ctx.UserRoles.Any())
            {
                _ctx.UserRoles.Add(new Entities.UserRole()
                {
                    UserRoleName="Administration"                    
                });
            }
            if(!_ctx.Users.Any())
            {
                _ctx.Users.Add(new Entities.User()
                {
                    FirstName = "admin",
                    LastName = "",
                    Password="admin123",
                    Username="admin",
                    UserRoleId=1
                });
            }
            _ctx.SaveChanges();
        }
    }
}
