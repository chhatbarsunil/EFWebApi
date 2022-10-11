using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFWebApi.Models;

#nullable disable

namespace EFWebApi.Context
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
        {
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=127.0.0.1;User ID=root;Database=test");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.Property(e => e.EmpId)
                    .HasColumnType("int(11)")
                    .HasColumnName("empId");

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasColumnName("dept");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CardCvc)
                    .HasColumnType("int(5)")
                    .HasColumnName("card_cvc");

                entity.Property(e => e.CardExpMonth)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("card_exp_month");

                entity.Property(e => e.CardExpYear)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("card_exp_year");

                entity.Property(e => e.CardNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_num");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("item_number");

                entity.Property(e => e.ItemPrice)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("item_price");

                entity.Property(e => e.ItemPriceCurrency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("item_price_currency")
                    .HasDefaultValueSql("'''usd'''");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.PaidAmount)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("paid_amount");

                entity.Property(e => e.PaidAmountCurrency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("paid_amount_currency");

                entity.Property(e => e.PaymentStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("payment_status");

                entity.Property(e => e.TxnId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("txn_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("firstname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("lastname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
