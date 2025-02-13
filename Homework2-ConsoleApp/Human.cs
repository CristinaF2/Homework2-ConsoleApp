namespace Homework2_ConsoleApp
{
     class Human
    {
        public string name;
        public int age;
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
