﻿using System;

namespace TIMAmathes
{
    class Program
    {
        public string questions;
        static void Main(string[] args)
        {
            int end = 0;
            while (end == 0)
            {
                Console.WriteLine("Выбери какие примеры тебе нужны:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Выход");
                string num = Console.ReadLine();
                Random gpg = new Random();
                
                bool isCorrect = false;


                
                while (end == 0)
                {

                    int a = gpg.Next(0, 1000);
                    int b = gpg.Next(0, 1000);
                    
                    
                }
                
             

                if (num == "4")
                {
                    while (end == 0)
                    {
                        int[] loc = {};
                        int prom1 = gpg.Next(0, 9);
                        if (prom1 == 0)
                        {
                            int prom2 = gpg.Next(0, 99);
                            while ( isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {prom2} : 1");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == prom2)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 1)
                        {
                            loc = { 4, 6, 8, 10, 12, 14, 16, 18, 20 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while ( isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 2");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 2)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect =false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 2)
                        {
                            loc = { 6,9,12,15,18,21,24,28,30 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 3");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 3)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 3)
                        {
                            loc = { 8,12,16,20,24,28,32,36,40 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 4");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 4)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 4)
                        {
                            loc = { 10,15,20,25,30,35,40,45,50 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 5");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 5)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 5)
                        {
                            loc = { 12,18,24,30,36,42,48,54,60 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 6");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 6)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 6)
                        {
                            loc = { 14,21,28,35,42,49,56,63,70 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 7");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 7)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 7)
                        {
                            loc = { 16,24,32,40,48,56,64,72,80 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 8");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 8)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                        if (prom1 == 8)
                        {
                            loc = { 18,27,36,45,54,63,72,81,90 };
                            int prom2 = gpg.Next(0, 9);
                            int n = loc[prom2];
                            while (isCorrect == false)
                            {
                                Console.WriteLine($"сколько будет: {n} : 9");
                                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                                if (expectedResult == n / 9)
                                {
                                    Console.WriteLine("Молодец! Правильно!");
                                    isCorrect = true;
                                }
                                else
                                {
                                    Console.WriteLine("попробуй ещё раз");
                                }
                            }
                            isCorrect = false;
                            Console.WriteLine("Хочешь ещё пример?");
                            questions = Console.ReadLine();
                            if (questions == "Нет" || questions == "нет")
                            {
                                end = 1;
                            }
                        }
                    }
                }
                end = 0;

                if (num == "5")
                {
                    end = 1;
                }
            }
        }
        static void AdditionAndSubtractionAndMultiplication(string num,  int a, int b)
        {
            
            Random gpg = new Random();
            int exampleresponse;
            
            if (num == "1")
            {
                
                if (expectedResult == a + b)
                {
                    
                    Console.WriteLine($"сколько будет: {a} + {b}");
                    exampleresponse = a+b;
                }
                

            }
            if (num == "2")
            {
                
                if (expectedResult == a - b)
                {
                    
                    Console.WriteLine($"сколько будет: {a} - {b}");
                    exampleresponse = a-b;
                }
                

            }
            if (num == "3")
            {
                
                if (expectedResult == a * b)
                {
                    
                    Console.WriteLine($"сколько будет: {a} * {b}");
                    exampleresponse = a*b;
                }
            }
            int thecorrectnessoftheanswer = 0;
            while (thecorrectnessoftheanswer == 0)
            {

                        

                int expectedResult = (Convert.ToInt32(Console.ReadLine()));
                if (expectedResult == exampleresponse)
                {
                    thecorrectnessoftheanswer = 1;
                    Console.WriteLine("Молодец, правильно!");
                }

            }
                    
            Console.WriteLine("Хочешь ещё пример?");
            questions = Console.ReadLine();
            if (questions == "Нет" || questions == "нет")
            {
                end = 1;
            }

            
            return;
        }
    }
}
