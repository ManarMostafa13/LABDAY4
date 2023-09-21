using System;
using System.Collections;
namespace App
    {
        public class Program
        {
            static void Main()
            {
                ArrayList Trainees = new ArrayList()
            {
                new Trainee { Name = "mm", Id = 1 },
                new Trainee { Name = "ss", Id = 2 }
             };



                Trainees.Add(new Trainee { Id = 3, Name = "ww" });

                foreach (object i in Trainees)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
                Console.WriteLine();
                Trainees.RemoveAt(1);

                Console.WriteLine("after rmove id =2");
                foreach (object i in Trainees)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            Console.WriteLine();
            

            Console.WriteLine("how many trainees you whant to add");

            int x = int.Parse(Console.ReadLine());

            for(int i =0; i<x; i++)
            {
                Console.WriteLine("Enter Your Trainee Name");
                Trainee t = new Trainee();
                t.Name = Console.ReadLine();
                Console.WriteLine("Enter Your Trainee Id");
                t.Id = int.Parse(Console.ReadLine());
                Trainees.Add(t);
            }

            Console.WriteLine("after add from user");
            foreach (object i in Trainees)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("what index of trainee you need delet");
            int y = int.Parse(Console.ReadLine());
            Trainees.RemoveAt(y);

            Console.WriteLine("after remove");
            foreach (object i in Trainees)
            {
                Console.WriteLine(i);
            }


        }





        }

    }
        