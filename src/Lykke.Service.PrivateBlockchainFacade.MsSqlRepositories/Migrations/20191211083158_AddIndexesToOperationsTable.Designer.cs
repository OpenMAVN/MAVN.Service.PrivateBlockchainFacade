﻿// <auto-generated />
using System;
using Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Migrations
{
    [DbContext(typeof(PbfContext))]
    [Migration("20191211083158_AddIndexesToOperationsTable")]
    partial class AddIndexesToOperationsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("private_blockchain_facade")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.BonusRewardDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deduplication_key");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("bonus_reward_deduplication_log");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.OperationDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deduplication_key");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("operation_deduplication_log");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.TransferDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deduplication_key");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("transfer_deduplication_log");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication.WalletLinkingDeduplicationLogEntity", b =>
                {
                    b.Property<string>("DeduplicationKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deduplication_key");

                    b.Property<DateTime>("RetentionStartsAt")
                        .HasColumnName("retention_starts_at");

                    b.HasKey("DeduplicationKey");

                    b.ToTable("wallet_linking_deduplication_log");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.NonceCounterEntity", b =>
                {
                    b.Property<string>("MasterWalletAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("master_wallet_address");

                    b.Property<long>("CounterValue")
                        .HasColumnName("counter_value");

                    b.HasKey("MasterWalletAddress");

                    b.ToTable("nonce_counters");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.OperationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ContextJson")
                        .IsRequired()
                        .HasColumnName("context_json");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<string>("MasterWalletAddress")
                        .IsRequired()
                        .HasColumnName("master_wallet_address");

                    b.Property<long>("Nonce")
                        .HasColumnName("nonce");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("MasterWalletAddress");

                    b.HasIndex("Status");

                    b.HasIndex("Timestamp");

                    b.HasIndex("TransactionHash")
                        .IsUnique()
                        .HasFilter("[transaction_hash] IS NOT NULL");

                    b.HasIndex("Type");

                    b.HasIndex("MasterWalletAddress", "Type", "Status");

                    b.ToTable("operations");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.OperationRequestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ContextJson")
                        .IsRequired()
                        .HasColumnName("context_json");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<string>("MasterWalletAddress")
                        .IsRequired()
                        .HasColumnName("master_wallet_address");

                    b.Property<long>("Nonce")
                        .HasColumnName("nonce");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("Timestamp");

                    b.ToTable("operation_requests");
                });

            modelBuilder.Entity("Lykke.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.WalletOwnerEntity", b =>
                {
                    b.Property<string>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("owner_id");

                    b.Property<string>("WalletId")
                        .IsRequired()
                        .HasColumnName("wallet_id");

                    b.HasKey("OwnerId");

                    b.HasIndex("WalletId")
                        .IsUnique();

                    b.ToTable("wallet_owners");
                });
#pragma warning restore 612, 618
        }
    }
}
