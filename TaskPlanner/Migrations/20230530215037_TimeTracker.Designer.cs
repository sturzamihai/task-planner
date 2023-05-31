﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskPlanner.Persistance;

#nullable disable

namespace TaskPlanner.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230530215037_TimeTracker")]
    partial class TimeTracker
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("TaskPlanner.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AsigneeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AsigneeId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TaskPlanner.Entities.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("TaskStatus");
                });

            modelBuilder.Entity("TaskPlanner.Entities.TrackedTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TaskId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("TrackedTimes");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TaskPlanner.Entities.Users.Client", b =>
                {
                    b.HasBaseType("TaskPlanner.Entities.Users.User");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Users.Employee", b =>
                {
                    b.HasBaseType("TaskPlanner.Entities.Users.User");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Users.Manager", b =>
                {
                    b.HasBaseType("TaskPlanner.Entities.Users.User");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Department", b =>
                {
                    b.HasOne("TaskPlanner.Entities.Project", null)
                        .WithMany("Departments")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Project", b =>
                {
                    b.HasOne("TaskPlanner.Entities.Users.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Task", b =>
                {
                    b.HasOne("TaskPlanner.Entities.Users.User", "Asignee")
                        .WithMany()
                        .HasForeignKey("AsigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskPlanner.Entities.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskPlanner.Entities.TaskStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asignee");

                    b.Navigation("Project");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TaskPlanner.Entities.TaskStatus", b =>
                {
                    b.HasOne("TaskPlanner.Entities.Project", null)
                        .WithMany("AllowedStatuses")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("TaskPlanner.Entities.TrackedTime", b =>
                {
                    b.HasOne("TaskPlanner.Entities.Task", null)
                        .WithMany("TimesTracked")
                        .HasForeignKey("TaskId");

                    b.HasOne("TaskPlanner.Entities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Users.User", b =>
                {
                    b.HasOne("TaskPlanner.Entities.Department", null)
                        .WithMany("Members")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Department", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Project", b =>
                {
                    b.Navigation("AllowedStatuses");

                    b.Navigation("Departments");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskPlanner.Entities.Task", b =>
                {
                    b.Navigation("TimesTracked");
                });
#pragma warning restore 612, 618
        }
    }
}