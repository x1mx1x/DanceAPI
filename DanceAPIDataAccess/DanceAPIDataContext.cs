namespace DanceAPIDataAccess
{
    using System.Data.Entity;
    using DanceAPIDataAccess.Models;

    public partial class DanceAPIDataContext : DbContext
    {
        public DanceAPIDataContext()
            : base("name=dancedb")
        {
        }

        public virtual DbSet<AgeCategory> AgeCategory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CompetitionCatalog> CompetitionCatalog { get; set; }
        public virtual DbSet<Competitor> Competitor { get; set; }
        public virtual DbSet<DanceForm> DanceForm { get; set; }
        public virtual DbSet<DanceGroup> DanceGroup { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentName> DocumentName { get; set; }
        public virtual DbSet<Duets> Duets { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Nomination> Nomination { get; set; }
        public virtual DbSet<Organizer> Organizer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeCategory>()
                .HasMany(e => e.Category)
                .WithRequired(e => e.AgeCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Nomination)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.CompetitionCatalog)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetitionCatalog>()
                .Property(e => e.CompName)
                .IsUnicode(false);

            modelBuilder.Entity<CompetitionCatalog>()
                .Property(e => e.StreetName)
                .IsUnicode(false);

            modelBuilder.Entity<CompetitionCatalog>()
                .HasMany(e => e.Nomination)
                .WithRequired(e => e.CompetitionCatalog)
                .HasForeignKey(e => e.CompId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Competitor>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Competitor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Competitor>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<DanceForm>()
                .Property(e => e.DanceformName)
                .IsUnicode(false);

            modelBuilder.Entity<DanceForm>()
                .HasMany(e => e.Category)
                .WithRequired(e => e.DanceForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanceGroup>()
                .Property(e => e.DanceGroupName)
                .IsFixedLength();

            modelBuilder.Entity<DanceGroup>()
                .HasMany(e => e.Category)
                .WithRequired(e => e.DanceGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.DocSeries)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Competitor)
                .WithRequired(e => e.Document)
                .HasForeignKey(e => e.DocId);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Organizer)
                .WithRequired(e => e.Document)
                .HasForeignKey(e => e.DocId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Trainer)
                .WithRequired(e => e.Document)
                .HasForeignKey(e => e.DocId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentName>()
                .Property(e => e.DocName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentName>()
                .HasMany(e => e.Document)
                .WithRequired(e => e.DocumentName)
                .HasForeignKey(e => e.DocNameId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Duets>()
                .Property(e => e.DuetName)
                .IsUnicode(false);

            modelBuilder.Entity<Duets>()
                .HasMany(e => e.Nomination)
                .WithOptional(e => e.Duets)
                .HasForeignKey(e => e.DuetId);

            modelBuilder.Entity<Groups>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<Groups>()
                .HasMany(e => e.Nomination)
                .WithOptional(e => e.Groups)
                .HasForeignKey(e => e.GroupId);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .HasMany(e => e.CompetitionCatalog)
                .WithRequired(e => e.Organizer)
                .HasForeignKey(e => e.OrgId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);
        }
    }
}
