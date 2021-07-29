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
            var data = Data.GetData(); //Получение данных из Excel
            var roundId = 1;
            var playerId = 21;
            var endorrepeat = true;
            while (endorrepeat)
            {
                var wordAnswer = Data.ChoseWord(data); //Выбор случайного вопроса и ответа
                data = Data.CreateNewArray(wordAnswer, data); //Получение старых данных без ранне выбранного значения
                var round = new Round(roundId, wordAnswer.Question, wordAnswer.Answer, playerId);//Новая переменная, хранящая номер раунда, вопрос, ответ и Id игрока.
                Round.WriteNumberOfRound();











                if (EnterTheWholeWord() == true)
                {
                    if (TryWord(wordAnswer) != true) //Ввод слова полностью и его проверка
                    {
                        int index;
                        var g = true;
                        while (g)
                        {
                            var let = EnterTheLetter();
                            if (IsOneLetter(let) == true)
                            {
                                var letter = Convert.ToChar(let);
                                if (CheckLetterInAnswer(letter, wordAnswer.Answer, out index) == true)
                                {

                                    Console.WriteLine("Вы угадали)");
                                    for (var i = 0; i < wordAnswer.Answer.Length; i++)
                                    {
                                        if (i == index)
                                        {
                                            Console.Write(wordAnswer.Answer[index]);
                                        }
                                        else
                                        {
                                            Console.Write("*");
                                        }


                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Такой буквы нет (");
                                }
                                g = false;
                            }
                            else
                            {
                                g = true;
                            }


                        }

                    }
                }
                else
                {
                    
                }





                

                endorrepeat = End();
                roundId++;
                //Console.WriteLine(wordAnswer.Question);
                //for (var i = 0; i < wordAnswer.Answer.Length; i++)
                //{
                //    Console.Write("*");
                //}
            }

        }
        public bool EnterTheWholeWord()
        {
            Console.WriteLine();
            bool r = true;
            bool z = true;
            while (z)
            {
                Console.WriteLine("\nВы готовы ввести слово полностью?");
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
        private bool End()
        {
            var t = true;
            var x = true;  
            while (t)
            {
                Console.WriteLine("Для завершения программы введите 'End' \nЧтобы начать заново введите'Repeat'");
                var end = Console.ReadLine();
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
                    Console.WriteLine("Повторите ввод!");
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
        public bool CheckLetterInAnswer(char letter, string answer, out int index)
        {
            for (var i = 0; i < answer.Length; i++)
            {
                if (answer[i] == letter)
                {
                    index = i;
                    return true;
                }
            }
            index = 1000000000;
            return false;
        }






















    }
}
