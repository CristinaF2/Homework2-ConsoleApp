namespace Homework2_ConsoleApp
{
    public class Program
    {


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

        public static void DivisibleNumber()
        {
            string answer = "Yes";
 
            //introduc o valoare numerica de la tastatura
            int value = InputNumericValue();

            while (answer=="Yes") {

                //presupunem ca numarul este divizibil cu 7 si 11
                bool isNumberDivisible = true;

                //daca numarul nu se imparte exact la 7 sau nu se imparte exact la 11 atunci numarul
                //nu este divizibil cu 7 si cu 11
                //si punem flagul pe false fiindca se pare ca am presupus gresit initial ca ar fi divizibil cu 7 si 11
                if ((value % 7 != 0) || (value % 11 != 0))
                {

                    isNumberDivisible=false;
                }

                //daca numarul se imparte exact la 7 si la 11 atunci flagul ramane pe true
                //si nu intra in if ul de mai sus
                if (isNumberDivisible)
                {

                    Console.WriteLine($"Number {value} is divisible by 7 and 11 !");
                }
                else
                {
                    Console.WriteLine($"Number {value} is not divisible by 7 and 11 !");
                }

                Console.WriteLine("Do you want to check another number ? If you do, please answer with Yes ");
                answer = Console.ReadLine();

                if (answer.ToLower()=="yes")
                {
                    value = InputNumericValue();
                }
                else
                {
                    break;
                }

            }
        }

        public static void LeapYear()
        {

            //stocheaza daca anul este bisect sau nu
            bool isLeapYear;

            string answer = "Yes";

            //introduc un an de la tastatura
            Console.WriteLine("Please input a valid year:");
            string input = Console.ReadLine();
            bool isInputParsedToInt = int.TryParse(input, out int parsedValue);

            //cat timp exista o valoare introdusa se verifica daca este an bisect
            while (answer.ToLower() =="yes")
            {
                //presupunem ca anul este bisect
                isLeapYear = true;

              
                //verifica daca valoarea (nu este divizibila cu  4 sau este divizibila cu 100)
                //si (nu este divizibila cu 400)
                //adica conditia negata pt ca un an sa fie bisect
                //daca valoarea indeplineste conditia atunci inseamna ca anul nu este bisect
                //fiindca un an este bisect daca (este divizibil la 4 si nu este divizibil cu 100 )
                //sau (daca este divizibil cu 400)

                if ((parsedValue % 4 != 0 || parsedValue % 100 == 0) && parsedValue % 400 != 0)

                {

                    isLeapYear=false;
                }


                if (isLeapYear)
                {

                    Console.WriteLine($"Number {parsedValue} is leap year !");
                }
                else
                {
                    Console.WriteLine($"Number {parsedValue} is not leap year !");
                }

                Console.WriteLine("Do you want to check another year ? If you do, please answer with Yes ");
                answer = Console.ReadLine();

                if (answer.ToLower()=="yes")
                {
                    Console.WriteLine("Please input a valid year:");
                    input = Console.ReadLine();
                    isInputParsedToInt = int.TryParse(input, out parsedValue);
                }
                else
                {
                    break;
                }

            }

        }
        public static bool IsPrime(int number)
        {
            //daca nr e <=1 nu este prim
            if (number <= 1) return false;

            //un numar este prim daca se imparte exact doar la 1 si la el insusi
            //deci parcurgem toate valorile de la 2 si pana la radical din numar
            //si verificam daca numarul se imparte exact la acea valoare
            //daca se gaseste cel putin o valoare la care se imparte exact atunci nu este prim
            //verificarea se face pana la radical din numar fiindca
            //daca numarul are un divizor mai mare decât radical din el, acesta va avea și un divizor mai mic decât radicalul lui
            //deci nu tre sa verificam mai departe de radical din numar

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                //verificam daca numarul se imparte exact la i
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void ShowThe47ThPrimeNumber()
        {
            //va stoca cate numere prime se gasesc
            int count = 0;

            //se inecepe de la primul nr prim
            int number = 2;

            //cat timp nu am ajuns la al 47 lea nr prim
            while (count < 47)
            {
                //se verifica daca nr este prim
                if (IsPrime(number))
                {
                    //daca da atunci se incrementeaza count fiindca am gasit un nr prim
                    count++;
                }
                //se trece la urmatorul numar 
                number++;

            }
            //fiindca cand s-a gasit al 47 lea nr prim adica count=47 si s-a iesit din while
            //numarul deja era incrementat cu 1
            //valoarea celui de al 47 lea nr prim trebuie decrementata cu 1
            Console.WriteLine($"The 47th prime number is: {number - 1}");

        }

        public static void SumOfEvenValuedTermsOfFibonacciSequence()
        {
            //sirul Fibonacci se construieste in felul urmator:
            //se porneste de la primele 2 valori: 1 si 2, apoi valoarea urmatoare este suma ultimelor 2 valori 
            //adica urmatoarele valori sunt 3, 5, 8, 13, 21, 34, 55 etc

            List<int> list = new List<int>() { 1, 2 };
            int i = 0;

            //construieste o lista Fibonnaci cat timp suma ultimelor 2 valori este <1000
            //daca suma este >=1000 nu mai adaug elemente in lista
            while ((list[i]+list[i+1]) <1000)
            {
                list.Add(list[i]+list[i+1]);
                i++;
            }

            //parcurg lista si afisez toate valorile din lista
            foreach (var item in list)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();

            int sum = 0;

            //parcurg lista si fac suma tuturor numerelor pare din lista
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    sum+=item;
                }
            }
            Console.WriteLine($"The sum of the even-valued terms less than 1000 is {sum}! ");

        }

        //functie care verifica daca valoarea introdusa este numerica
        public static int InputNumericValue()
        {
            Console.WriteLine("Please input a number:");
            string input = Console.ReadLine();
            bool isInputParsedToInt = int.TryParse(input, out int parsedValue);

            //cat timp valoarea introdusa nu a putut fi convertita la int sau valoarea convertita este 0 citesc alta valoare
            while ((!isInputParsedToInt) || (parsedValue==0))
            {

                Console.WriteLine("The input value is not a valid number !! ");
                input = Console.ReadLine();
                isInputParsedToInt = int.TryParse(input, out parsedValue);
            }
            //returnam valoarea convertita la int
            return parsedValue;
        }

        //metoda care face suma cifrelor unui numar
        public static void SumOfDigits(int value)
        {
            int nextDigit = 0;
            int sumOfDigits = 0;

            //pastram numarul intr o copie fiindca la iesirea din while 
            //valoarea numarului este 0 si avem nevoie de valoarea initiala pt a o afisa
            int copyOfValue = value;

            //cat timp numarul este >0,adica mai are cifre
            while (value>0)
            {
                //obtine ultima cifra
                nextDigit=value % 10;
                //adauga cifra la suma
                sumOfDigits=sumOfDigits+nextDigit;
                //obtine numarul fara ultima cifra
                value=value/10;

            }
            Console.WriteLine($"Suma cifrelor numarului {copyOfValue} este: {sumOfDigits}");
        }


        public static void ConvertBinaryValueToDecimal()
        {
            Console.WriteLine("Please input a binary value:");
            string input = Console.ReadLine();

            //cat timp valoarea introdusa nu este binara cauta alta valoarea
            while (IsBinary(input)==false)
            {
                Console.WriteLine($"The value {input} is not a binary value ");
                input = Console.ReadLine();

            }

            double decimalValue = 0;

            //mai jos se parcurge fiecare caracter din string , se transforma in valoare numerica 
            //si se formeaza valoarea decimala in felul urmator:
            //daca valoarea binara este 0110001
            //atunci valoarea decimala se calculeaza 0*2^6 + 1*2^5 +1*2^4+ 0*2^3 + 0*2^2+ 0*2^1 +1*2^0
            //se merge maxim pana la 2^(string.Length -1) fiindca se porneste de la  2^0 

            int y = input.Length-1;

            foreach (char c in input)
            {
                //transforma caracterul in string si apoi se converteste in int
                int value = int.Parse(c.ToString());
                //se formeaza valoarea decimala   digit1*2^(y)+digit2*2^(y-1) +digit3*2^(y-2) +..+digitX*2^0
                decimalValue= decimalValue + (value* Math.Pow(2, y));
                //se decrementeaza y la fiecare trecere prin bucla pana ajunge la 0
                y--;

            }


            Console.WriteLine($"The decimal value of the following binary value {input} is {decimalValue}");

        }

        public static bool IsBinary(string binaryValue)
        {
            //parcurge fiecare caracter din string
            //si verifica daca exista cel putin unul diferit de caracterele 0 si 1
            //daca gaseste cel putin unul returneaza false altfel inseamna ca valoarea este formata doar din caractere 0 si 1
            //adica numarul este binar
            foreach (char c in binaryValue)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;

        }

        public static void ConvertDecimalToBinary()
        {
            //introducem o valoare numerica de la tastatura
            int decimalNumber = InputNumericValue();
            string binary = "";
            int remainder = 0;

            //facem o copie a nr introdus fiindca la iesirea din while numarul va avea valoarea 0 si dorim sa afisam in consola
            //numarul introdus initial
            int copyOfDecimalNumber = decimalNumber;

            //pentr numarul 13 binarul se calculeaza :
            //13:2 => rest 1, cat 6
            //6:2=> rest 0, cat 3
            //3:2=> rest 1, cat 1
            //1:2=> rest 1, cat 0
            //deci nr binar va fi 1101 (restul citit invers, de la ultimul obtinut la primul)

            //cat timp valoarea decimala e >0
            while (decimalNumber > 0)
            {
                //ia restul numarului impartit la 2
                remainder=decimalNumber % 2;
                //la rest adauga binarul construit anterior
                binary=remainder +binary;
                //imparte nr la 2 si stocheaza in numar catul rezultatului
                decimalNumber=decimalNumber/2;

            }
            Console.WriteLine($"Valoare binara a numarului {copyOfDecimalNumber} este: {binary} ");
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
            bool isListSizeParsed = int.TryParse(listSizeInput, out int listSize);


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
            int sumOfEvenNumbers = 0;
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

           

            PrintNumbers();
           */
            Console.WriteLine("------/Divisible number with 7 and 11/-------");
            DivisibleNumber();
            Console.WriteLine();

            Console.WriteLine("------/Leap Year/-------");
            LeapYear();
            Console.WriteLine();

            Console.WriteLine("------/Show The 47Th Prime Number/-------");
            ShowThe47ThPrimeNumber();
            Console.WriteLine();

            Console.WriteLine("------/Sum Of Even Valued Terms Of Fibonacci Sequence/-------");
            SumOfEvenValuedTermsOfFibonacciSequence();
            Console.WriteLine();

            Console.WriteLine("------/Sum Of Digits/-------");
            int number = InputNumericValue();
            SumOfDigits(number);
            Console.WriteLine();

            Console.WriteLine("------/Convert Binary Value To Decimal/-------");
            ConvertBinaryValueToDecimal();
            Console.WriteLine();

            Console.WriteLine("------/Convert Decimal To Binary/-------");
            ConvertDecimalToBinary();
            Console.WriteLine();

        }

    }
}

