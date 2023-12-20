using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork44
{
    class NumberGuesser
    {
        // Метод для угадывания числа, загаданного пользователем
        public void GuessUserNumber()
        {
            do
            {
                // Получаем от пользователя загаданное число
                int targetNumber = GetUserTargetNumber();

                // Запускаем процесс угадывания
                int guessCount = AutoGuess(targetNumber);

                // Выводим результат угадывания
                Console.WriteLine($"Программа угадала ваше число {targetNumber} за {guessCount} попыток.");


                // Предлагаем пользователю сыграть еще раз
                Console.Write("Хотите сыграть еще раз? (да/нет): ");
                string playAgain = Console.ReadLine().ToLower();

                // ToLower() используется для преобразования всех символов в строке к нижнему регистру (в нижний регистр).
                // Это делается для того, чтобы сделать введенный текст нечувствительным к регистру при сравнении

                if (playAgain != "да")
                    break;

                Console.Clear(); // Очищаем консоль перед новой игрой

            } while (true);
        }

        // Метод для автоматического угадывания числа
        private int AutoGuess(int targetNumber)
        {
            int min = 1;
            int max = 2000;
            // счетчик, который отражает количество шагов, предпринятых программой в процессе угадывания числа
            int attempts = 0;

            do
            {
                //GetMidpoint вычисляет среднее значение между двумя числами (min и max),
                //чтобы получить "предполагаемое" число, которое программа проверяет
                //на соответствие загаданному пользователем числу
                int guess = GetMidpoint(min, max);
                attempts++;

                // Сравниваем угаданное число с загаданным
                if (guess == targetNumber)
                {
                    break;
                }
                else if (guess < targetNumber)
                {
                    // Если угаданное число меньше, увеличиваем минимальное значение диапазона
                    min = guess + 1;
                }
                else
                {
                    // Если угаданное число больше, уменьшаем максимальное значение диапазона
                    max = guess - 1;
                }

            } while (true);

            return attempts;
        }

        // Метод для получения середины диапазона
        private int GetMidpoint(int min, int max)
        {
            return (min + max) / 2;
        }

        // Метод для получения числа, которое пользователь загадал
        private int GetUserTargetNumber()
        {
            Console.WriteLine("Загадайте число от 1 до 2000.");

            while (true)
            {
                
                Console.Write("Введите ваше загаданное число: ");
                int userTarget;

                if (int.TryParse(Console.ReadLine(), out userTarget) && userTarget >= 1 && userTarget <= 2000)
                {
                    return userTarget;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 2000.");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа << Угадай число >> ");
            NumberGuesser numberGuesser = new NumberGuesser();
            numberGuesser.GuessUserNumber();
        }
    }

}
