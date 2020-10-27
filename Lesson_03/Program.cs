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
            for(int i=0; i<array.Length;i++)
            {
                array[i] = i;
            }
        }
        static void Main(string[] args)
        {
            string sentence = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine(sentence);
            Console.WriteLine();
            Task_03(sentence);
        }
    }
}
