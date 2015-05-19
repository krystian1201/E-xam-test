

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace E_xam_test.Models
{
    public class Question
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Time to respond")]
        public TimeSpan Time { get; set; }

        [Required]
        [Display(Name = "Questions text")]
        public string Text { get; set; }

        public int Points { get; set; }

        public virtual Exam Exam { get; set; }

        public List<string> Answers { get; set; }
    }
}
