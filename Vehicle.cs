using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    interface IVehicle
    { 
        void Drive();
        bool Refuel();
    }

    internal class Vehicle : IVehicle
    {
        private int fuel;
        private int maxFuel;
        private string brand;
        private string model;
        private string type;
        private string milage;
        public Vehicle(int maxFuel, string brand, string model, string type, string milage)
        {
            this.maxFuel = maxFuel;
            this.brand = brand;
            this.model = model;
            this.type = type;
            this.milage = milage;
        }

        public void Drive()
        {
            System.Console.WriteLine("Samochod jedzie");
            if(fuel == 0)
            {
                System.Console.WriteLine("Nigdzie nie pojedziesz, bak jest pusty");
            } else if(fuel <= 5)
            {
                System.Console.WriteLine("Jedziesz na rezerwie, zatankuj na nastepnej stacji");
            }

            fuel -= 5;
        }

        public bool Refuel()
        {
            fuel = maxFuel;
            return true;
        }
    }
}
