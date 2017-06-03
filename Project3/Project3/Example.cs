using System;

class integer
{

    static void Main()
    {
    int x,y,z;

    Console.WriteLine("Գրեք առաջին թիվը");
    x =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("ընտրեք գործողությունը\n1 +\n2 -\n3 * \n4 /");
    z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Գրեք առաջին թիվը");
    y = Convert.ToInt32(Console.ReadLine());
    switch (z)
    {
        case 1:
        Console.WriteLine(x + " + " + y + " = " + +(x + y));
        break;
        case 2:
        Console.WriteLine(x + " - " + y + " = " + +(x - y));
        break;
        case 3:
        Console.WriteLine(x + " * " + y + " = " + +(x * y));
        break;
        case 4:
        Console.WriteLine(x + " / " + y + " = " + +(x / y));
        break;
    }
    }

}
