using System;
/*1)Неявное преобразование простых и ссылочных типов, в виде 
комментариев внести в программу таблицу неявных преобразований;*/
//Неявное преобразование ссылочных типов, от производного Pet к базовому Animal
Pet cat = new Pet("Lypus", "cat");
Animal home_animal = cat;   // преобразование от Pet к Animal
Console.WriteLine(home_animal.Name);

namespace Task1
{
    class Task1_1
    {
        static void Main(string[] args)
        {
            //Неявное преобразование простых типов
            float Pi = 3.14F;
            double P = Pi; //float в double
            int t = 3;
            P = t; //int в double
            char i = '5';
            t = i; //char в int
            /*Таблица неявных преобразований
              sbyte  -> short , int, long, float, double или decimal
              byte   -> short, ushort, int, uint, long, float, double или decimal 
              short  -> int , long, float, double или decimal
              ushort -> int , uint, long, ulong, float, double или decimal
              int    -> int , uint, long, ulong, float, double или decimal
              uint   -> long , ulong, float, double или decimal
              long   -> long , ulong, float, double или decimal
              char   -> ushort , int, uint, long, ulong, float, double или decimal
              float  -> double
              ulong  -> float , double или decimal*/            
        }
    }
}
//Класс Animal
class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Animal {Name}");
    }
}

//Наследник класса Animal
class Pet : Animal
{
    public string Type { get; set; }
    public Pet(string name, string pet) : base(name)
    {
        Type = pet;
    }
}