using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingWiki_DataAccess.Fluentconfig
{
    public class FluentBookDetailConfig : IEntityTypeConfiguration<Fluent_BookDetail>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookDetail> modelBuilder)
        {
            // Table name
            modelBuilder.ToTable("Fluent_BookDetails");

            // Column names
            modelBuilder.Property(u => u.NumberOfChapters).HasColumnName("NoOfChapters");

            // Primary key
            modelBuilder.HasKey(u => u.BookDetail_Id);

            // Other validations
            modelBuilder.Property(u => u.NumberOfChapters).IsRequired();

            // Relations
            // One-to-One relationship between Book and BookDetail
            modelBuilder.HasOne(b => b.Book)
                .WithOne(b => b.BookDetail)
                .HasForeignKey<Fluent_BookDetail>(b => b.Book_Id);
        }
    }
}
