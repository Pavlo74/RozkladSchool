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
                 TeacherName = "Kvashuk O.V.",
                 
              },

                       new Teacher
                       {
                           TeacherId = 2,
                           TeacherName = "Zubenko I.R.",
                       },
                        new Teacher
                        {
                            TeacherId = 3,
                            TeacherName = "Popchuk M.A.",
                        }
             );

            builder.Entity<Pupil>().HasData(
           new Pupil
           {
               PupilId = 1,
               PupilName = "Belinskiy O.O",
               Year = 1,
               ClassRoomId = 1,
               IconPath = @"Images\1200h790_1-4_klass_t.png"
               //SectionId = 1
           },

            new Pupil
            {
                PupilId = 2,
                PupilName = "Koshubinskiy P.R",
                Year = 1,
                ClassRoomId = 2,
                IconPath = @"Images\1200h790_1-4_klass_t.png"
                //SectionId = 2
            },
             new Pupil
             {
                 PupilId = 3,
                 PupilName = "Bohach V.E",
                 Year = 2,
                 ClassRoomId = 3,
                 IconPath = @"Images\1200h790_1-4_klass_t.png"
                 //SectionId = 3
             }
           );

           

            builder.Entity<ClassRoom>().HasData(
           new ClassRoom
           {
               ClassRoomId = 1,
               ClassRoomName = "1-A",
               Year = 1
               

           },

           new ClassRoom
           {
               ClassRoomId = 2,
               ClassRoomName = "1-B",
               Year = 1
               

           },
           new ClassRoom
           {
               ClassRoomId = 3,
               ClassRoomName = "2-A",
               Year = 2
               

           });

            builder.Entity<Cabinet>().HasData(
               new Cabinet
               {
                  CabinetId = 1,
                  CabinetName="GeographyLab",
               },
                       new Cabinet
                       {
                           CabinetId = 2,
                           CabinetName = "BiologyLab",
                       },
                               new Cabinet
                               {
                                   CabinetId = 3,
                                   CabinetName = "MathLab",
                               }
                                       
               );

            builder.Entity<Discipline>().HasData(
              new Discipline
              {
                  DisciplineId=1,
                  DisciplineName="Geography"
                  
              },
                 new Discipline
                 {
                     DisciplineId = 2,
                     DisciplineName = "Biology"
                    
                 },
                   new Discipline
                   {
                       DisciplineId = 3,
                       DisciplineName = "Math"
                      
                   } 
              );

            builder.Entity<Lesson>().HasData(
             new Lesson
             {
                 LessonId = 1,
                 LessonName = "Geography, 1-st year, 1-A clas",
                 Year = 1,
                 DisciplineId = 1,
                 TeacherId = 1,
                 PupilId = 1
             },
                new Lesson
                {
                    LessonId= 2,
                    LessonName = "Biology, 1-st year, 1-B clas",
                    Year = 1,
                    DisciplineId = 2,
                    TeacherId = 2,
                    PupilId = 2
                },
                  new Lesson
                  {
                      LessonId = 3,
                      LessonName = "Math, 2-st year, 2-A clas",
                      Year = 2,
                      DisciplineId = 3,
                      TeacherId=3,
                      PupilId = 3
                  }
             );

            builder.Entity<Timetable>().HasData(
             new Timetable
             {
                 TimetableId= 1,
                 
                 Day = "Monday",
                 LessonNumber=1,
                 TimeStart = "9:00",
                 TimeEnd = "9:45",
                 CabinetId = 1,
                 LessonId = 1,
                 UserId = ADMIN_ID
                 
                 
                 
             },
             new Timetable
             {
                 TimetableId = 2,
                
                 Day = "Tuesday",
                 LessonNumber = 2,
                 TimeStart = "10:00",
                 TimeEnd = "10:45",
                 CabinetId = 2,
                 LessonId = 2,
                 UserId = ADMIN_ID
                 

             },

              new Timetable
              {
                  TimetableId = 3,
                 
                  LessonNumber =3,
                  Day = "Wednesday",
                  TimeStart = "11:00",
                  TimeEnd = "11:45",
                  CabinetId = 3,
                  LessonId = 3,
                  UserId = ADMIN_ID
                  
              }
             );

        }
    }
}
