
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
    }
}
