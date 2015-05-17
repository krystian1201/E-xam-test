

using System;
using System.ComponentModel.DataAnnotations;


namespace E_xam_test.Models
{
    public class Question
    {
        public int ID { get; set; }

        [DataType(DataType.Duration)]
        [Display(Name = "Time to respond")]
        public TimeSpan Time { get; set; }

        [Display(Name = "Questions text")]
        public string Text { get; set; }

        public int Points { get; set; }

        public Exam Exam { get; set; }
    }
}
