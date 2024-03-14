/*Supliment 1
• Se citesc doua numere de la tastatura. Scrieti un program care va calcula
cel mai mare divizor comun al numerelor*/

int a=int.Parse(Console.ReadLine()!);

int b=int.Parse(Console.ReadLine()!);

Console.WriteLine(GreatestCommonDivisor(a,b));

static int GreatestCommonDivisor(int a, int b)=> b == 0 ? a : GreatestCommonDivisor(b, a % b);
