using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    class Round
    {
        /// <summary>
        /// Идентификатор раунда 
        /// </summary>
        public static int Id;
        /// <summary>
        /// Вопрос
        /// </summary>
        public static string Question;
        /// <summary>
        /// Ответ
        /// </summary>
        public static string Answer;
        /// <summary>
        /// Индентификатор игрока
        /// </summary>
        public static int PlayerId;
        public Round(int id, string question, string answer, int playerId)
        {
            Id = id;
            Question = question;
            Answer = answer;
            PlayerId = playerId;
        }


        public void WriteNumberOfRound()
        {
            Console.WriteLine($"Начало {Id} раунда");
        }



        public void WriteQuestionOfRound()
        {
            Console.WriteLine(Question);
        }



        public char[] WriteClosedAnswer()
        {
            for (var i = 0; i < Answer.Length; i++)
            {
                Console.Write("*");
            }
            char[] word = Answer.ToCharArray();
            return word;
        }



        public bool TryLetterInAnswer(char[] answer,char letter)
        {
            var wordInAnswer = true;
            for (var i = 0; i < answer.Length; i++)
            {
                if (answer[i] == letter && wordInAnswer)
                {
                    wordInAnswer = false;
                    break;
                }
            }
            return !wordInAnswer;
        }



        public void WriteClosedAnswer(char letter)
        {
            for (var i = 0; i < Answer.Length; i++)
            {
                if (Answer[i] == letter)
                {
                    Console.Write(letter);
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

    }
}
