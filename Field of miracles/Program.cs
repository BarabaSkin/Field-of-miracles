using System;
using New_Classes;


namespace Field_of_miracles
{
    class Program
    {
        private static string RandomQuestion(out string answer)
        {
            string question = "";
            string Answer = "";
            var random = new Random();
            var ii = random.Next(1, 4);

            if (ii == 1)
            {
                var question1 = "Так в старину называли сторожа городских ворот";
                question = question1;
                Answer = "Вратарь";
            }            
            else if (ii == 2)
            {
                var question2 = "Какое животное дало название распространенному в Древнем Риме способу боевого построения?";
                question = question2;
                Answer = "Черепаха";
            }
            else if (ii == 3)
            {
                var question3 = "Эта птица может летать спиной вперед";
                question = question3;
                Answer = "Колибри";
            }
            answer = Answer;
            return question;           
        }
        private static bool TheWholeWord()
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


        static void Main(string[] args)
        {
            string answer;
            var t = RandomQuestion(out answer);
            Console.WriteLine(t);
            for (var i = 0; i <answer.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            






           QuestionsAndAnswers word1 = new QuestionsAndAnswers();
            word1.answer = "Колибри";
            word1.question = "Эта птица может летать спиной вперед";
            word1.Question();
            for (var i = 0; i < word1.answer.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            var y = TheWholeWord();
        }
    }    





}
