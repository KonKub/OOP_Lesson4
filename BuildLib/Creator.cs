using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildLib
{

    //---Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания.
    //---Для этого изменить модификатор доступа к конструкторам класса, 
    //---в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания.
    //---В классе Creator все методы сделать статическими, конструктор класса сделать закрытым.
    //---Для хранения объектов класса здания в классе Creator использовать хеш-таблицу.
    //---Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы.
    //---Создать тестовый пример, работающий с созданными классами.

    public class Creator
    {
        private static Hashtable _buildings = new Hashtable();

        private Creator() 
        {
            _buildings = new Hashtable();
        }

        /// <summary>
        /// Создать здание.
        /// </summary>
        /// <param name="ApartmentsAmount">Количество квартир в доме.</param>
        public static void CreateBuild(ushort ApartmentsAmount)
        {
            Building B = new Building();
            B.Height = 3.2f;
            B.FloorsAmount = 1;
            B.ApartmentsAmount = ApartmentsAmount;
            B.EntrancesAmout = 1;
            _buildings.Add(B.Number, B);
        }

        /// <summary>
        /// Создать здание.
        /// </summary>
        /// <param name="Height">Высота здания.</param>
        /// <param name="ApartmentsAmount">Количество квартир в доме.</param>
        public static void CreateBuild(float Height, ushort ApartmentsAmount)
        {
            Building B = new Building();
            B.Height = Height;
            B.FloorsAmount = 1;
            B.ApartmentsAmount = ApartmentsAmount;
            B.EntrancesAmout = 1;
            _buildings.Add(B.Number, B);
        }

        /// <summary>
        /// Создать здание.
        /// </summary>
        /// <param name="Height">Высота здания.</param>
        /// <param name="ApartmentsAmount">Количество квартир в доме.</param>
        /// <param name="FloorsAmount">Количество этажей.</param>
        public static void CreateBuild(float Height, ushort ApartmentsAmount, ushort FloorsAmount)
        {
            Building B = new Building();
            B.Height = Height;
            B.FloorsAmount = FloorsAmount;
            B.ApartmentsAmount = ApartmentsAmount;
            B.EntrancesAmout = 1;
            _buildings.Add(B.Number, B);
        }

        /// <summary>
        /// Создать здание.
        /// </summary>
        /// <param name="Height">Высота здания.</param>
        /// <param name="ApartmentsAmount">Количество квартир в доме.</param>
        /// <param name="FloorsAmount">Количество этажей.</param>
        /// <param name="EntrancesAmout">Количество подъездов.</param>
        public static void CreateBuild(float Height, ushort ApartmentsAmount, ushort FloorsAmount, ushort EntrancesAmout)
        {
            Building B = new Building();
            B.Height = Height;
            B.FloorsAmount = FloorsAmount;
            B.ApartmentsAmount = ApartmentsAmount;
            B.EntrancesAmout = EntrancesAmout;
            _buildings.Add(B.Number, B);
        }

        /// <summary>
        /// Удалить здание из таблицы.
        /// </summary>
        /// <param name="Number">Номер здания.</param>
        public static void DeleteBuild(uint Num)
        {
            if (_buildings.ContainsKey(Num))
            {
                _buildings.Remove(Num);
                Console.WriteLine($"Здание с номером {Num} удалено из списка.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Нет здания с номером {Num}.");
                Console.ResetColor();
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Вывод списка зданий.
        /// </summary>
        public static void ShowBuilds()
        {
            if (_buildings.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Список зданий:");
                Console.ResetColor();

                foreach (DictionaryEntry dic in _buildings)
                {
                    Building b = (Building)(dic.Value);
                    Console.WriteLine($"Номер: {dic.Key}; Высота: {b.Height}; Этажей: {b.FloorsAmount}; Квартир: {b.ApartmentsAmount}; Подъездов: {b.EntrancesAmout}.");
                }
            }
            else
            {
                //Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет зданий в списке.");
                Console.ResetColor();
            }
            Console.WriteLine("");
        }

        public static void BuildInfo(uint Num)
        {
            if (_buildings.ContainsKey(Num))
            {
                Building b = (Building)(_buildings[Num]);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Информация о здании:");
                Console.ResetColor();
                Console.WriteLine($"Номер: {b.Number}; Высота: {b.Height}; Этажей: {b.FloorsAmount}; Квартир: {b.ApartmentsAmount}; Подъездов: {b.EntrancesAmout}.");
                Console.WriteLine($"Высота этажа: {b.FloorHeight()}; квартир в подъезде: {b.ApartmentsInEntrance()}; квартир на этаже: {b.ApartmentsPerFloor()}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Нет здания с номером {Num}.");
                Console.ResetColor();
            }
            Console.WriteLine("");
        }
    }
}
