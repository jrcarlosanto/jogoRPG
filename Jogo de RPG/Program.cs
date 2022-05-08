using Jogo_de_RPG.src.Entities;
using System;

namespace Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, 749, 72, "Knight");
            Ninja ninja = new Ninja("Wedge", 42, 574, 89, "Ninja");
            Wizard wizard = new Wizard("Jenneca", 23, 611, 482 , "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Topapa", 23, 385, 641, "Black Wizard");

            Console.WriteLine(arus.ToString());
            Console.WriteLine(ninja);
            Console.WriteLine(wizard);
            Console.WriteLine(blackWizard);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(10));
            Console.WriteLine(blackWizard.Attack(1));
            Console.WriteLine(blackWizard.Attack(11));

        }
    }
}
