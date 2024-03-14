/*Supliment 2
• Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz,
daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
cazurilor sa se afiseze numarul.*/

int n = int.Parse(Console.ReadLine()!);

Enumerable.Range(1, n).Select(i => i + 
                                    (i % 3 == 0 ? " Fizz" : "") + 
                                    (i % 5 == 0 ? " Buzz" : ""))
                                    .ToList().ForEach(Console.WriteLine);
