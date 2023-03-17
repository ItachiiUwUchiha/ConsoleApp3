//posrtac ogolna rownania kwadratowego: ax^2 + bx + c 
//delta (wzor) b^2 - 4 * a * c 
//pierwiastki x0 = -b / 2a, x1 = (-b - sqrt(delta) ) / (2 * a) x2 = (-b + sqrt(delta) ) / (2 * a)

//ewentualnie double
float a, b, c, delta, pierwDelta, x0, x1, x2;
//bufor dla konsoli
string buffer;

//przywitaj uzytkownika i popros o wprowadzenie danych:
Console.WriteLine("Podaj parametry równania kwadratowego w postaci ax^2 + bx + c:");

Console.WriteLine("Podaj a: ");
//przyjmij dane jako string - jesli nic nie poda to przyjmij "0"
buffer = Console.ReadLine() ?? "0";
//skonwertuj dane podane z klawiatury na wartosc liczbowa
a = float.Parse(buffer);

Console.WriteLine("Podaj b: ");
buffer = Console.ReadLine() ?? "0";
b = float.Parse(buffer);

Console.WriteLine("Podaj c: ");
buffer = Console.ReadLine() ?? "0";
c = float.Parse(buffer);

//liczymy delte
//MathF dlatego ze Math zwraca double a nie float
delta = MathF.Pow(b, 2) - 4 * a * c;

//trzy mozliwe przypadki
//jesli zdanie logiczne w nawiasie jest prawdziwe to wykonaj blok kodu
if(delta >0)
{
    //liczymy pierwiastek z delty
    //sqrt - square root - pierwiastek kwadratowy
    pierwDelta = MathF.Sqrt(delta);
    //delta ma wieksza od zera - dwa miejsca zerowe
    x1 = (-b - pierwDelta) / (2 * a);
    x2 = (-b + pierwDelta) / (2 * a);
    //wypisujemy wynik
    Console.WriteLine("Miejsca zerowe tego rownania wynosza x1: " + x1.ToString() + "x2: " + x2.ToString());
}
else if(delta == 0)
{
    //delta rowna zero
    Console.WriteLine("Wynik delty");
    x1 = -b / (2 * a);
    x2 = x1;
    Console.WriteLine("Miejsce zerowe tego rownania wynosza x1:" + x1.ToString() + "x2:" + x2.ToString());
}
else
{
    //delta mniejsza od zera
    Console.WriteLine("Brak rozwiązania");
}







