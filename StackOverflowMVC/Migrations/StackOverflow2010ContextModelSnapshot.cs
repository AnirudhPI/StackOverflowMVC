﻿using System;
using StackOverflowMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;

#nullable disable

namespace StackOverflowMVC.Migrations
{
    public class StackOverflow2010ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StackOverflowLikeWeb.Models.Badge", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("Date")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("PostId")
                    .HasColumnType("int");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("Name");

                b.HasIndex("PostId");

                b.ToTable("Badges");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.Post", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int?>("AcceptedAnswerId")
                    .HasColumnType("int");

                b.Property<int?>("AnswerCount")
                    .HasColumnType("int");

                b.Property<string>("Body")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.Property<DateTime?>("ClosedDate")
                    .HasColumnType("datetime2");

                b.Property<int?>("CommentCount")
                    .HasColumnType("int");

                b.Property<DateTime?>("CommunityOwnedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<int?>("FavoriteCount")
                    .HasColumnType("int");

                b.Property<DateTime>("LastActivityDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("LastEditDate")
                    .HasColumnType("datetime2");

                b.Property<string>("LastEditorDisplayName")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("LastEditorUserId")
                    .HasColumnType("int");

                b.Property<int?>("OwnerUserId")
                    .HasColumnType("int");

                b.Property<int?>("ParentId")
                    .HasColumnType("int");

                b.Property<int>("PostTypeId")
                    .HasColumnType("int");

                b.Property<int>("Score")
                    .HasColumnType("int");

                b.Property<string>("Tags")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("ViewCount")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("Title", "Body", "LastActivityDate");

                b.ToTable("Posts");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("AboutMe")
                    .HasColumnType("nvarchar(450)");

                b.Property<int?>("AccountId")
                    .HasColumnType("int");

                b.Property<int?>("Age")
                    .HasColumnType("int");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("DownVotes")
                    .HasColumnType("int");

                b.Property<string>("EmailHash")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("LastAccessDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Location")
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("PostId")
                    .HasColumnType("int");

                b.Property<int>("Reputation")
                    .HasColumnType("int");

                b.Property<int>("UpVotes")
                    .HasColumnType("int");

                b.Property<int>("Views")
                    .HasColumnType("int");

                b.Property<string>("WebsiteUrl")
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("PostId");

                b.HasIndex("Id", "AboutMe", "DisplayName", "Location", "WebsiteUrl");

                b.ToTable("Users");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.Vote", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int?>("BountyAmount")
                    .HasColumnType("int");

                b.Property<DateTime>("CreationDate")
                    .HasColumnType("datetime2");

                b.Property<int>("PostId")
                    .HasColumnType("int");

                b.Property<int?>("UserId")
                    .HasColumnType("int");

                b.Property<int>("VoteTypeId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("CreationDate");

                b.HasIndex("PostId");

                b.ToTable("Votes");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.Badge", b =>
            {
                b.HasOne("StackOverflowLikeWeb.Models.Post", "Post")
                    .WithMany("Badges")
                    .HasForeignKey("PostId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Post");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.User", b =>
            {
                b.HasOne("StackOverflowLikeWeb.Models.Post", "Post")
                    .WithMany("Users")
                    .HasForeignKey("PostId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Post");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.Vote", b =>
            {
                b.HasOne("StackOverflowLikeWeb.Models.Post", "Post")
                    .WithMany("Votes")
                    .HasForeignKey("PostId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Post");
            });

            modelBuilder.Entity("StackOverflowLikeWeb.Models.Post", b =>
            {
                b.Navigation("Badges");

                b.Navigation("Users");

                b.Navigation("Votes");
            });
#pragma warning restore 612, 618
        }
    }
}
