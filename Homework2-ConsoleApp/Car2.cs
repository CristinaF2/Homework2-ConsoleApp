using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_ConsoleApp
{
    public class Car2
    {
        public string Make {  get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public Car2(string make, string model, int year)
        {
            Make=make;
            Model=model;
            Year=year;
        }
    }
}
