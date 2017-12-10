using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый игрок загадывает");
            string word = Console.ReadLine();
            char[] letters = new char[word.Length];
            int num = word.Length;
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = '*';
            }
            int count = 0;
            do
            {
                Console.Clear();
                for (int i = 0; i < letters.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Второй игрок угадывает");
                char symbol = char.Parse(Console.ReadLine());
                count++;
                for (int i = 0; i < letters.Length; i++)
                {
                    if (symbol == word[i])
                    {
                        letters[i] = symbol;
                        num--;
                    }
                }
            } while (count < letters.Length + 5 && num > 0);
            if (count == letters.Length + 5)
            {
                Console.Clear();
                Console.WriteLine("О нет, у тебя закончились попытки!");
            }
            else if (num == 0)
            {
                Console.Clear();
                Console.WriteLine("Ты угадал слово! Ура!");
            }
            Console.ReadLine();
        }
    }
}
