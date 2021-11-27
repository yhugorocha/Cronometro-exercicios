﻿// <auto-generated />
using Exercicio.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exercicios.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("CronometroExercicios.API.Model.Atividade", b =>
                {
                    b.Property<int>("AtividadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Descanso")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Duracao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Repeticoes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TempoPreparacao")
                        .HasColumnType("INTEGER");

                    b.HasKey("AtividadeId");

                    b.ToTable("Exercicios");
                });
#pragma warning restore 612, 618
        }
    }
}