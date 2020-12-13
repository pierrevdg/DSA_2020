using System;
using System.Collections.Generic;

namespace Lesson_04
{
    class Program
    {
        static void DemoInClass()
        {
            IDictionary<string, int> dico = new Dictionary<string,int>();
            dico.Add("Pierre", 10);
            dico.Add("Nicolas", 12);
            dico.Add("Gatien", 11);
            dico.Add("Yannick", 7);
            dico.Add("Maxime", 9);
            dico.Add("Flo", 5);
            Console.WriteLine("Write a student name");
            string name = Convert.ToString(Console.ReadLine());
            if(dico.ContainsKey(name))
            {
                Console.WriteLine("Student : " + name + "\nMarks : " + dico[name]);
            }
            else
            {
                Console.WriteLine("This student dosen't exist");
            }
            foreach(var item in dico)
            {
                Console.WriteLine(item.Key + " mark is " + item.Value);
            }
        }
        static void Main(string[] args)
        {
            DemoInClass();
        }
    }
}
