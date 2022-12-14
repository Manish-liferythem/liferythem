// <auto-generated />
using System;
using In.ProjectEKA.HipService.DataFlow.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace In.ProjectEKA.HipService.DataFlow.Database.Migrations
{
    [DbContext(typeof(DataFlowContext))]
    [Migration("20200226055335_AddHealthInformationTable")]
    partial class AddHealthInformationTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("In.ProjectEKA.HipService.DataFlow.Model.DataFlowRequest", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("text");

                    b.Property<string>("HealthInformationRequest")
                        .HasColumnType("text");

                    b.HasKey("TransactionId");

                    b.ToTable("DataFlowRequest");
                });

            modelBuilder.Entity("In.ProjectEKA.HipService.DataFlow.Model.HealthInformation", b =>
                {
                    b.Property<string>("InformationId")
                        .HasColumnType("text");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.HasKey("InformationId");

                    b.ToTable("HealthInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
