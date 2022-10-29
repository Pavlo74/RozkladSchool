using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Core
{
    public static class RozkladDbContextExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string MODERATOR_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                  new IdentityRole
                  {
                      Id = MODERATOR_ROLE_ID,
                      Name = "Moderator",
                      NormalizedName = "MODERATOR"
                  },
                new IdentityRole
                {
                    Id = USER_ROLE_ID,
                    Name = "User",
                    NormalizedName = "USER"
                });

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();
            string MODERATOR_ID = Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@rozkladschool.com",
                Email = "admin@rozkladschool.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@rozkladschool.com".ToUpper(),
                NormalizedUserName = "admin@rozkladschool.com".ToUpper()
            };

            var moderator = new User
            {
                Id = MODERATOR_ID,
                UserName = "moderator@rozkladschool.com",
                Email = "moderator@rozkladschool.com",
                EmailConfirmed = true,
                NormalizedEmail = "moderator@rozkladschool.com".ToUpper(),
                NormalizedUserName = "moderator@rozkladschool.com".ToUpper()
            };

            var user = new User
            {
                Id = USER_ID,
                UserName = "user@rozkladschool.com",
                Email = "user@rozkladschool.com",
                EmailConfirmed = true,
                NormalizedEmail = "user@rozkladschool.com".ToUpper(),
                NormalizedUserName = "user@rozkladschool.com".ToUpper()
            };

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            admin.PasswordHash = hasher.HashPassword(admin, "Admin$pass1");
            moderator.PasswordHash = hasher.HashPassword(moderator, "Moderator$pass1");
            user.PasswordHash = hasher.HashPassword(user, "User$pass1");

            builder.Entity<User>().HasData(admin, moderator, user);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = MODERATOR_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = MODERATOR_ROLE_ID,
                    UserId = MODERATOR_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = MODERATOR_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID
                }
                );



            builder.Entity<Teacher>().HasData(
             new Teacher
             {
                 TeacherId = 1,
                 TeacherName = "Квашук О.В.",
              },

                       new Teacher
                       {
                           TeacherId = 2,
                           TeacherName = "Зубенко І.Р.",
                       },
                        new Teacher
                        {
                            TeacherId = 3,
                            TeacherName = "Попчук М.А.",
                        }
             );

            builder.Entity<Pupil>().HasData(
           new Pupil
           {
               PupilId = 1,
               PupilName = "Белінський О.О",
               SectionId = 1
           },

            new Pupil
            {
                PupilId = 2,
                PupilName = "Кошубінський П.Р",
                SectionId = 2
            },
             new Pupil
             {
                 PupilId = 3,
                 PupilName = "Богач В.Е",
                 SectionId = 3
             }
           );

            builder.Entity<Section>().HasData(
            new Section
            {
                SectionId = 1,
                SectionName = "FirstSec",
                ClassId = 1
             },

                      new Section
                      {
                          SectionId = 2,
                          SectionName = "SecondSec",
                          ClassId = 2
                      },
                       new Section
                       {
                           SectionId = 3,
                           SectionName = "ThirdSec",
                           ClassId = 3
                       }
            );

            builder.Entity<Class>().HasData(
           new Class
           {
               ClassId = 1,
               ClassName = "1-A",
           },

           new Class
           {
               ClassId = 2,
               ClassName = "1-Б",
           },
           new Class
           {
               ClassId = 3,
               ClassName = "2-A",
           });

            builder.Entity<Cabinet>().HasData(
               new Cabinet
               {
                  CabinetId = 1,
                  Name="Географія",
               },
                       new Cabinet
                       {
                           CabinetId = 2,
                           Name = "Біологія",
                       },
                               new Cabinet
                               {
                                   CabinetId = 3,
                                   Name = "Математика",
                               }
                                       
               );

            builder.Entity<Discipline>().HasData(
              new Discipline
              {
                  DisciplineId=1,
                  DisciplineName="Географія",
              },
                 new Discipline
                 {
                     DisciplineId = 2,
                     DisciplineName = "Біологія",
                 },
                   new Discipline
                   {
                       DisciplineId = 3,
                       DisciplineName = "Математика",
                   }
                    
              );


           

            builder.Entity<Timetable>().HasData(
             new Timetable
             {
                 TimetableId= 1,
                 DisciplineId= 1,
                 TeacherId = 1,
                 Day = "Понеділок",
                 LessonNumber=1,
                 TimeStart = "9:00",
                 TimeEnd = "9:45",
                 SectionId = 1,
                 CabinetId = 1,
                 IconPath = @"Images\1200h790_1-4_klass_t.png"
             },
             new Timetable
             {
                 TimetableId = 2,
                 DisciplineId = 2,
                 TeacherId = 2,
                 Day = "Вівторок",
                 LessonNumber = 2,
                 TimeStart = "10:00",
                 TimeEnd = "10:45",
                 SectionId = 2,
                 CabinetId = 2,
                 IconPath = @"Images\1200h790_1-4_klass_t.png"

             },

              new Timetable
              {
                  TimetableId = 3,
                  DisciplineId = 3,
                  TeacherId = 3,
                  LessonNumber =3,
                  Day = "Середа",
                  TimeStart = "11:00",
                  TimeEnd = "11:45",
                  SectionId = 3,
                  CabinetId = 3,
                  IconPath = @"Images\1200h790_1-4_klass_t.png"

              }
            

             );

        }
    }
}
