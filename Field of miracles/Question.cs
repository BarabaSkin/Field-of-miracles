using Ganss.Excel;
using System;

namespace Field_of_miracles
{
    public class QuestionAnswer
    {
        [Column("Answer")]
        public string Answer { get; set; }

        [Column("Question")]
        public string Question { get; set; }
        
    }
}
