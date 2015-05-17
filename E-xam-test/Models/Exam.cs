
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_xam_test.Models
{
    public class Exam
    {
        public int ID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan Duration { get; set; }

        public int MaxPoints
        {
            get { return 10; }
        }

        public List<Question> Questions { get; set; }
    }
}