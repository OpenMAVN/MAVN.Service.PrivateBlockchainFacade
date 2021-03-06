﻿// <auto-generated />
using System;
using MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Migrations
{
    [DbContext(typeof(PbfContext))]
    partial class PbfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("private_blockchain_facade")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.BonusRewardDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .HasColumnName("deduplication_key")
                        .HasColumnType("text");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("bonus_reward_deduplication_log");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.OperationDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .HasColumnName("deduplication_key")
                        .HasColumnType("text");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("operation_deduplication_log");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.TransferDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .HasColumnName("deduplication_key")
                        .HasColumnType("text");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("transfer_deduplication_log");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.WalletLinkingDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .HasColumnName("deduplication_key")
                        .HasColumnType("text");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("wallet_linking_deduplication_log");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.NonceCounterEntity", b =>
                {
                    b.Property<string>("MasterWalletAddress")
                        .HasColumnName("master_wallet_address")
                        .HasColumnType("text");

                    b.Property<long>("CounterValue")
                        .HasColumnName("counter_value")
                        .HasColumnType("bigint");

                    b.HasKey("MasterWalletAddress");

                    b.ToTable("nonce_counters");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.OperationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("ContextJson")
                        .IsRequired()
                        .HasColumnName("context_json")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<string>("MasterWalletAddress")
                        .IsRequired()
                        .HasColumnName("master_wallet_address")
                        .HasColumnType("text");

                    b.Property<long>("Nonce")
                        .HasColumnName("nonce")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MasterWalletAddress");

                    b.HasIndex("Status");

                    b.HasIndex("Timestamp");

                    b.HasIndex("TransactionHash")
                        .IsUnique();

                    b.HasIndex("Type");

                    b.HasIndex("CustomerId", "Type", "Status");

                    b.HasIndex("MasterWalletAddress", "Type", "Status");

                    b.ToTable("operations");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.OperationRequestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("ContextJson")
                        .IsRequired()
                        .HasColumnName("context_json")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id")
                        .HasColumnType("text");

                    b.Property<string>("MasterWalletAddress")
                        .IsRequired()
                        .HasColumnName("master_wallet_address")
                        .HasColumnType("text");

                    b.Property<long>("Nonce")
                        .HasColumnName("nonce")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Timestamp");

                    b.ToTable("operation_requests");
                });

            modelBuilder.Entity("MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.WalletOwnerEntity", b =>
                {
                    b.Property<string>("OwnerId")
                        .HasColumnName("owner_id")
                        .HasColumnType("text");

                    b.Property<string>("WalletId")
                        .IsRequired()
                        .HasColumnName("wallet_id")
                        .HasColumnType("text");

                    b.HasKey("OwnerId");

                    b.HasIndex("WalletId")
                        .IsUnique();

                    b.ToTable("wallet_owners");
                });
#pragma warning restore 612, 618
        }
    }
}
