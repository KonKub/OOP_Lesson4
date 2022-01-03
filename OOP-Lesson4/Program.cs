using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuildLib;

namespace OOP_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator.CreateBuild(5);               //добавить здание с 5 квартирами
            Creator.CreateBuild(10f, 17);         //добавить здание вывотой 10 и 17 квартирами
            Creator.CreateBuild(11f, 28, 3);      //добавить здание вывотой 11, 28 квартирами и 3 этажами
            Creator.CreateBuild(21f, 45, 7, 2);   //добавить здание вывотой 21, 45 квартирами, 7 этажами и 2 подъездами



            Creator.ShowBuilds();

            Creator.DeleteBuild(3);

            Creator.ShowBuilds();

            Creator.BuildInfo(1);
            Creator.BuildInfo(2);
            Creator.BuildInfo(3);
            Creator.BuildInfo(4);
            Creator.BuildInfo(5);

            Console.ReadKey();
        }
    }
}
