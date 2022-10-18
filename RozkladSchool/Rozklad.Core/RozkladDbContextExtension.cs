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
                    RoleId = USER_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID
                });


            builder.Entity<Day>().HasData(
               new Day
               {
                   DayId = 1,
                   DayName = "Понеділок"
               },
               new Day
               {
                   DayId = 2,
                   DayName = "Вівторок"

               },
               new Day
               {
                   DayId = 3,
                   DayName = "Середа"
               },
               new Day
               {
                   DayId = 4,
                   DayName = "Четвер"
               },
               new Day
               {
                   DayId = 5,
                   DayName = "Пятниця"
               });

            builder.Entity<Lesson>().HasData(
               new Lesson
               {
                   LessonId = 1,
                   LessonNumber = 1,
                   //StartTime=,
                   //EndTime=,
               },
               new Lesson
               {
                   LessonId = 2,
                   LessonNumber = 2,
                   //StartTime=,
                   //EndTime=,
               },
                new Lesson
                  {
                     LessonId = 3,
                      LessonNumber = 3,
                      //StartTime= DateTime.UtcNow,
                      //EndTime=,
                  },
                new Lesson
                     {
                         LessonId = 4,
                         LessonNumber = 4,
                         //StartTime=,
                         //EndTime=,
                     },
                new Lesson
                        {
                            LessonId = 5,
                            LessonNumber = 5,
                            //StartTime=,
                            //EndTime=,
                        }


               );
            builder.Entity<Cabinet>().HasData(
               new Cabinet
               {
                  CabinetId = 1,
                  Name="Географія"
               },
                       new Cabinet
                       {
                           CabinetId = 2,
                           Name = "Біологія"
                       },
                               new Cabinet
                               {
                                   CabinetId = 3,
                                   Name = "Математика"
                               },
                                       new Cabinet
                                       {
                                           CabinetId = 4,
                                           Name = "Укр мова"
                                       },
                                               new Cabinet
                                               {
                                                   CabinetId = 5,
                                                   Name = "Історія"
                                               }


               );

            builder.Entity<Discipline>().HasData(
              new Discipline
              {
                  DisciplineId=1,
                  DisciplineName="Географія"
              },
                 new Discipline
                 {
                     DisciplineId = 2,
                     DisciplineName = "Біологія"
                 },
                   new Discipline
                   {
                       DisciplineId = 3,
                       DisciplineName = "Математика"
                   },
                     new Discipline
                     {
                         DisciplineId = 4,
                         DisciplineName = "Укр мова"
                     },
                       new Discipline
                       {
                           DisciplineId = 5,
                           DisciplineName = "Історія"
                       }


              );


            builder.Entity<Class>().HasData(
             new Class
             {
                 ClassId=1,
                 ClassName=""
             },
               new Class
               {
                   ClassId = 2,
                   ClassName = ""
               }, new Class
               {
                   ClassId = 3,
                   ClassName = ""
               }, new Class
               {
                   ClassId = 4,
                   ClassName = ""
               }, new Class
               {
                   ClassId = 5,
                   ClassName = ""
               }



             );

            builder.Entity<Timetable>().HasData(
             new Timetable
             {
                 TimetableId=1,
                 ClassId=1,
                 LessonId=1,
                 DayId=1,
                 DisciplineId=1,
                 CabinetId=1
             },
             new Timetable
             {
                 TimetableId = 2,
                 ClassId = 2,
                 LessonId = 2,
                 DayId = 2,
                 DisciplineId = 2,
                 CabinetId = 2
             }

             );













        }
    }
}
