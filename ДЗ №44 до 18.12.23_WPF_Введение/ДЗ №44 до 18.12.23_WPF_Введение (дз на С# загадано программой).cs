using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork44
{
    class NumberGuesser
    {
        // Метод для запуска игры
        public void PlayGame()
        {
            do
            {
                // Получаем случайное число, которое пользователь должен угадать
                int targetNumber = GetRandomNumber(1, 2001);
                // Вызываем метод для угадывания числа
                int guessCount = GuessNumber(targetNumber);

                // Выводим результат игры
                Console.WriteLine($"Поздравляю! Вы угадали число {targetNumber} за {guessCount} попыток.");

                // Предлагаем пользователю сыграть еще раз
                Console.Write("Хотите сыграть еще раз? (да/нет): ");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "да")
                    break;

            } while (true);
        }

        // Метод для угадывания числа
        private int GuessNumber(int targetNumber)
        {
            int attempts = 0;

            // Выводим инструкции пользователю
            Console.WriteLine($"Загадано число от 1 до 2000.");

            do
            {
                // Запрашиваем у пользователя догадку
                Console.Write("Введите вашу догадку: ");
                int userGuess;
                
                // Проверяем корректность ввода
                while (!int.TryParse(Console.ReadLine(), out userGuess) || userGuess < 1 || userGuess > 2000)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 2000.");
                    Console.Write("Введите вашу догадку: ");
                }

                attempts++;

                // очищаем консоль после каждого ввода
                Console.Clear();

                // Проверяем, угадал ли пользователь число
                if (userGuess == targetNumber)
                    break;
                else
                    Console.WriteLine("Неправильно. Попробуйте снова.");

            } while (true);

            return attempts;
        }

        // Метод для получения случайного числа в заданном диапазоне
        private int GetRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса и запускаем игру
            NumberGuesser numberGuesser = new NumberGuesser();
            numberGuesser.PlayGame();
        }
    }
}
