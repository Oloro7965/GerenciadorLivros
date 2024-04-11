using GerenciadorLivros.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.intraestructure.Configurations
{
    public class AvaliationConfigurations : IEntityTypeConfiguration<Avaliation>
    {
        public void Configure(EntityTypeBuilder<Avaliation> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasOne(u => u.user)
               .WithMany(u => u.UserAvaliations)
               .HasForeignKey(u => u.UserId)
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.book)
                .WithMany(u => u.Avaliations)
                .HasForeignKey(u => u.BookId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
