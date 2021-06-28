using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class Db_Context : DbContext 
    {
        public Db_Context(DbContextOptions<Db_Context> options) : base(options)
        {


        }

        public DbSet<Proveedores> Proveedores { get; set; }
    }
}
