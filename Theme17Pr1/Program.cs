﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите возраст ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Введите имя ");
            //string name = Console.ReadLine();
            //Console.Write("Введите фамилию ");
            //string surname = Console.ReadLine();
            //Console.Write("Введите название компании ");
            //string company = Console.ReadLine();
            //Console.Write("Введите название работы ");
            //string job = Console.ReadLine();
            //Person p1 = new Person(age);
            //p1.Print();
            //Console.WriteLine();
            //Person p2 = new Person(age,name,surname);
            //p2.Print();
            //Employee p3 = new Employee(age,name,surname, company, job);
            //p3.Print();

            Console.Write("Введите кол-во копийй ");
            int copies = int.Parse(Console.ReadLine());
            Console.Write("Введите название газеты ");
            string name = Console.ReadLine();
            Console.Write("Введите стоимость одной газеты ");
            int price int.Parse(Console.ReadLine());
            Magazine x = new Magazine(copies,name,price)



            Console.ReadKey();




        }
    }
}
