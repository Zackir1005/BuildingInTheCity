using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingInTheCity {
    class Address {
        private string Street, Number;
        public Address() {
            Street = "Lenina";
            Number = "1A";
        }
    }
    class House {
        public Address myAddress = new Address();
        public int FloorCount = 0, 
            Floor = 0, 
            FlatCount = 0,
            flat = 0;
    public void Build() {
            Console.WriteLine("Дом построен снесён");
        }
        public void Destroy() {
            Console.WriteLine("Дом снесён");
        }
        class Flat {
            public int Floor = 0,
                NumberInHouse = 0,
                NumberOfHouse = 0;
            public decimal Square = 0;
        }
    }
    class Program {
        static void Main(string[] args) {

        }
    }
}//Dodelay proekt
