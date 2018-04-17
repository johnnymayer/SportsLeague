using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SportsLeague.Models;

namespace SportsLeague.Migrations
{
    [DbContext(typeof(SportsLeagueDbContext))]
    [Migration("20180417165349_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SportsLeague.Models.Division", b =>
                {
                    b.Property<int>("divisionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("divisionDescription");

                    b.Property<int?>("divisionId1");

                    b.Property<string>("divisionName");

                    b.Property<string>("divisionSkill");

                    b.Property<int>("maxTeamNumber");

                    b.HasKey("divisionId");

                    b.HasIndex("divisionId1");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("SportsLeague.Models.Player", b =>
                {
                    b.Property<int>("playerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("captain");

                    b.Property<string>("playerName");

                    b.Property<int>("teamId");

                    b.HasKey("playerId");

                    b.HasIndex("teamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SportsLeague.Models.Team", b =>
                {
                    b.Property<int>("teamId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("divisionId");

                    b.Property<string>("teamName");

                    b.HasKey("teamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SportsLeague.Models.Division", b =>
                {
                    b.HasOne("SportsLeague.Models.Division")
                        .WithMany("Divisions")
                        .HasForeignKey("divisionId1");
                });

            modelBuilder.Entity("SportsLeague.Models.Player", b =>
                {
                    b.HasOne("SportsLeague.Models.Team")
                        .WithMany("Players")
                        .HasForeignKey("teamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
