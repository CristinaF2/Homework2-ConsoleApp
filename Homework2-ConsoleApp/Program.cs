using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework2_ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            
             Person.DisplayUserDetails();  

             Console.WriteLine();
             int numar;

             while (true)
             {
                 Console.WriteLine("Introduceti un număr:");
                 string input = Console.ReadLine();

                 //bool int.TryParse(string s, out int result);
                 //s: The string you want to convert to an integer.
                 //result: The output variable that will store the converted integer if the conversion is successful.
                 //Return value: A bool indicating whether the conversion succeeded(true) or failed(false).

                 if (int.TryParse(input, out numar))
                 {
                     break; 
                 }
                 else
                 {
                     Console.WriteLine("Introduceti va rog un număr valid!");
                 }
             }
             VerificaParPozitivSauNegativ(numar);
             Console.WriteLine();

             // Add skills
             Person.AddSkill("Cooking");
             Person.AddSkill("Photography");
             Person.AddSkill("Programming");
             Person.AddSkill("Testing");
             Person.AddSkill("Ninja");
             Person.AddSkill("Swimming");
             Person.AddSkill("CIA");
             Person.AddSkill("Dancing");
             Person.AddSkill("Singing");

             // Display skills
             Person.DisplaySkills();

             Console.WriteLine();
             Person.CountToWhileDoLoop(110);

             Console.WriteLine();
             Person.CountToDoWhileLoop(130);

             Console.WriteLine();
             Person.CountToWhileDoLoopAndIfCondition(140);
            */
            /*
             Console.WriteLine();
             Person.Test1();

             Console.WriteLine();
             Person.Test2();

             Console.WriteLine();
             Person.Test3();

             Console.WriteLine();
             Person.Test4();


             Console.WriteLine();
             Person.Test5();

             Console.WriteLine();
             Person.Test6();


             Console.WriteLine();
             Person.Test7();


             Console.WriteLine();
             Person.Test8

             Console.WriteLine();
             Person.Test9();

             Console.WriteLine();
             Person.Test10();

          
            Human human1 = new Human("Rick", 16);
            Human human2 = new Human("Morty", 65);
            human1.Eat();
            human2.Eat();
            human1.Sleep();
            human2.Sleep();
          

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            car1.Drive();
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            car2.Drive();
         
            MyClass myClass = new MyClass("Happy");

            MyClass myClassCopy = new MyClass(myClass);

            Console.WriteLine(myClassCopy.name);
            MyClass.Print();
            //first the static constructor is executed and then the Print method

            */

            Person.PrintNumbers();


         
        }

        public static void VerificaParPozitivSauNegativ(int numar)
            {
                if (numar == 0)
                {
                    Console.WriteLine("Numărul este zero si este par, dar nu este nici pozitiv, nici negativ");
                }
                else if (numar % 2 == 0)
                {
                    if (numar > 0)
                    {
                        Console.WriteLine("Numărul este par pozitiv");
                    }
                    else
                    {
                        Console.WriteLine("Numărul este par negativ");
                    }
                }
                else
                {
                   if (numar > 0)
                   {
                      Console.WriteLine("Numărul este impar pozitiv");
                   }
                   else
                   {
                      Console.WriteLine("Numărul este impar negativ");
                   }
                }
            }
     }
}

