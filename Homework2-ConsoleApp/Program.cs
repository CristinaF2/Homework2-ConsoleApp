namespace Homework2_ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person.DisplayUserDetails();
            Person.IsOld();
            Person.ShowGender();

            Console.WriteLine();
            Console.WriteLine("Introduceti un număr:");
            string input = Console.ReadLine();
            int numar = Convert.ToInt32(input);

            VerificaParPozitivSauNegativ(numar);


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
                    Console.WriteLine("Numărul este impar");
                }
            }
     }
}

