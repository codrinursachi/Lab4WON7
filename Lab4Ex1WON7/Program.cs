/*Ex 1
Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile m, n.
Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la tastaura.
 Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
 Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul.*/

int m = int.Parse(Console.ReadLine()!);

int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];

int[,] matrix2 = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine()!);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix2[i, j] = Random.Shared.Next();
    }
}


ShowMatrix(matrix);

Console.WriteLine();

ShowMatrix(matrix2);

ShowMatrix(AddMatrix(matrix, matrix2));

static void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}

static int[,] AddMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }

        Console.WriteLine();
    }

    return result;
}