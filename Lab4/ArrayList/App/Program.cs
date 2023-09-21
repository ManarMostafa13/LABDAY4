using System.Collections;
using System;
namespace App
{
    public class Program
    {
        static void Main()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);

            foreach(int i in array)
            Console.WriteLine(i);


            ArrayList array1 = new ArrayList() {"gg","ii"};

            foreach (object i in array1)
                Console.WriteLine(i);
        }





    }













}
