using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_of_miracles
{
    class Game
    {
        public static bool End()
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
        public static bool TheWholeWord()
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
        public static bool TryWord(string word)
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
    }
}
