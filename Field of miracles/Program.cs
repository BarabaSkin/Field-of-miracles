using System;

namespace Field_of_miracles
{
    class Program
    {

        enum ThreeWords 
        {
           goalkeeper=1,
           turtel,
           Hummingbird
        }
        private static string RandomQuestion(out string answer)
        {
            string question = "";
            string Answer = "";
            
                       
            var word1 = (int)ThreeWords.goalkeeper;
            var word2 = (int)ThreeWords.turtel;
            var word3 = (int)ThreeWords.Hummingbird;

            var random = new Random();
            var ii = random.Next(1, 3);

            if (ii == word1)
            {
                var question1 = "Так в старину называли сторожа городских ворот";
                question = question1;
                Answer = "Вратарь";
            }            
            else if (ii == word2)
            {
                var question2 = "Какое животное дало название распространенному в Древнем Риме способу боевого построения?";
                question = question2;
                Answer = "Черепаха";
            }
            else if (ii == word3)
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
            for (var i = 0; i < answer.Length; i++)
            {
                Console.Write("*");
            }








        }
    }




    class Questions
    {

    }





}
