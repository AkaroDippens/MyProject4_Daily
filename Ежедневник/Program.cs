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
        public static int Pereclucheniye = 1;
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

            Notes practica = new Notes()
            {
                Day = 25,
                Month = 10,
                Year = 2022,
                Name = "Cделать практическую по c#",
                Description = "да ну не, лучше пойду посплю и сделаю завтра",
            };
            Notes.MyNotes.Add(practica);

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
            Console.WriteLine($"Выбрана дата: {data.AddDays(Pereclucheniye).Day}.{data.Month}.{data.Year}");
            Console.SetCursorPosition(3, 1);
            foreach (var value in Notes.MyNotes)
            {
                if (value.Day == data.AddDays(Pereclucheniye).Day)
                {
                    Console.WriteLine($"{1}.{value.Name}");

                }
            }
            Console.SetCursorPosition(0, position);
        }
        static void clavisha(ConsoleKeyInfo Key)
        { 
            switch (Key.Key)
            {
                case ConsoleKey.LeftArrow:
                    Pereclucheniye = NewMethod1();
                    break;
                case ConsoleKey.RightArrow:
                    Pereclucheniye = NewMethod();
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
                    Result();
                    break;
            }
            Kursorik();

        }

        private static int NewMethod()
        {
            return Pereclucheniye + 1;
        }
        private static int NewMethod1()
        {
            return Pereclucheniye - 1;
        }
        private static void Kursorik()
        {
            Console.Clear();
            Console.SetCursorPosition(0, kursor);
            Console.Write("->");
        }
        private static void Result()
        {            
            foreach (var value in Notes.MyNotes)
            {
                if (value.Day == data.AddDays(Pereclucheniye).Day)
                {
                    Console.WriteLine($"{value.Name}\n" +
                        $"Описание: {value.Description}\n " +
                        $"Дата: {value.Day}.{value.Month}.{value.Year}");

                }
            }
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
    
}

