using System;
using System.Collections;
using System.Collections.Generic;

namespace laba3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 1, 2.5, 3, 4.2, 5, "name", "age", "row", 'v', true };
            Appropriation appropriation = new Appropriation();
            for (int i = 0; i < list.Count - 2; i++)
            {
                appropriation.Object1 = list[i].ToString();
                appropriation.Object2 = list[i+2].ToString();
                appropriation.Replacement();
                list.Insert(i + 2, appropriation.Object1);
                list.RemoveAt(i + 3);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
    }
    class Appropriation
    {
        public string object1;
        public string object2;
        public string Object1
        {
            get
            {
                return object1;
            }
            set
            {
                object1 = value;
            }
        }
        public string Object2
        {
            get
            {
                return object2;
            }
            set
            {
                object2 = value;
            }
        }

        public string Replacement()
        {
            object1 = object2 + " " + object1;
            return object1;
        }
    }
}
