﻿// <auto-generated />
using JeffSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JeffSite.Migrations
{
    [DbContext(typeof(JeffContext))]
    partial class JeffContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JeffSite.Models.User", b =>
                {
                    b.Property<string>("user")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("pass")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("user");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}