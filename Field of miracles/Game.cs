using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    public class Game
    {
        public QuestionAnswer Start()
        {
            var answer = Data.ChooseRandomWord();
            Console.WriteLine(answer.Question);
            for (var i = 0; i < answer.Answer.Length; i++)
            {
                Console.Write("*");
            }
            return answer;
        }
        public bool TheWholeWord()
        {
            var t = Start();
            Console.WriteLine();
            bool r = true;
            bool z = true;
            while (z)
            {
                Console.WriteLine("Вы готовы ввести слово полностью?");
                string word = Console.ReadLine();
                // сопоставление введенного слова со словом да
                if (word == "Yes")
                {
                    r = true;
                    z = !TryWord(t);
                }
                // соспоставление введенного слова со словом нет
                else if (word == "No")
                {
                    r = false;
                    z = false;
                }
                // введенное слово не равно да
                else // if (word != "Yes")
                {
                    Console.WriteLine("Вы ввели неправильное значение!");
                    z = true;
                }
            }
            return r;

        }
        public bool TryWord(QuestionAnswer word)
        {
            var wooord = word.Answer;
            Console.WriteLine("Введите слово CAPS Lock'ом");
            var wordEquallValue = true;
            var value = Console.ReadLine();
            if (wooord == value)
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
    }
}
