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
            var endorrepeat = true;
            while (endorrepeat)
            {
                var wordAnswer = Data.ChoseWord(data); //Выбор случайного вопроса и ответа
                data = Data.CreateNewArray(wordAnswer, data); //Получение старых данных без ранне выбранного значения

                var round = new Round(roundId, wordAnswer.Question, wordAnswer.Answer, 1); //Новая переменная, хранящая номер раунда, вопрос, ответ и Id игрока.              
                round.WriteNumberOfRound(); //Вывод в консоль номера раунда и информирование о его начале
                round.WriteQuestionOfRound(); //Вывод в консоль вопроса
                var answer = round.WriteClosedAnswer(); //Вывод в консоль * вместо каждой буквы ответа. Создание массива с буквами ответа


                if (EnterTheWholeWord() == true) //Проверка: готов ли пользователь ввести слово полностью
                {
                    if (TryWord(wordAnswer) != true) //Ввод слова и его проверка
                    {
                        var letter = EnterTheLetter();

                        if (round.TryLetterInAnswer(answer, letter)==true)
                        {
                            Console.WriteLine("Вы угадали!");
                        }
                        else
                        {
                            Console.WriteLine("Такой буквы нет (");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы угадали");
                    }
                }


                else
                {
                }
                endorrepeat = End();
                roundId++;
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
        public char EnterTheLetter()
        {
            Console.WriteLine("Напишите одну букву Caps Lock'ом ");
            var T = Convert.ToChar(Console.Read());
            return T;
        }






















    }
}
