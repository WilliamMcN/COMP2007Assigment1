namespace Assignment1Oct12017COMP2007.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PartyModel : DbContext
    {
        public PartyModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<PLocation> PLocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>()
                .Property(e => e.Message_)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.Party_Type_)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.Address_)
                .IsUnicode(false);

            modelBuilder.Entity<PLocation>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PLocation>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<PLocation>()
                .Property(e => e.ProvinceOrState)
                .IsUnicode(false);

            modelBuilder.Entity<PLocation>()
                .HasMany(e => e.Parties)
                .WithRequired(e => e.PLocation)
                .WillCascadeOnDelete(false);
        }
    }
}
