﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransacaoFinanceira.Infrastructure.Data;

#nullable disable

namespace TransacaoFinanceira.Infrastructure.Migrations
{
    [DbContext(typeof(TransacaoFinanceiraContex))]
    partial class TransacaoFinanceiraContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.33");

            modelBuilder.Entity("TransacaoFinanceira.Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountNumber = "938485762",
                            Balance = 180.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9860),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9869)
                        },
                        new
                        {
                            Id = 2,
                            AccountNumber = "347586970",
                            Balance = 1200.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9870),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9871)
                        },
                        new
                        {
                            Id = 3,
                            AccountNumber = "2147483649",
                            Balance = 0.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9872),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9872)
                        },
                        new
                        {
                            Id = 4,
                            AccountNumber = "675869708",
                            Balance = 4900.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9873),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9873)
                        },
                        new
                        {
                            Id = 5,
                            AccountNumber = "238596054",
                            Balance = 478.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9874),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9874)
                        },
                        new
                        {
                            Id = 6,
                            AccountNumber = "573659065",
                            Balance = 787.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9875),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9875)
                        },
                        new
                        {
                            Id = 7,
                            AccountNumber = "210385733",
                            Balance = 10.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9876),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9877)
                        },
                        new
                        {
                            Id = 8,
                            AccountNumber = "674038564",
                            Balance = 400.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9877),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9878)
                        },
                        new
                        {
                            Id = 9,
                            AccountNumber = "563856300",
                            Balance = 1200.0m,
                            CreatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9878),
                            UpdatedAt = new DateTime(2024, 9, 19, 13, 44, 39, 121, DateTimeKind.Local).AddTicks(9879)
                        });
                });

            modelBuilder.Entity("TransacaoFinanceira.Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountSource")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountTarget")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("AmountTransaction")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountSource = "938485762",
                            AccountTarget = "2147483649",
                            AmountTransaction = 150m,
                            CorrelationId = new Guid("aca0baca-1b4c-495c-b116-247c93339886"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AccountSource = "2147483649",
                            AccountTarget = "210385733",
                            AmountTransaction = 149m,
                            CorrelationId = new Guid("9c04c4ef-d211-470b-9ce8-f73bb05c9b25"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 15, 5, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AccountSource = "347586970",
                            AccountTarget = "238596054",
                            AmountTransaction = 1100m,
                            CorrelationId = new Guid("daec7c40-365d-4431-a458-fd0864d57470"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 15, 29, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AccountSource = "675869708",
                            AccountTarget = "210385733",
                            AmountTransaction = 5300m,
                            CorrelationId = new Guid("712ec524-2732-4fd9-8523-df8d6fb35454"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 17, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AccountSource = "238596054",
                            AccountTarget = "674038564",
                            AmountTransaction = 1489m,
                            CorrelationId = new Guid("fd0ed752-0f11-4ca0-a060-e5a4cb27f285"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 18, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            AccountSource = "573659065",
                            AccountTarget = "563856300",
                            AmountTransaction = 49m,
                            CorrelationId = new Guid("a7893e50-7f9f-4024-b622-c1fb3be7dc2f"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 18, 20, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            AccountSource = "938485762",
                            AccountTarget = "2147483649",
                            AmountTransaction = 44m,
                            CorrelationId = new Guid("9710bf35-c35d-4ad0-b730-7b490b11ddcf"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 19, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            AccountSource = "573659065",
                            AccountTarget = "675869708",
                            AmountTransaction = 150m,
                            CorrelationId = new Guid("f4b87582-4be4-49e5-af15-1af036e4e390"),
                            CreatedAt = new DateTime(2023, 9, 9, 14, 19, 1, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
