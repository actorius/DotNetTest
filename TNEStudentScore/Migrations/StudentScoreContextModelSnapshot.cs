﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TNEStudentScore.Models;

namespace TNEStudentScore.Migrations
{
    [DbContext(typeof(StudentScoreContext))]
    partial class StudentScoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TNEStudentScoreModels.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("UniversityId");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Группа программистов И1",
                            UniversityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Группа историков И1",
                            UniversityId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Группа программистов И2",
                            UniversityId = 1
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Score");

                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Score = 3,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Score = 4,
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Score = 5,
                            StudentId = 1,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 4,
                            Score = 4,
                            StudentId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 5,
                            Score = 3,
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 6,
                            Score = 2,
                            StudentId = 2,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 7,
                            Score = 4,
                            StudentId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 8,
                            Score = 5,
                            StudentId = 3,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 9,
                            Score = 5,
                            StudentId = 4,
                            SubjectId = 3
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BornDate");

                    b.Property<int>("GroupId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BornDate = new DateTime(1989, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Name = "Тукаев Алексей Ерофеевич"
                        },
                        new
                        {
                            Id = 2,
                            BornDate = new DateTime(1985, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Name = "Шихина Вероника Данилевна"
                        },
                        new
                        {
                            Id = 3,
                            BornDate = new DateTime(1988, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Name = "Закруткин Лаврентий Филиппович"
                        },
                        new
                        {
                            Id = 4,
                            BornDate = new DateTime(1988, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Name = "Ермолин Тихон Филимонович"
                        },
                        new
                        {
                            Id = 5,
                            BornDate = new DateTime(1987, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Name = "Хмельнова Эвелина Ираклиевна"
                        },
                        new
                        {
                            Id = 6,
                            BornDate = new DateTime(1986, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Name = "Закруткин Лаврентий Филиппович"
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Subjectds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "История"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Дискретная математика"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Фунциональное программирование"
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.SubjectTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubjectId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectTeacher");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubjectId = 1,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            SubjectId = 2,
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            SubjectId = 3,
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Петров Аввакум Авдеевич"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Новиков Альберт Оскарович"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Богданов Георгий Наумович"
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Институт 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Институт 2"
                        });
                });

            modelBuilder.Entity("TNEStudentScoreModels.Group", b =>
                {
                    b.HasOne("TNEStudentScoreModels.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TNEStudentScoreModels.Mark", b =>
                {
                    b.HasOne("TNEStudentScoreModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TNEStudentScoreModels.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TNEStudentScoreModels.Student", b =>
                {
                    b.HasOne("TNEStudentScoreModels.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TNEStudentScoreModels.SubjectTeacher", b =>
                {
                    b.HasOne("TNEStudentScoreModels.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TNEStudentScoreModels.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
