﻿using Blog_EC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_EC.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Tabela
            builder.ToTable("User");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Bio);
            builder.Property(x => x.Email);
            builder.Property(x => x.Image);
            builder.Property(x => x.PasswordHash);

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("SLUG")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);
            
            // Índices
            builder.HasIndex(x => x.Slug, "IX_User_Slug")
                .IsUnique();
        }
    }
}
