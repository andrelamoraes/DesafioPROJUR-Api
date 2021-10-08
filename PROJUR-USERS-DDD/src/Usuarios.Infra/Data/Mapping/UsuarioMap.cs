using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Domain.Entities;

namespace Usuarios.Infra.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Sobrenome)
                .IsRequired()
                .HasColumnName("Sobrenome")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.DataNascimento)
                .IsRequired()
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder.Property(prop => prop.Escolaridade)
                .IsRequired()
                .HasColumnName("Escolaridade")
                .HasColumnType("integer");
        }
    }
}