using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PARKJS.WORK.STUDY04.Data;
using PARKJS.WORK.STUDY04.Models.Actress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARKJS.WORK.STUDY04.Data.Seed
{
    public static class SeedData_Actress_JP
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Actress_JP.Any())
                {
                    return;   // DB has been seeded
                }

                context.Actress_JP.AddRange(
                    new Actress_JP
                    {
                        CategoryId = "RM",
                        FirstName = "길동",
                        LastName = "홍",
                        ProfessionalName = "홍길동",
                        ActivityTime_From = "2018/01/10",
                        ActivityTime_To = "2018/02/02",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "MF",
                        FirstName = "순신",
                        LastName = "이",
                        ProfessionalName = "거북선",
                        ActivityTime_From = "2018/01/05",
                        ActivityTime_To = "2018/02/05",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "Republic of Korea",
                        Ranking = 24,
                        Rate = 49,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "AN",
                        FirstName = "철수",
                        LastName = "이",
                        ProfessionalName = "일반인",
                        ActivityTime_From = "2018-09-06",
                        ActivityTime_To = "2019-01-01",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "Japan",
                        Ranking = 6,
                        Rate = 0,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "PU",
                        FirstName = "Tom",
                        LastName = "Cruise",
                        ProfessionalName = "탑건",
                        ActivityTime_From = "2019-01-01",
                        ActivityTime_To = "2020-01-01",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 9,
                        Rate = 12,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "BUK",
                        FirstName = "다라",
                        LastName = "가나",
                        ProfessionalName = "한글",
                        ActivityTime_From = "01/01/1919",
                        ActivityTime_To = "08/05/2019",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "한국",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "TS",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance1",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance2",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance3",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance4",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance5",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance6",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance7",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    },

                    new Actress_JP
                    {
                        CategoryId = "Romance8",
                        FirstName = "",
                        LastName = "Romantic Comedy",
                        ProfessionalName = "",
                        ActivityTime_From = "",
                        ActivityTime_To = "",
                        Age = 20,
                        BirthDay = Convert.ToDateTime("2018-11-08"),
                        Nationality = "United States of America",
                        Ranking = 4,
                        Rate = 9,
                        RegistDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        Comment = "가나다라"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
