using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Who_wants_to_be_a_millionaire_show.Models
{
    public partial class QuEntities : DbContext
    {
        public QuEntities()
        {
        }

        public QuEntities(DbContextOptions<QuEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => e.IdAnswer);

                entity.Property(e => e.IdAnswer).HasColumnName("ID_Answer");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.QuestionId).HasColumnName("Question_ID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Answer");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.IdQuestion);

                entity.Property(e => e.IdQuestion).HasColumnName("ID_Question");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");
            });
        }
    }
}
