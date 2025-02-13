
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework2_ConsoleApp
{
    public static class Person
    {

        public static string FirstName { get; set; } = "Cristina";
        public static string LastName { get; set; } = "Filipan";
        public static string Gender { get; set; } = "Female";
        public static int Age { get; set; } = 34;

        public static List<string> Skills = new List<string>();

        public static void AddSkill(string skill)
        {
            Skills.Add(skill);
            Console.WriteLine($"Added a new skill: {skill}");
        }

        public static void DisplaySkills()
        {
            Console.WriteLine("\nThe person has the following skills:");
            foreach (string skill in Skills)
            {
                if (skill == "Ninja")
                {
                    // Skip "Ninja"
                    continue;
                }
                else if (skill == "CIA")
                {
                    // Exit loop and display classified message
                    Console.WriteLine("\n>>> Classified information, no further skills are displayed! <<<");
                    break;
                }
                else
                {
                    // Display the skill
                    Console.Write($"{skill}; ");
                }
            }
        }

        public static void CountToWhileDoLoop(int number)
        {
            Console.WriteLine($"Counting to {number}:");
            int counter = 1;
            while (counter < number)
            {
                switch (counter)
                {
                    case 10:
                        Console.WriteLine("\nNumber skipped!");
                        break;
                    case 99:
                        Console.WriteLine("\nCannot count past 99!");
                        return; //exit the method
                    default:
                        Console.Write($"{counter}; ");
                        break;
                }
                counter++;
            }
        }

        public static void CountToWhileDoLoopAndIfCondition(int number)
        {
            Console.WriteLine($"Counting to {number}:");
            int counter = 1;
            while (counter < number)
            {
                if (counter == 10)
                {
                    Console.WriteLine("\nNumber skipped!");
                    counter++;
                    continue;
                }
                else if (counter == 99)
                {
                    Console.WriteLine("\nCannot count past 99!");
                    break;
                }
                Console.Write($"{counter}; ");
                counter++;
            }
        }


        public static void CountToDoWhileLoop(int number)
        {
            Console.WriteLine($"Counting to {number}:");
            int counter = 1;
            do
            {
                switch (counter)
                {
                    case 10:
                        Console.WriteLine("\nNumber skipped!");
                        break;
                    case 99:
                        Console.WriteLine("\nCannot count past 99!");
                        break;
                    default:
                        Console.Write($"{counter}; ");
                        break;
                }
                if (counter==99)
                {
                    break;
                }
                counter++;

            } while (counter < number);
        }

        public static int ComputeAge(int years)
        {
            return Age + years;
        }

        public static void DisplayUserDetails()
        {
            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine($"     - First Name: {FirstName}");
            Console.WriteLine($"     - Last Name: {LastName}");
            Console.WriteLine($"     - Gender: {Gender}");
            Console.WriteLine($"You will be {ComputeAge(15)} years old in 15 years!");
            IsOld();
            ShowGender();
        }

        public static void IsOld()
        {
            if (Age>=100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (Age>=50)
            {
                Console.WriteLine("You are old!");
            }
            else
            {
                Console.WriteLine("You are still young!");
            }
        }

        public static void ShowGender()
        {
            switch (Gender)
            {
                case "Male":
                    Console.WriteLine("You are a male!");
                    break;
                case "Female":
                    Console.WriteLine("You are a female!");
                    break;
                default:
                    Console.WriteLine("You haven't specified your gender!");
                    break;
            }
        }

        public static void Test1()
        {
            Console.WriteLine("How many cool numbers do you want: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i<=count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine($"2 la puterea {i} este: {result}");
            }
        }

        public static void Test2()
        {
            Random numberGen = new Random();

            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;
            Console.WriteLine("Press enter to roll the dice.");

            while (roll1 != roll2)
            {
                Console.ReadKey();
                roll1=numberGen.Next(1, 7);
                roll2=numberGen.Next(1, 7);
                Console.WriteLine("Roll 1: "+ roll1);
                Console.WriteLine("Roll 2: "+ roll2);
                Console.WriteLine();
                attempts++;
            }
            Console.WriteLine($"It took you {attempts} attempts to roll two of a kind.");


        }

        public static void Test3()
        {

            var names = new List<string> { "Scott", "Ana", "Felipe" };
            names.Add("David");
            names.Add("Damian");
            names.Add("Maria");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            Console.WriteLine(names[2]);
            Console.WriteLine(names[names.Count-1]);

            //display Damian (second from last)
            Console.WriteLine(names[^2]);


            //names[2..4]: names[2] is included, names[4] is not included
            foreach (string name in names[2..4])
            {
                Console.WriteLine($"Helop {name.ToUpper()}!");
            }
            Console.WriteLine();
            var names2 = new string[] { "Vasile", "Ana", "Felipe" };
            names2= [.. names2, "Cristina"];

            foreach (string name in names2)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        public static void Test4()
        {
            string[] movies = new string[4];
            Console.WriteLine("Type in four movies: ");

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

        public static void Test5()
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);

            Console.WriteLine("------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

        }

        public static void Test6()
        {
            Console.Write("\nHow many students are in the class: ");

            int noOfStudents = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[noOfStudents];

            Console.WriteLine("Please input the names of the students: ");
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }

            Array.Sort(students);

            Console.WriteLine("----------------------");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

        }
        public static void Test7()
        {
            string[] cars = { "BMW", "Mercedes", "Mustang", "Corvette" };
            Console.WriteLine(cars[1]);

            Console.WriteLine("--------------------");

            cars[0]="Tesla";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);

            }
            Console.WriteLine("--------------------");
            string[] cars2 = new string[3];
            cars2[0]="Volvo";
            cars2[1]="Audi";
            cars2[2]="Peugeot";

            for (int i = 0; i < cars2.Length; i++)
            {
                Console.WriteLine(cars2[i]);

            }
        }

        public static void Test8()
        {
            decimal[] weeklyCalories = new decimal[7];
            decimal total = 0;

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine($"Calories for day {i+1}: ");
                weeklyCalories[i]=decimal.Parse(Console.ReadLine());
                total+=weeklyCalories[i];
            }
            decimal averageKcalIntake = total/7;
            decimal recommendedKcalIntake = 3000;
            decimal threeMonthsKcalBalance = (averageKcalIntake-recommendedKcalIntake)*90;
            decimal weightChangeInKg = threeMonthsKcalBalance/7000;
            Console.WriteLine($"This will be your weigth change in 3 months: {weightChangeInKg}");

        }
        //array enter cati bani salvezi in fiecare zi pe 10 zile
        //calculare economisezi in medie pe zi
        //cati bani salvezi in 356 zile
        public static void Test9()
        {
            decimal[] weeklyCalories = new decimal[7];
            decimal total = 0;

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine($"Calories for day {i+1}: ");
                weeklyCalories[i]=decimal.Parse(Console.ReadLine());
                total+=weeklyCalories[i];
            }
            decimal averageKcalIntake = total/7;
            decimal recommendedKcalIntake = 3000;
            decimal threeMonthsKcalBalance = (averageKcalIntake-recommendedKcalIntake)*90;
            decimal weightChangeInKg = threeMonthsKcalBalance/7000;
            Console.WriteLine($"This will be your weigth change in 3 months: {weightChangeInKg}");


        }

        public static void Test10()
        {
            decimal[] dailySavings = new decimal[10];
            decimal total = 0;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Savings for day {i+1}: ");
                dailySavings[i]=decimal.Parse(Console.ReadLine());
                total+=dailySavings[i];
            }
            decimal averageSavings = total/10;
            decimal savingsPerYear = averageSavings*360;
           
            Console.WriteLine($"This will be your savings in 1 year: {savingsPerYear}");


        }


        public static void Test11()
        {
            List<string> food = new List<string>();
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            food.Insert(0, "sushi");
            food.Add("fries");

            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.LastIndexOf("fries"));
            Console.WriteLine(food.Contains("pizza"));
            food.Sort();
            food.Reverse();
            food.Clear();
            string[] foodArray=food.ToArray();

            foreach (string item in foodArray)
            {
                Console.WriteLine(item);
            }
        
        } 

        public static void Test12()
        {
            var name1 = "Scott";
            var names = new List<string> { "<name1>", "Ana", "Felipe" };
          
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }

            names.Add("David");
            names.Add("Damian");
            names.Add("Maria");


            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

        }

        public static void PrintNumbers()
        {

            List<int> list = new List<int>();


            /*
            while (true) 
            {
               
                Console.WriteLine($"Please input the size of the list:");
                if (int.TryParse(Console.ReadLine(), out listSize) && listSize > 0)
                {
                    break;     //Ieșim din buclă dacă dimensiunea este un număr valid și pozitiv
                }
                else
                {
                    Console.WriteLine("!!! The size of the list must be a positive number greater than 0 !!! ");
                }
            }
            */
            
            Console.WriteLine($"Please input the size of the list:");
            string listSizeInput = Console.ReadLine();
            bool isListSizeParsed = int.TryParse(listSizeInput, out int  listSize);
           
           
            while (isListSizeParsed==false || listSize <= 0)
            {
                Console.WriteLine("!!! The size of the list must be a positive number greater than 0 !!! ");
                Console.WriteLine($"Please input again the size of the list:");
                listSizeInput = Console.ReadLine();
                isListSizeParsed = int.TryParse(listSizeInput, out listSize);
            }
            
           

            for (int i = 0; i < listSize; i++)
            {
                Console.WriteLine($"Please input a number for list[{i}]:");
                string input = Console.ReadLine();
                bool isNumberParsed = int.TryParse(input, out int number);


                while (isNumberParsed==false)
                {
                    Console.WriteLine("!! You have not entered a valid number !!");
                    Console.WriteLine($"Please input a number for list[{i}]:");
                    input = Console.ReadLine();  
                }

                list.Add(number); 
            }
       


            Console.Write("Your list contains the following items: ");
            foreach (var item in list)
            {
                Console.Write(item+"; ");
            }

            Console.WriteLine();
            Console.Write("The list of even numbers is: ");
            bool existEvenNumbers = false;
            foreach (var item in list)
            {
                if (item % 2==0)
                {
                    Console.Write(item+"; ");
                    existEvenNumbers = true;
                }
               
            }
            if (!existEvenNumbers)
            {
                Console.Write("empty");
            }

            Console.WriteLine();

            bool existOddNumbers = false;
            Console.Write("The list of odd numbers is: ");
            foreach (var item in list)
            {
                if ((item % 2==1)|| (item % 2==-1))
                {
                    Console.Write(item+"; ");
                    existOddNumbers=true;
                }
            }
            if (!existOddNumbers)
            {
                Console.Write("empty");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("The sum of even numbers is: ");
            int sumOfEvenNumbers=0;
            foreach (var item in list)
            {
                if (item % 2==0)
                {
                     sumOfEvenNumbers +=item;
                }
                
            }
            Console.WriteLine(sumOfEvenNumbers);

            int sumOfOddNumbers = 0;
            Console.Write($"The sum of odd numbers is: ");
            foreach (var item in list)
            {
                if ((item % 2==1) || (item % 2==-1))
                {
                    sumOfOddNumbers +=item;
                    
                }
               
            }
            Console.WriteLine(sumOfOddNumbers);
           
        }

    }
}