using System;

namespace TIMAmathes
{
    class Program
    {
        public string questions;
        static void Main(string[] args)
        {
            int f = 0;
            while (f == 0)
            {
                Console.WriteLine("Выбери какие примеры тебе нужны:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Выход");
                string num = Console.ReadLine();
                Random gpg = new Random();
                
                int s = 0;


                
                while (f == 0)
                {

                    int a = gpg.Next(0, 1000);
                    int b = gpg.Next(0, 1000);
                    
                    int j = 0;
                    while (j == 0)
                    {

                        Console.WriteLine($"сколько будет: {a} + {b}");

                        int end = (Convert.ToInt32(Console.ReadLine()));
                        if (end == a + b)
                        {
                            j = 1;
                            Console.WriteLine("Молодец, правильно!");
                        }
                        else j = 0;

                    }
                    
                    Console.WriteLine("Хочешь ещё пример?");
                    questions = Console.ReadLine();
                    
                }
                
             

                if (num == "4")
                {
                    while (f == 0)
                    {
                        
                        int prom1 = gpg.Next(0, 9);
                        if (prom1 == 0)
                        {
                            int prom2 = gpg.Next(0, 99);
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {prom2} : 1");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == prom2)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 1)
                        {
                            int[] loc = { 4, 6, 8, 10, 12, 14, 16, 18, 20 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 2");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 2)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 2)
                        {
                            int[] loc = { 6,9,12,15,18,21,24,28,30 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 3");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 3)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 3)
                        {
                            int[] loc = { 8,12,16,20,24,28,32,36,40 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 4");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 4)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 4)
                        {
                            int[] loc = { 10,15,20,25,30,35,40,45,50 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 5");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 5)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 5)
                        {
                            int[] loc = { 12,18,24,30,36,42,48,54,60 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 6");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 6)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 6)
                        {
                            int[] loc = { 14,21,28,35,42,49,56,63,70 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 7");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 7)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 7)
                        {
                            int[] loc = { 16,24,32,40,48,56,64,72,80 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 8");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 8)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                        if (prom1 == 8)
                        {
                            int[] loc = { 18,27,36,45,54,63,72,81,90 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (s == 0)
                            {
                                Console.WriteLine($"сколько будет: {n} : 9");
                                int end = (Convert.ToInt32(Console.ReadLine()));
                                if (end == n / 9)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    s = 1;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            s = 0;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                f = 1;
                            }
                        }
                    }
                }
                f = 0;

                if (num == "5")
                {
                    f = 1;
                }
            }
        }
        static void AdditionAndSubtractionAndMultiplication(string num, int end, int a, int b,int j)
        {
            
            Random gpg = new Random();
            
            
            if (num == "1")
            {
                
                if (end == a - b)
                {
                    j = 1;
                }
                

            }
            if (num == "2")
            {
                
                if (end == a + b)
                {
                    j = 2;
                }
                

            }
            if (num == "3")
            {
                
                if (end == a * b)
                {
                    j = 3;
                }
               

            }

            
            return;
        }
        static void Questions(int f, string questions)
        {
            if (questions == "Нет" || questions == "нет")
            {
                f = 1;
            }
            return;
        }
    }
}
