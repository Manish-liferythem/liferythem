// <auto-generated />
using In.ProjectEKA.HipService.Consent.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace In.ProjectEKA.HipService.Consent.Database.Migrations
{
    [DbContext(typeof(ConsentContext))]
    [Migration("20200403080416_addConsentManagerIdenitifier")]
    partial class addConsentManagerIdenitifier
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("In.ProjectEKA.HipService.Consent.Model.Consent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConsentArtefact")
                        .HasColumnType("text");

                    b.Property<string>("ConsentArtefactId")
                        .HasColumnType("text");

                    b.Property<string>("ConsentManagerId")
                        .HasColumnType("text");

                    b.Property<string>("Signature")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ConsentArtefactId")
                        .IsUnique();

                    b.ToTable("ConsentArtefact");
                });
#pragma warning restore 612, 618
        }
    }
}
