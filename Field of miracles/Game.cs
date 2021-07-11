using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    public class Game
    {
        public void Start()
        {
            var endorrepeat = true;
            while (endorrepeat)
            {
                var answer = Data.ChooseRandomWord();
                Console.WriteLine(answer.Question);
                for (var i = 0; i < answer.Answer.Length; i++)
                {
                    Console.Write("*");
                }


                if (TheWholeWord() == true)
                {
                    if (TryWord(answer) == true)
                    {
                        endorrepeat = End();
                    }
                    else
                    {





                        Console.WriteLine("tritjkfhgldg");
                    }
                }
                else
                {
                    



                }
            }

        }
        public bool TheWholeWord()
        {
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
                    z = false;
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
                    Console.WriteLine("Вы ввели неправильное значение! \nПовторите ввод:");
                    z = true;
                }
            }
            return r;

        }
        public bool TryWord(QuestionAnswer word)
        {
            var woord = word.Answer;
            var equal = true;
            Console.WriteLine("Введите слово CAPS Lock'ом");
            var value = Console.ReadLine();
            if (woord == value)
            {
                Console.WriteLine("Вы угадали слово)");
                equal = true;
            }
            else
            {
                Console.WriteLine("Вы не угдали(");
                equal = false;
            }
            return equal;
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
                else
                {
                    Console.WriteLine("Повторите ввод! \n");
                    t = true;
                }
            }
            return x;
        }
    }
}
