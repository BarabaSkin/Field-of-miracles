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
                string[] word = new string[answer.Answer.Length];
                for (var i = 0; i < answer.Answer.Length; i++)
                {
                    Console.Write("*");
                }


                if (EnterTheWholeWord() == true)
                {
                    if (TryWord(answer) == true) ;
                    else
                    {
                        var g = true;
                        while (g)
                        {
                            var let = EnterTheLetter();
                            if (IsOneLetter(let) == true)
                            {
                                var lette = Convert.ToChar(let);
                                if (CheckLetterInAnswer(lette, answer.Answer) == true)
                                {
                                    Console.WriteLine("Вы угадали)");

                                }
                                else
                                {
                                    Console.WriteLine("Такой буквы нет (");
                                }
                                g = false;
                            }
                            else
                            {
                                g = IsOneLetter(let);
                            }


                        }

                    }
                }




                else
                {
                    var g = true;
                    while (g)
                    {
                        var let = EnterTheLetter();
                        if (IsOneLetter(let) == true)
                        {
                            var lette = Convert.ToChar(let);
                            if (CheckLetterInAnswer(lette, answer.Answer) == true)
                            {
                                Console.WriteLine("Вы угадали)");

                            }
                            else
                            {
                                Console.WriteLine("Такой буквы нет (");
                            }
                            g = false;
                        }
                        else
                        {
                            g = IsOneLetter(let);
                        }


                    }


                }
               
                
                
                
                
                endorrepeat = End();
            }

        }
        public bool EnterTheWholeWord()
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
                else
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

        public string EnterTheLetter()
        {
            Console.WriteLine("Напишите одну букву Caps Lock'ом ");
            string T = Console.ReadLine();
            return T;
        }
        public bool IsOneLetter(string T)
        {
            if (T.Length != 1)
            {
                Console.WriteLine("Вы ввели неправильное значение \nПовторите ввод: ");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckLetterInAnswer(char letter, string answer)
        {
            foreach (var b in answer)
            {
                if (b == letter)
                {
                    return true;
                }
            }
            return false;
        }






        public void OpenLetter()
        {




        }






















    }
}
