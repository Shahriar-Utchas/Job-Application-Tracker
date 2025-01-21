using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class JATContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Application> Applications { get; set; }


    }
}
