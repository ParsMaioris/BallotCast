﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BallotCast.Migrations
{
    [DbContext(typeof(ReferendumContext))]
    partial class ReferendumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("OptionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ReferendumResultId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReferendumResultId");

                    b.ToTable("OptionResult");
                });

            modelBuilder.Entity("Paragraph", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("ReferendumId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReferendumId");

                    b.ToTable("Paragraph");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This policy aims to address climate change by reducing carbon emissions.",
                            ReferendumId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "The policy includes measures such as promoting renewable energy sources.",
                            ReferendumId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "The reform aims to equip students with essential skills for the future job market.",
                            ReferendumId = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Coding classes will be mandatory for all high school students.",
                            ReferendumId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "The healthcare improvements include free healthcare services for all citizens.",
                            ReferendumId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "The plan includes increasing funding for hospitals and clinics.",
                            ReferendumId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "The new transport infrastructure plan aims to reduce traffic congestion.",
                            ReferendumId = 4
                        },
                        new
                        {
                            Id = 8,
                            Content = "The plan includes new bus and train routes to improve public transport.",
                            ReferendumId = 4
                        },
                        new
                        {
                            Id = 9,
                            Content = "The tax reform proposal aims to reduce the tax burden on middle-class families.",
                            ReferendumId = 5
                        },
                        new
                        {
                            Id = 10,
                            Content = "The plan includes reducing income tax rates and increasing tax credits.",
                            ReferendumId = 5
                        },
                        new
                        {
                            Id = 11,
                            Content = "The initiative aims to increase investment in renewable energy sources.",
                            ReferendumId = 6
                        },
                        new
                        {
                            Id = 12,
                            Content = "The plan includes building new solar and wind power plants.",
                            ReferendumId = 6
                        });
                });

            modelBuilder.Entity("Referendum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ResultId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ResultId");

                    b.ToTable("Referendums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1870),
                            Question = "Do you support the new environmental policy to reduce carbon emissions by 40% by 2030?",
                            ResultId = 1,
                            Status = 1,
                            Title = "Environmental Policy"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1870),
                            Question = "Do you support the new education reform to introduce coding classes in all high schools?",
                            ResultId = 2,
                            Status = 0,
                            Title = "Education Reform"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880),
                            Question = "Do you support the proposed improvements to the healthcare system to provide free healthcare to all citizens?",
                            ResultId = 3,
                            Status = 1,
                            Title = "Healthcare Improvement"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880),
                            Question = "Do you support the plan to develop new public transport infrastructure, including new bus and train routes?",
                            ResultId = 4,
                            Status = 0,
                            Title = "Transport Infrastructure"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880),
                            Question = "Do you support the proposed tax reform to reduce income tax rates for middle-class families?",
                            ResultId = 5,
                            Status = 0,
                            Title = "Tax Reform"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1880),
                            Question = "Do you support the initiative to increase investment in renewable energy sources such as solar and wind power?",
                            ResultId = 6,
                            Status = 1,
                            Title = "Renewable Energy"
                        });
                });

            modelBuilder.Entity("ReferendumOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OptionText")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("ReferendumId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReferendumId");

                    b.ToTable("ReferendumOption");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OptionText = "Yes",
                            ReferendumId = 1,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 2,
                            OptionText = "No",
                            ReferendumId = 1,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 3,
                            OptionText = "Yes",
                            ReferendumId = 2,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 4,
                            OptionText = "No",
                            ReferendumId = 2,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 5,
                            OptionText = "Yes",
                            ReferendumId = 3,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 6,
                            OptionText = "No",
                            ReferendumId = 3,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 7,
                            OptionText = "Yes",
                            ReferendumId = 4,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 8,
                            OptionText = "No",
                            ReferendumId = 4,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 9,
                            OptionText = "Yes",
                            ReferendumId = 5,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 10,
                            OptionText = "No",
                            ReferendumId = 5,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 11,
                            OptionText = "Yes",
                            ReferendumId = 6,
                            VoteCount = 0
                        },
                        new
                        {
                            Id = 12,
                            OptionText = "No",
                            ReferendumId = 6,
                            VoteCount = 0
                        });
                });

            modelBuilder.Entity("ReferendumResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ResultDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReferendumResult");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ResultDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1800)
                        },
                        new
                        {
                            Id = 2,
                            ResultDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810)
                        },
                        new
                        {
                            Id = 3,
                            ResultDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810)
                        },
                        new
                        {
                            Id = 4,
                            ResultDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810)
                        },
                        new
                        {
                            Id = 5,
                            ResultDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810)
                        },
                        new
                        {
                            Id = 6,
                            ResultDate = new DateTime(2024, 7, 18, 6, 4, 59, 277, DateTimeKind.Utc).AddTicks(1810)
                        });
                });

            modelBuilder.Entity("OptionResult", b =>
                {
                    b.HasOne("ReferendumResult", "ReferendumResult")
                        .WithMany("OptionResults")
                        .HasForeignKey("ReferendumResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReferendumResult");
                });

            modelBuilder.Entity("Paragraph", b =>
                {
                    b.HasOne("Referendum", "Referendum")
                        .WithMany("Paragraphs")
                        .HasForeignKey("ReferendumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Referendum");
                });

            modelBuilder.Entity("Referendum", b =>
                {
                    b.HasOne("ReferendumResult", "Result")
                        .WithMany()
                        .HasForeignKey("ResultId");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("ReferendumOption", b =>
                {
                    b.HasOne("Referendum", "Referendum")
                        .WithMany("Options")
                        .HasForeignKey("ReferendumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Referendum");
                });

            modelBuilder.Entity("Referendum", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("Paragraphs");
                });

            modelBuilder.Entity("ReferendumResult", b =>
                {
                    b.Navigation("OptionResults");
                });
#pragma warning restore 612, 618
        }
    }
}
