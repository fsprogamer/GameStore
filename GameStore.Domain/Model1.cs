namespace GameStore.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GameStore;Integrated Security=True")
        {
        }

        public virtual DbSet<Games> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>();
        }
    }
}
