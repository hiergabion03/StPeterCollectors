﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace StPeterCollectors.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("StPeterCollectors.Models.sp_collectors_main", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("aging")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("balance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("cbi")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("coll_advance")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("coll_due")
                        .HasColumnType("TEXT");

                    b.Property<string>("collector_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("contract_no")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("due_date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("effectivity_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ins")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("inst_no")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("or_date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("or_no")
                        .HasColumnType("INTEGER");

                    b.Property<string>("plan_holder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("quota_comm")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("quota_ncomm")
                        .HasColumnType("TEXT");

                    b.Property<string>("tax")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("sp_collectors_main");
                });

            modelBuilder.Entity("StPeterCollectors.Models.sp_total_all", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("account_total")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("adv_collection_total")
                        .HasColumnType("TEXT");

                    b.Property<int>("collected_total")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("collection_total")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("comm_handl_fee")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ncomm_handl_fee")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("qcomm_total")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("qncomm_total")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("quota_com_total")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("quota_ncom_total")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("total_balance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("total_quota")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("total_tap")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("sp_total_all");
                });
#pragma warning restore 612, 618
        }
    }
}
