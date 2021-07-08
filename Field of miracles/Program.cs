using System;


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





            bool repeat = true;
            while (repeat)
            {
               Question word1 = new Question();
                word1.answer = "КОЛИБРИ";
                word1.question = "Эта птица может летать спиной вперед";
                word1.Question();
                for (var i = 0; i < word1.answer.Length; i++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
                var y = Game.TheWholeWord();
                if (y == true)
                {
                    bool equall;
                    equall = Game.TryWord(word1.answer);
               
                }
                else
                {




                }
                repeat = Game.End();
            }





        }
    }    





}
