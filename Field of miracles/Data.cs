using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    public static class Data
    {
        readonly static  QuestionAnswer [] items = new QuestionAnswer[]
        {
            new QuestionAnswer()
            {
                Answer = "КОЛИБРИ",
                Question = "Эта птица может летать спиной вперед"
            },
            new QuestionAnswer()
            {
                Answer = "ВРАТАРЬ",
                Question = "Так в старину называли сторожа городских ворот",

            },
            new QuestionAnswer()
            {
                Answer = "ЧЕРЕПАХА",
                Question = "Какое животное дало название распространенному в Древнем Риме способу боевого построения?"
            }
        };
        public static QuestionAnswer ChooseRandomWord()
        {
            var random = new Random();
            var ii = random.Next(0, 3);
            return items[ii];
        }        
    }
}
