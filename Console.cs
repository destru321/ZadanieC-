using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    internal class ConsoleApp
    {
        public void testPerson()
        {
            String[] persons = new string[3];
            for(int i = 0; i < 3; i++) 
            {
                Console.Write("Wprowadz imie: ");
                persons[i] = Console.ReadLine();
            }

            Person p = new Person(persons);
            Console.WriteLine();
            Console.Write("Wybierz osobe przez id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            p.getPersonByID(id);
            Console.WriteLine();
            p.ToString();
        }

        public void testFotobook()
        {
            Console.WriteLine("1. Mala fotoksiazka");
            Console.WriteLine("2. Duza fotoksiazka");
            Console.Write("Wybor: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wprowadz nazwe fotoksiazki: ");
            string name = Console.ReadLine();

            Console.Write("Wprowadz opis fotoksiazki: ");
            string desc = Console.ReadLine();

            if (choice == 1)
            {
                Console.Write("Domyslna ilosc stron to 16 czy chcesz wprowadzic inna liczbe?: (Yes/No) ");
                string irregularPages = Console.ReadLine();

                if (irregularPages == "Yes")
                {
                    Console.Write("Wprowadz swoja liczbe stron: ");
                    int pages = Convert.ToInt32(Console.ReadLine());

                    FotoBook f = new FotoBook(name, desc, pages);
                    Console.WriteLine();
                    f.getNumPages();
                    Console.WriteLine();
                    f.ToString();
                }
                else
                {
                    FotoBook f = new FotoBook(name, desc);
                    Console.WriteLine();
                    f.getNumPages();
                    Console.WriteLine();
                    f.ToString();
                }
            } 
            else
            {
                Console.Write("Domyslna ilosc stron to 64 czy chcesz wprowadzic inna liczbe?: (Yes/No) ");
                string irregularPages = Console.ReadLine();

                if (irregularPages == "Yes")
                {
                    Console.Write("Wprowadz swoja liczbe stron: ");
                    int pages = Convert.ToInt32(Console.ReadLine());

                    FotoBook f = new FotoBook(name, desc, pages);
                    Console.WriteLine();
                    f.getNumPages();
                    Console.WriteLine();
                    f.ToString();
                }
                else
                {
                    FotoBook f = new FotoBook(name, desc);
                    Console.WriteLine();
                    f.getNumPages();
                    Console.WriteLine();
                    f.ToString();
                }
            }
        }

        public void testVehicle()
        {
            Vehicle v = new Vehicle(30, "toyota", "yaris", "sedan", "177903");
            v.Refuel();
            v.Drive();
            v.Drive();
            v.Drive();
            v.Drive();
            v.Drive();
            v.Drive();
            v.Drive();

            Console.WriteLine();
            Console.WriteLine("Uzycie refuela: ");
            v.Refuel();
            v.Drive();
        }

        public void testAnimal()
        {
            Dog dog = new Dog();
            Console.Write("Nazwij psa: ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Twoj pies nazywa sie {dog.GetName()}");
            Console.WriteLine(dog.Sound());
            dog.Eat();

            Cat cat = new Cat();
            Console.Write("Nazwij kota: ");
            cat.SetName(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Twoj kot nazywa sie {cat.GetName()}");
            Console.WriteLine(cat.Sound());
            cat.Eat();

            Pig pig = new Pig();
            Console.Write("Nazwij swinke: ");
            pig.SetName(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Twoja swinka nazywa sie {pig.GetName()}");
            Console.WriteLine(pig.Sound());
            pig.Eat();
        }

        public static void Main(string[] args)
        {
            ConsoleApp cls = new ConsoleApp();
            Console.WriteLine();
            Console.WriteLine("Zadanie 1");
            Console.WriteLine();
            cls.testPerson();
            Console.WriteLine();
            Console.WriteLine("Zadanie 3");
            Console.WriteLine();
            cls.testFotobook();
            Console.WriteLine();
            Console.WriteLine("Zadanie 4");
            Console.WriteLine();
            cls.testVehicle();
            Console.WriteLine();
            Console.WriteLine("Zadanie 5");
            Console.WriteLine();
            cls.testAnimal();
        }
    }
}
