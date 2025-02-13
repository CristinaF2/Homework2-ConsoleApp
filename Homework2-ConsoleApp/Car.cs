using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_ConsoleApp
{
    public class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model,int year, string color)
        {
            this.make=make;
            this.model=model;
            this.year=year;
            this.color=color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the "+make+ " "+model);
        }
    }
}
