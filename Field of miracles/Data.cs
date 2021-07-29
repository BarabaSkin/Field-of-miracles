using ExcelDataReader;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.IO;
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
        const int arraySize = 100;
        const string filePath = "D:\\ШКОЛА\\Приколы\\QA.xlsx";
        public static QuestionAnswer[] items_2 = new QuestionAnswer[arraySize];











        public static QuestionAnswer[] GetData()
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open))
                {
                    var mapper = new ExcelMapper(stream);
                    var qa = mapper.Fetch<QuestionAnswer>();
                    return qa.ToArray();
                }
            }
            catch(Exception e)
            {
            }
            return new QuestionAnswer[arraySize];
        }
        public static QuestionAnswer ChoseWord(QuestionAnswer[] allValues)
        {
            var random = new Random();
            var i = random.Next(0, allValues.Length);
            return allValues[i];
        }
        public static QuestionAnswer[] CreateNewArray(QuestionAnswer value, QuestionAnswer[] array)
        {
            QuestionAnswer[] NArray = new QuestionAnswer[array.Length - 1];
            var isSkiped = false;
            var i = 0;
            foreach (var item in array)
            {
                if (item == value && !isSkiped)
                {
                    isSkiped = false;
                }
                else
                {
                    NArray[i] = item;
                    i++;
                }
            }
            return NArray;
        }
        






    }
}
