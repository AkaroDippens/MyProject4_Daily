using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Ежедневник
{

    public class Program
    {
        public static int position = 1;
        public static int kursor = 1;
        public static int MoveDay = 1;
        public static DateTime data = DateTime.Now;


        static void Main()
        {
            Notes Valik = new Notes()
            {
                Day = 17,
                Month = 10,
                Year = 2022,
                Name = "Пойти в Valorant(прошло)",
                Description = "Сделал минимум 10 килов",
            };
            Notes.MyNotes.Add(Valik);

            Notes Shavuha = new Notes()
            {
                Day = 18,
                Month = 10,
                Year = 2022,
                Name = "Купить шаурмы(прошло)",
                Description = "Пошел в перекресток и забрал последнюю шавуху",
            };
            Notes.MyNotes.Add(Shavuha);

            Notes NextDay = new Notes()
            {
                Day = 19,
                Month = 10,
                Year = 2022,
                Name = "Сделать дз по пайтону",
                Description = "Думаю, как бы ее сделать",
            };
            Notes.MyNotes.Add(NextDay);

            Notes Match = new Notes()
            {
                Day = 20,
                Month = 10,
                Year = 2022,
                Name = "Пойти посмотреть футбольчик",
                Description = "Завтра играет Реал Мадрид - Барселона",
            };
            Notes.MyNotes.Add(Match);

            Notes progulka = new Notes()
            {
                Day = 21,
                Month = 10,
                Year = 2022,
                Name = "Пойти погулять",
                Description = "Пойти с друзьями в парк",
            };
            Notes.MyNotes.Add(progulka);

            Notes Discord = new Notes()
            {
                Day = 22,
                Month = 10,
                Year = 2022,
                Name = "Пойти посидеть в дс с друзьями",
                Description = "Смотреть вместе всякие смешнявки",
            };
            Notes.MyNotes.Add(Discord);

            while (true)
            {
                MyDates();
                ConsoleKeyInfo key = Console.ReadKey();
                clavisha(key);
            }



        }

        private static void MyDates()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Выбрана дата: {data.AddDays(MoveDay).Day}.{data.Month}.{data.Year}");
            Console.SetCursorPosition(3, 1);
            foreach (var item in Notes.MyNotes)
            {
                if (item.Day == data.AddDays(MoveDay).Day)
                {
                    Console.WriteLine($"{1}.{item.Name}");

                }
            }
            Console.SetCursorPosition(0, 0);
        }
        static void clavisha(ConsoleKeyInfo Key)
        {
            switch (Key.Key)
            {
                case ConsoleKey.LeftArrow:
                    MoveDay = MoveDay - 1;
                    break;
                case ConsoleKey.RightArrow:
                    MoveDay = MoveDay + 1;
                    break;
                case ConsoleKey.UpArrow:
                    {
                        position--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        position++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Result();
                    break;

            }

            Kursorik();

        }

        private static void Result()
        {
            int n = 0;
            foreach (var item in Notes.MyNotes)
            {
                if (item.Day == data.AddDays(MoveDay).Day)
                {
                    Console.WriteLine($"{item.Name}\n" +
                        $"Описание: {item.Description}\n " +
                        $"Дата: {item.Day}.{item.Month}.{item.Year}");

                }
            }
            Console.ReadKey();
        }

        private static void Kursorik()
        {
            Console.Clear();
            Console.SetCursorPosition(0, kursor);
            Console.Write("->");
        }
    }
}

