﻿// <auto-generated />
using System;
using GerenciadorCondominios.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorCondominios.DAL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211011170241_criacaoDB")]
    partial class criacaoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorCondominios.BLL.Aluguel", b =>
                {
                    b.Property<int>("AluguelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AluguelId");

                    b.HasIndex("MesId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Apartamento", b =>
                {
                    b.Property<int>("ApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Andar")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoradorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("ProprietarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApartamentoId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Apartamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Funcao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Funcoes");

                    b.HasData(
                        new
                        {
                            Id = "5b81e4be-fd54-4513-b086-021a12892535",
                            ConcurrencyStamp = "78e0d317-2510-4ac0-b0bf-4f330ff4ef7a",
                            Descricao = "Morador do Prédio",
                            Name = "Morador",
                            NormalizedName = "MORADOR"
                        },
                        new
                        {
                            Id = "96380aec-98ae-4eb2-b981-e47db1bf66c1",
                            ConcurrencyStamp = "686d59dd-2a92-4b1a-9ecc-9488459559d5",
                            Descricao = "Síndico do Prédio",
                            Name = "Sindico",
                            NormalizedName = "SINDICO"
                        },
                        new
                        {
                            Id = "33687af1-bae7-47c7-a8fa-630fcdf314b9",
                            ConcurrencyStamp = "7604fda1-ea61-4605-816b-340d0f222326",
                            Descricao = "Administrador do Prédio",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        });
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.HistoricoRecursos", b =>
                {
                    b.Property<int>("HistoricoRecursosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("HistoricoRecursosId");

                    b.HasIndex("MesId");

                    b.ToTable("HistoricoRecursos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Mes", b =>
                {
                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("MesId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Meses");

                    b.HasData(
                        new
                        {
                            MesId = 1,
                            Nome = "Janeiro"
                        },
                        new
                        {
                            MesId = 2,
                            Nome = "Fevereiro"
                        },
                        new
                        {
                            MesId = 3,
                            Nome = "Março"
                        },
                        new
                        {
                            MesId = 4,
                            Nome = "Abril"
                        },
                        new
                        {
                            MesId = 5,
                            Nome = "Maio"
                        },
                        new
                        {
                            MesId = 6,
                            Nome = "Junho"
                        },
                        new
                        {
                            MesId = 7,
                            Nome = "Julho"
                        },
                        new
                        {
                            MesId = 8,
                            Nome = "Agosto"
                        },
                        new
                        {
                            MesId = 9,
                            Nome = "Setembro"
                        },
                        new
                        {
                            MesId = 10,
                            Nome = "Outubro"
                        },
                        new
                        {
                            MesId = 11,
                            Nome = "Novembro"
                        },
                        new
                        {
                            MesId = 12,
                            Nome = "Dezembro"
                        });
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AluguelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PagamentoId");

                    b.HasIndex("AluguelId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServicoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.ServicoPredio", b =>
                {
                    b.Property<int>("ServicoPredioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataExecucao")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("ServicoPredioId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicoPredios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("PrimeiroAcesso")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("VeiculoId");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Aluguel", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Mes", "Mes")
                        .WithMany("Alugueis")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Apartamento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", "Morador")
                        .WithMany("MoradoresApartamentos")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("GerenciadorCondominios.BLL.Usuario", "Proprietario")
                        .WithMany("ProprietariosApartamentos")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Evento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", "Usuario")
                        .WithMany("Eventos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.HistoricoRecursos", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Mes", "Mes")
                        .WithMany("HistoricoRecursos")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Pagamento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Aluguel", "Aluguel")
                        .WithMany("Pagamentos")
                        .HasForeignKey("AluguelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorCondominios.BLL.Usuario", "Usuario")
                        .WithMany("Pagamentos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Servico", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", "Usuario")
                        .WithMany("Servicos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.ServicoPredio", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Servico", "Servico")
                        .WithMany("ServicoPredios")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Veiculo", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", "Usuario")
                        .WithMany("Veiculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorCondominios.BLL.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
