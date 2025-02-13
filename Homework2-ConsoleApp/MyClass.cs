namespace Homework2_ConsoleApp
{
    public class MyClass
    {
        public string name;

        //daca avem un constructor privat, alte clase nu pot deriva din aceasta clasa
        //si nici nu se poate crea o instanta a acestei clase
        private MyClass() { }
        public MyClass(string name)
        {
            this.name=name;
        }
        public MyClass(MyClass copy)
        {
            name=copy.name;
        }

        //static constructor cannot have parameters or access modifier
         static MyClass()
        {
            Console.WriteLine("Static constructor");
        }

        public static void Print()
        {
            Console.WriteLine("Method");
        }

        //destructorul se apeleaza implicit de catre .net framework's garbage collector cand obiectul nu mai e necesar
       
    }
}
