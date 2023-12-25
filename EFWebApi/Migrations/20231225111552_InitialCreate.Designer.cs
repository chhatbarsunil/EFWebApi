﻿// <auto-generated />
using System;
using EFWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFWebApi.Migrations
{
    [DbContext(typeof(EFWebApiDbContext))]
    [Migration("20231225111552_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("EFWebApi.Models.Efmigrationshistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__efmigrationshistory");
                });

            modelBuilder.Entity("EFWebApi.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("empId");

                    b.Property<string>("Dept")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("dept");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("EmpId")
                        .HasName("PRIMARY");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("EFWebApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("CardCvc")
                        .HasColumnType("int(5)")
                        .HasColumnName("card_cvc");

                    b.Property<string>("CardExpMonth")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("card_exp_month");

                    b.Property<string>("CardExpYear")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("card_exp_year");

                    b.Property<long>("CardNum")
                        .HasColumnType("bigint(20)")
                        .HasColumnName("card_num");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime")
                        .HasColumnName("created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("item_name");

                    b.Property<string>("ItemNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("item_number");

                    b.Property<float>("ItemPrice")
                        .HasColumnType("float(10,2)")
                        .HasColumnName("item_price");

                    b.Property<string>("ItemPriceCurrency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("item_price_currency")
                        .HasDefaultValueSql("'''''''usd'''''''");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("PaidAmount")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("paid_amount");

                    b.Property<string>("PaidAmountCurrency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("paid_amount_currency");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("payment_status");

                    b.Property<string>("TxnId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("txn_id");

                    b.HasKey("Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("EFWebApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address")
                        .HasDefaultValueSql("'''NULL'''");

                    b.Property<string>("Firstname")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstname")
                        .HasDefaultValueSql("'''NULL'''");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastname")
                        .HasDefaultValueSql("'''NULL'''");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password")
                        .HasDefaultValueSql("'''NULL'''");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username")
                        .HasDefaultValueSql("'''NULL'''");

                    b.HasKey("Id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
