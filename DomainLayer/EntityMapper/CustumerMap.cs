using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class CustumerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_CUSTUMER_ID");

            builder.Property(c => c.Id).ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("INT");

            builder.Property(c => c.CustomerName)
                .HasColumnName("CUSTOMER_NAME")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(c => c.PurchasesProduct)
                .HasColumnName("PURCHASED_PRODUCT")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

            builder.Property(c => c.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(c => c.CreateDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(c => c.ModifiedDate)
                .HasColumnName("MODIFIED_DATE")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(c => c.IsActive)
                .HasColumnName("IS_ACTIVE")
                .HasColumnType("BIT")
                .IsRequired();
        }
    }
}
