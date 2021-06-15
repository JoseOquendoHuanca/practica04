using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace practica04.Models
{
    public class vercontext : IdentityDbContext
    {

        public DbSet<usuario> usuarios { get; set; }


        public vercontext(DbContextOptions dco) : base(dco)
        {



        }

        internal static object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}