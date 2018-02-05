using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Entities;

namespace Veloso.Deivid.Infra.Persistence.Map
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            ToTable("Client");

            HasKey(x => x.Id);

            Property(x => x.SocialCode)
                .HasMaxLength(14)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            Property(x => x.FullName)
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.Email)
             .HasMaxLength(200)
             .IsRequired();

            Property(x => x.Telephone)
             .HasMaxLength(11)
             .IsRequired();

            Property(x => x.Disabled)
             .IsOptional();

            Property(x => x.DtCriated)
           .IsRequired();

            Property(x => x.DtUpdated)
           .IsOptional();

        }
    }
}
