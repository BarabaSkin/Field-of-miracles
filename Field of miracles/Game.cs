using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    public class Game
    {
        public bool End()
        {
            Console.WriteLine("Для завершения программы введите 'End' \nЧтобы начать заново введите'Repeat'");
            var t = true;
            var x = true;
            var end = Console.ReadLine();
            while (t)
            {
                if (end == "End")
                {
                    Console.WriteLine("Завершение программы.");
                    t = false;
                    x = false;
                }
                else if (end == "Repeat")
                {
                    Console.WriteLine("Повторение программы \n");
                    t = false;
                    x = true;
                }
                else if (end != "End")
                {
                    Console.WriteLine("Повторите ввод! \n");
                    t = true;
                }
            }
            return x;
        }
        public bool TheWholeWord()
        {
            bool r = true;
            bool z = true;
            while (z)
            {
                Console.WriteLine("Вы готовы ввести слово полностью?");
                string word = Console.ReadLine();
                if (word == "Yes")
                {
                    r = true;
                    z = false;
                }
                else if (word == "No")
                {
                    r = false;
                    z = false;
                }
                else if (word != "Yes")
                {
                    Console.WriteLine("Вы ввели неправильное значение!");
                    z = true;
                }
            }
            return r;

        }
        public bool TryWord(string word)
        {
            Console.WriteLine("Введите слово CAPS Lock'ом");
            var wordEquallValue = true;
            var value = Console.ReadLine();
            if (word == value)
            {
                Console.WriteLine("Вы угадали слово)");
                wordEquallValue = true;
            }
            else
            {
                Console.WriteLine("Вы не угдали(");
                wordEquallValue = false;
            }
            return wordEquallValue;
        }
        public void Start()
        {          
            QuestionAnswer word1 = new QuestionAnswer();
            QuestionAnswer word2 = new QuestionAnswer();
            QuestionAnswer word3 = new QuestionAnswer();
            QuestionAnswer answer = new QuestionAnswer();
            word1.Answer = "КОЛИБРИ";
            word1.Question = "Эта птица может летать спиной вперед";           
            word2.Answer = "ВРАТАРЬ";
            word2.Question = "Так в старину называли сторожа городских ворот";            
            word3.Answer = "ЧЕРЕПАХА";
            word3.Question = "Какое животное дало название распространенному в Древнем Риме способу боевого построения?";




            var random = new Random();
            var ii = random.Next(0, 3);
            string[] words = { word1.Answer , word2.Answer , word3.Answer };
            string[] questions = { word1.Question, word2.Question, word3.Question };

            var randomWord = words[ii];
            var randomWordQuestion = questions[ii];

            answer.Answer = randomWord;
            answer.Question = randomWordQuestion;

            Console.WriteLine(answer.Question);

            for (var i = 0; i < answer.Answer.Length ; i++)
            {
                Console.Write("*");
            }




            Console.WriteLine();
            var y = TheWholeWord();
            if (y == true)
            {
                bool equall;
                equall = TryWord(word1.Answer);

            }
            else
            {


            }
                        
        }
    }
}
