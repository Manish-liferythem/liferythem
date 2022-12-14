// <auto-generated />

namespace In.ProjectEKA.HipService.Link.Database.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Migrations;
    using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

    [DbContext(typeof(LinkPatientContext))]
    [Migration("20200122093241_LinkRequestMigrations")]
    partial class LinkRequestMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("hip_service.Link.Patient.Models.LinkRequest", b =>
                {
                    b.Property<string>("LinkReferenceNumber")
                        .HasColumnType("text");

                    b.Property<string>("ConsentManagerId")
                        .HasColumnType("text");

                    b.Property<string>("ConsentManagerUserId")
                        .HasColumnType("text");

                    b.Property<string>("DateTimeStamp")
                        .HasColumnType("text");

                    b.Property<string>("PatientReferenceNumber")
                        .HasColumnType("text");

                    b.HasKey("LinkReferenceNumber");

                    b.ToTable("LinkRequest");
                });

            modelBuilder.Entity("hip_service.Link.Patient.Models.LinkedCareContext", b =>
                {
                    b.Property<string>("CareContextNumber")
                        .HasColumnType("text");

                    b.Property<string>("LinkReferenceNumber")
                        .HasColumnType("text");

                    b.HasKey("CareContextNumber", "LinkReferenceNumber")
                        .HasName("Id");

                    b.HasIndex("LinkReferenceNumber");

                    b.ToTable("LinkedCareContext");
                });

            modelBuilder.Entity("hip_service.Link.Patient.Models.LinkedCareContext", b =>
                {
                    b.HasOne("hip_service.Link.Patient.Models.LinkRequest", "LinkRequest")
                        .WithMany("CareContexts")
                        .HasForeignKey("LinkReferenceNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
