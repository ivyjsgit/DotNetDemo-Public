﻿// <auto-generated />
using System;
using DotNetDemo.Enities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetDemo.Migrations
{
    [DbContext(typeof(DBcontext))]
    partial class DBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("DotNetDemo.Enities.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("firstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
