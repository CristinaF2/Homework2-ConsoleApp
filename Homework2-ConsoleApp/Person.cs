
namespace Homework2_ConsoleApp
{
    public static class Person
    {

        public static string FirstName { get; set; } = "Cristina";
        public static string LastName { get; set; } = "Filipan";
        public static string Gender { get; set; } = "Female";
        public static int Age { get; set; } = 34;

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
