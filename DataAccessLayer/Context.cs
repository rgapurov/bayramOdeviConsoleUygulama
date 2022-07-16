using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context: DbContext
    {
        public DbSet<Accaunt> accaunts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
    }
}
