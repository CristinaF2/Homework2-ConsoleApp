
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
        }
    }
}
