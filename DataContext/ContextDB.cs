
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{

    public class ContextDB : DbContext
    {
        public ContextDB() : base(Connection.GetConnection())
        {
        }

        public DbSet<CallInfo> CallInfos { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<CallCategory> CallCategories { get; set; }

    }
}