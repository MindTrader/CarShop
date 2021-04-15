﻿// <auto-generated />
using CarShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarShop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarShop.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available");

                    b.Property<int>("CategoryID");

                    b.Property<string>("Img");

                    b.Property<bool>("IsFavourite");

                    b.Property<string>("LongDesc");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("ShortDesc");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("CarDb");
                });

            modelBuilder.Entity("CarShop.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Desc");

                    b.HasKey("Id");

                    b.ToTable("CategoryDb");
                });

            modelBuilder.Entity("CarShop.Data.Models.Car", b =>
                {
                    b.HasOne("CarShop.Data.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
