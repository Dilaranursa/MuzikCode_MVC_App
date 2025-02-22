using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MuziCodeWepApp.Models
{
    public partial class MuzicCodeDBModel : DbContext
    {
        public MuzicCodeDBModel()
            : base("name=MuzicCodeDBModel")
        {
        }
        public virtual DbSet<ManagerRole> ManagersRol { get; set; } 
        public DbSet<Manager> Manager { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
