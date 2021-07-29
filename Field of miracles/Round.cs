using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    class Round
    {
        public Round(int id, string question, string answer, int playerId)
        {
            Id = id;
            Question = question;
            Answer = answer;
            PlayerId = playerId;
        }

        /// <summary>
        /// Идентификатор раунда 
        /// </summary>
        public static int Id;
        /// <summary>
        /// Вопрос
        /// </summary>
        public string Question;
        /// <summary>
        /// Ответ
        /// </summary>
        public string Answer;
        /// <summary>
        /// Индентификатор игрока
        /// </summary>
        public int PlayerId;
        public static void WriteNumberOfRound()
        {
            Console.WriteLine($"Начало {Round.Id} раунда");
        }
    }
}
