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
    public class FluentBookAuthorMapConfig : IEntityTypeConfiguration<Fluent_BookAuthorMap>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookAuthorMap> modelBuilder)
        {
            // Mapping table composite key
            modelBuilder.HasKey(b => new { b.Book_Id, b.Author_Id });
            // Many-to-Many relationship between Author and Book
            modelBuilder.HasOne(z => z.Book)
                .WithMany(z => z.BookAuthorMap)
                .HasForeignKey(z => z.Book_Id);
            modelBuilder.HasOne(z => z.Author)
                .WithMany(z => z.BookAuthorMap)
                .HasForeignKey(z => z.Author_Id);
        }
    }
}
