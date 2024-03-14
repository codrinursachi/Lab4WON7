/*Ex 4
Scrieti o functie care pentru un numar “n” primit ca parametru, va afisa
urmatoarea piramida a numerelor:
1
2 2
3 3 3
4 4 4 4
…
n n n ….. n*/


int n = int.Parse(Console.ReadLine()!);

ShowNumberPyramid(n);

static void ShowNumberPyramid(int n)
{
    string[] result = new string[n];
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat(i + " ", i)));
    }
}