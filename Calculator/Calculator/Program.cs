using System;
using System.Numerics;

class Prgramm
{

    public static int add(int x, int y)
    {
        return x + y;
    }

    public static int fakultaet(int x)
    {
        if (x == 0 || x == 1)
        {
            return x = 1;
        }

        if (x > 1)
        {
            for (int i = x - 1; i > 0; i--)
            {
                x *= i;
            }
        }
        return x;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Wähle eine Methode aus:\n add \n sub \n mul \n div \n fak ");
        int zahl1, zahl2;
        string methode;
        methode = Console.ReadLine();
        Console.WriteLine("du hast " + methode + " gewählt");

        if (methode == "fak")
        {
            Console.WriteLine("Gebe Zahl größer Null ein um Fakultät zu berechnen: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fakultaet(zahl1));
        }
        if (methode == "add")
        {
            Console.WriteLine("Gebe nacheinander zwei Zahlen ein um diese zu addieren ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(add(zahl1, zahl2));
        }




    }
}
