using System;


namespace Field_of_miracles
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
               QuestionAnswer word1 = new QuestionAnswer();
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
