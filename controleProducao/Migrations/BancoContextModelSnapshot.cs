﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using controleProducao.Data;

namespace controleProducao.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("controleProducao.Models.ControleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Maquina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observação")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdemProducao")
                        .HasColumnType("int");

                    b.Property<string>("Produto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadePerdida")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeProduzida")
                        .HasColumnType("int");

                    b.Property<string>("Tarefa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TempoMinutos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Controle");
                });
#pragma warning restore 612, 618
        }
    }
}
