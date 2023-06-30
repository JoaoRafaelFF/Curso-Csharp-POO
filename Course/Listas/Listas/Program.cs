using System;
using System.Collections.Generic;

namespace Lista // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();

            list.Add("Maria 0");
            list.Add("alex 1");
            list.Add("bob 2");
            list.Add("anna 3");
            list.Insert(2, "Marco");



            foreach (String obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'a');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'a');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'a');
            Console.WriteLine("first position 'a': "+ pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'a');
            Console.WriteLine("last position 'a': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (String obj in list2) 
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            list.Remove("alex");
            foreach (String obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            list.RemoveAll(x => x[0] == 'm');
            foreach (String obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            list.RemoveAt(3);
            foreach (String obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------------------------------------------");
            list.RemoveRange(2,2);
            foreach (String obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
