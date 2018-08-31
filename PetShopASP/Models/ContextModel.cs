using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShopASP.Models;

namespace PetShopASP.Models
{
    public class ContextModel : DbContext
    {
        public ContextModel(DbContextOptions<ContextModel> options)
            : base(options)
        { }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Especie> Especies { get; set; }

    }
}
