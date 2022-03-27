using System;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agrego comentario para firstCommit del branch LM
            Character p1,p2;
            p1 = new Character("p1",100,70,"ataque1");
            p2 = new Character("p2",100,75,"ataque2");
            Character p3 = new Character("p3",70,85,"ataque3");
            

            Console.WriteLine($"{p1.Nickname} saludable: {p1.Healthy()}");
            Console.WriteLine($"{p2.Nickname} saludable: {p2.Healthy()}");
            Console.WriteLine($"{p3.Nickname} saludable: {p3.Healthy()}");
            Console.WriteLine();

            Console.WriteLine($"El personaje {p1.Nickname} ataca al personaje {p3.Nickname}");
            p1.Attack(p3);

            Console.WriteLine();
            Console.WriteLine($"{p1.Nickname} Salud:: {p1.Life}");
            Console.WriteLine($"{p2.Nickname} Salud: {p2.Life}");
            Console.WriteLine($"{p3.Nickname} Salud: {p3.Life}");
            Console.WriteLine();

            Console.WriteLine($"{p3.Nickname} saludable: {p3.Healthy()}");

            


            
        }
    }
}
