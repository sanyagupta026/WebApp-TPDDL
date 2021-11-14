using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApp.Models
{
    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModels")
        {
        }

        public virtual DbSet<AddApp> AddApps { get; set; }
        public virtual DbSet<AppVersion> AppVersions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
