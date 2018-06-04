namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Users : DbContext
    {
        public Users()
            : base("name=Users")
        {
        }

        public virtual DbSet<channelNames> channelNames { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<channelNames>()
                .HasMany(e => e.User)
                .WithOptional(e => e.channelNames)
                .HasForeignKey(e => e.chanelNamesId);
        }
    }
}
