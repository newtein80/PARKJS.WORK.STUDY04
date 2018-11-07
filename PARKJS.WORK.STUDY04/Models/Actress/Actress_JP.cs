using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PARKJS.WORK.STUDY04.Models.Actress
{
    public class Actress_JP
    {
        [Key]
        public int Actr_JP_ID { get; set; }
        public string CategoryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfessionalName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; }
        public decimal Rate { get; set; }
        public int Ranking { get; set; }
        public string ActivityTime_From { get; set; }
        public string ActivityTime_To { get; set; }
        public DateTime RegistDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
