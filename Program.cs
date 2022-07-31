using System;
using dio.rpg.oo;

namespace dio.rpg.oo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine       ("|                  RPG - DIO                  |");
            System.Console.WriteLine("+---------------------------------------------+");
            System.Console.WriteLine("");

            Knigth hero = new Knigth("Arus", 42,"knight");
            
            System.Console.WriteLine("+---------------------------------------------+");
            System.Console.Write("|  "+hero);
            System.Console.WriteLine(hero.Attack("attacked with his sword")); 
            System.Console.WriteLine("|                                             |");
        
            Wizard wWizard = new Wizard("Jenica", 23,"White Wizard");            
            System.Console.Write("|  "+wWizard);
            System.Console.WriteLine(wWizard.Attack("cure magic"));  
            System.Console.WriteLine("|                                             |");

            Ninja ninja = new Ninja("Wedge", 20,"Ninja");
            System.Console.Write("|  "+ninja);
            System.Console.WriteLine(ninja.Attack("silent attack")); 
            System.Console.WriteLine("|                                             |");

            Wizard bWizard = new Wizard("Topapa", 15,"Black Wizard");
            System.Console.Write("|  "+bWizard);
            System.Console.WriteLine(bWizard.Attack("offensive magic")); 
            System.Console.WriteLine("+---------------------------------------------+");
        }
    }
}
