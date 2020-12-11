using System;
using System.Collections.Generic;

namespace Lesson_03
{
    class Program
    {
        static void Task_01()
        {
            string sentence = "";
            string[] arrayNames = { "John", "Michael", "Smith", "Trevor" };
            DateTime birth1 = new DateTime(1998, 7, 10);
            DateTime birth2 = new DateTime(1998, 4, 20);
            DateTime birth3 = new DateTime(1998, 7, 31);
            DateTime birth4 = new DateTime(1998, 7, 1);
            DateTime[] arrayBirth = { birth1, birth2, birth3, birth4 };
            Console.WriteLine("Please enter an index");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index < 0 || index >= arrayBirth.Length)
            {
                Console.WriteLine("The index doesn't exist");
            }
            else
            {
                sentence = arrayNames[index] + "'s birthday is in ";
                if (arrayBirth[index].Day <= 10)
                {
                    sentence = sentence + "beginning of ";
                }
                else
                {
                    if (arrayBirth[index].Day <= 20)
                    {
                        sentence = sentence + "mid of ";
                    }
                    else
                    {
                        sentence = sentence + "end of ";
                    }
                }
            }
            sentence = sentence + arrayBirth[index].Month;
            Console.WriteLine(sentence);
        }
        static void Task_02(string sentence)
        {
            int max = 0;
            int numberOfLetters = 0;
            char[] longestWord = new char[30];
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    numberOfLetters++;
                }
                else
                {
                    if (numberOfLetters > max)
                    {
                        max = numberOfLetters;
                        for (int j = i - max; j <= i; j++)
                        {
                            longestWord[j - i + max] = sentence[j];
                        }
                    }
                    numberOfLetters = 0;
                }
            }
            for (int i = 0; i < longestWord.Length; i++)
            {
                Console.Write(longestWord[i]);
            }
        }
        static void Task_03(string sentence)
        {
            Stack<string> arrayWords = new Stack<string>();
            string word = "";
            for (int j = 0; j < sentence.Length; j++)
            {
                if (sentence[j] != ' ')
                {
                    word = word + sentence[j];
                }
                else
                {
                    arrayWords.Push(word);
                    word = "";
                }
            }
            arrayWords.Push(word);
            int numberOfWords = arrayWords.Count;
            //Console.Write(arrayWords.Pop());
            for (int i = 0; i < numberOfWords; i++)
            {
                Console.Write(arrayWords.Pop() + " ");
            }
        }
        static void Homework_01()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
        static void Homework_02()
        {
            Stack<int> list = new Stack<int>();
            list.Push(9);
            list.Push(17);
            list.Push(78);
            list.Push(98);
            list.Push(1);
            list.Push(30);
            list.Push(432);
            list.Push(212);
            list.Push(834);
            list.Push(56);
            if (list.Contains(9))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Homework_03()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(9);
            queue.Enqueue(17);
            queue.Enqueue(78);
            queue.Enqueue(98);
            queue.Enqueue(1);
            queue.Enqueue(30);
            queue.Enqueue(432);
            queue.Enqueue(212);
            queue.Enqueue(834);
            queue.Enqueue(56);
            if (queue.Contains(9))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        static void Homework_04()
        {
            List<int> list = new List<int>();
            list.Add(9);
            list.Add(17);
            list.Add(78);
            list.Add(98);
            list.Add(1);
            list.Add(30);
            list.Add(432);
            list.Add(212);
            list.Add(834);
            list.Add(56);
            if (list.Contains(9))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            /*string sentence = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine(sentence);
            Console.WriteLine();
            Task_03(sentence);
            */
            Homework_04();
        }
    }
}
