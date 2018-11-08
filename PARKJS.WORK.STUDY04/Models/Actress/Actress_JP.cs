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

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(60, MinimumLength = 3)]
        public string CategoryId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ProfessionalName { get; set; }
        
        public int Age { get; set; }

        [Display(Name = "BirthDay")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        public string Nationality { get; set; }
        public decimal Rate { get; set; }
        public int Ranking { get; set; }

        public string ActivityTime_From { get; set; }
        public string ActivityTime_To { get; set; }

        [Display(Name = "Regist Day")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode = true)]
        public DateTime RegistDate { get; set; }

        [Display(Name = "Update Day")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdateDate { get; set; }

        public string Comment { get; set; }
    }
}
