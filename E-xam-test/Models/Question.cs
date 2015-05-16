

using System;


namespace E_xam_test.Models
{
    public class Question
    {
        public int ID { get; set; }

        public TimeSpan Time { get; set; }

        public string Text { get; set; }

        public int Points { get; set; }
    }
}
