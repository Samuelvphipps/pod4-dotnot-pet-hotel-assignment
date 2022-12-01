﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pet_hotel.Models;

#nullable disable

namespace dotnetbakery.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221201194417_CreatePetTable")]
    partial class CreatePetTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pet_hotel.Pet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("breed")
                        .HasColumnType("integer");

                    b.Property<DateTime>("checkedInAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("color")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("petOwnerId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("pet_hotel.PetOwner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("petCount")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("PetOwners");
                });
#pragma warning restore 612, 618
        }
    }
}
