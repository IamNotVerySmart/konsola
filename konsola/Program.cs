using System;

Console.WriteLine("a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b: ");
int b = int.Parse(Console.ReadLine());
int nwd(int x, int y)
{
    while (y != 0)
    {
        if (x > y) x = x % y;
        else y = y % x;
    }
    return y;
}
Console.WriteLine("a= " + nwd(a, b));
/**********************************************
nazwa funkcji: nwd
opis funkcji: wyznacza najwiekszy wspolny dzielnik
parametry: nwm ocb
zwracany typ i opis: int, najwiekszy wspolny dzielnik?
autor: 69420213769
***********************************************/