﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_HotelABC.Context;

namespace Proyecto_HotelABC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CountRoomServices", b =>
                {
                    b.Property<int>("GuestAccountsPkCount")
                        .HasColumnType("int");

                    b.Property<int>("RequestedServicesPkservice")
                        .HasColumnType("int");

                    b.HasKey("GuestAccountsPkCount", "RequestedServicesPkservice");

                    b.HasIndex("RequestedServicesPkservice");

                    b.ToTable("CountRoomServices");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.Booking", b =>
                {
                    b.Property<int>("IdReservation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AmountPerson")
                        .HasColumnType("int");

                    b.Property<int?>("CountId")
                        .HasColumnType("int");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Suite")
                        .HasColumnType("int");

                    b.HasKey("IdReservation");

                    b.HasIndex("CountId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.Count", b =>
                {
                    b.Property<int>("PkCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FkRole")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PkCount");

                    b.HasIndex("FkRole");

                    b.ToTable("Counts");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Card_Holder")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.Role", b =>
                {
                    b.Property<int>("PkRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PkRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.RoomServices", b =>
                {
                    b.Property<int>("Pkservice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameService")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Pkservice");

                    b.ToTable("RoomServices");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.SuiteNames", b =>
                {
                    b.Property<int>("PkName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameS")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("PkName");

                    b.ToTable("SuiteNames");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.review", b =>
                {
                    b.Property<int>("IdReview")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Namereview")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime");

                    b.HasKey("IdReview");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("CountRoomServices", b =>
                {
                    b.HasOne("Proyecto_HotelABC.Entities.Count", null)
                        .WithMany()
                        .HasForeignKey("GuestAccountsPkCount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_HotelABC.Entities.RoomServices", null)
                        .WithMany()
                        .HasForeignKey("RequestedServicesPkservice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.Booking", b =>
                {
                    b.HasOne("Proyecto_HotelABC.Entities.Count", "User")
                        .WithMany()
                        .HasForeignKey("CountId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Proyecto_HotelABC.Entities.Count", b =>
                {
                    b.HasOne("Proyecto_HotelABC.Entities.Role", "Roles")
                        .WithMany()
                        .HasForeignKey("FkRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
