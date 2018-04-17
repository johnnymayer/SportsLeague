using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SportsLeague.Models;

namespace SportsLeague.Migrations
{
    [DbContext(typeof(SportsLeagueDbContext))]
    [Migration("20180417223826_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5");

            modelBuilder.Entity("SportsLeague.Models.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("SkillLevel");

                    b.HasKey("DivisionId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("SportsLeague.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SportsLeague.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DivisionId");

                    b.Property<string>("Name");

                    b.HasKey("TeamId");

                    b.HasIndex("DivisionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SportsLeague.Models.Player", b =>
                {
                    b.HasOne("SportsLeague.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsLeague.Models.Team", b =>
                {
                    b.HasOne("SportsLeague.Models.Division", "Division")
                        .WithMany("Teams")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
