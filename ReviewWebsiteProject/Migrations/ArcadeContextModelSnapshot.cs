﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewWebsiteProject;

namespace ReviewWebsiteProject.Migrations
{
    [DbContext(typeof(ArcadeContext))]
    partial class ArcadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewWebsiteProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Yellow fruit-eating monster enjoys cherries but not ghosts",
                            Image = "/img/pacman.jpg",
                            Name = "Pac-Man"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Save the Realms from certain doom",
                            Image = "/img/GauntletLegends.png",
                            Name = "Gauntlet Legends"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dig underground and defeat enemies in a maze",
                            Image = "/img/digdug.png",
                            Name = "DigDug"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Italian plumber battles evil turtles to save the princess",
                            Image = "/img/supermariobros.png",
                            Name = "Super Mario"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Battle to the death in this blood fighting game",
                            Image = "/img/mortalkombat.png",
                            Name = "Mortal Kombat"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Insane frog attempts to cross new york style traffic",
                            Image = "/img/frogger.png",
                            Name = "Frogger"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Attractive hero saves the world from evil dictator",
                            Image = "/img/timecrisis.png",
                            Name = "Time Crisis"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Defeat Aliens that have escaped from Area 51",
                            Image = "/img/area51.png",
                            Name = "Area 51"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Racing game with awesome stunt tracks",
                            Image = "/img/sanfranciscorush.png",
                            Name = "San Francisco Rush"
                        });
                });

            modelBuilder.Entity("ReviewWebsiteProject.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I Love this game. I feel like I can now conquer the world. But i'm still scared of ghosts.",
                            Name = "Tom",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "These pac-man are so cute!!. I wondered though if they'll ever get full.",
                            Name = "Dan",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "This game really brought me back to my past life as a medieval serf taking over my fiefdom! ",
                            Name = "Ghassan",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Beware of this game. You will have nightmares for the next year. Play this game with caution.",
                            Name = "Eric",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "This game just makes me want to sing, \"Digdug, digidigidug, digdug, digidigidug.\"",
                            Name = "Jen",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "This game has inspired me to dig to China. I really think I can make it.",
                            Name = "Andy",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("ReviewWebsiteProject.Models.Review", b =>
                {
                    b.HasOne("ReviewWebsiteProject.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
