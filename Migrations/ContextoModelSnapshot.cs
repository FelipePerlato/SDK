// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaConsultas.Models;

#nullable disable

namespace Projeto.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SistemaConsultas.Models.Agenda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("especialidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("hora")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("paciente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("profissional")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("agendamentos");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Especialidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Agendaid")
                        .HasColumnType("integer");

                    b.Property<int?>("Profissionalid")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Agendaid");

                    b.HasIndex("Profissionalid");

                    b.ToTable("especialidades");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Paciente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Agendaid")
                        .HasColumnType("integer");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Agendaid");

                    b.ToTable("pacientes");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Profissional", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Agendaid")
                        .HasColumnType("integer");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("especialidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("registro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Agendaid");

                    b.ToTable("profissionais");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Especialidade", b =>
                {
                    b.HasOne("SistemaConsultas.Models.Agenda", null)
                        .WithMany("especialidades")
                        .HasForeignKey("Agendaid");

                    b.HasOne("SistemaConsultas.Models.Profissional", null)
                        .WithMany("especialidades")
                        .HasForeignKey("Profissionalid");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Paciente", b =>
                {
                    b.HasOne("SistemaConsultas.Models.Agenda", null)
                        .WithMany("pacientes")
                        .HasForeignKey("Agendaid");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Profissional", b =>
                {
                    b.HasOne("SistemaConsultas.Models.Agenda", null)
                        .WithMany("profissionais")
                        .HasForeignKey("Agendaid");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Agenda", b =>
                {
                    b.Navigation("especialidades");

                    b.Navigation("pacientes");

                    b.Navigation("profissionais");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Profissional", b =>
                {
                    b.Navigation("especialidades");
                });
#pragma warning restore 612, 618
        }
    }
}
