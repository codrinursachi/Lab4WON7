/*Ex 3
Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m,
respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata*/


int m = int.Parse(Console.ReadLine()!);

int n = int.Parse(Console.ReadLine()!);

int[,] matrix1 = new int[n, m];

int[,] matrix2 = new int[m, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix1[i, j] = int.Parse(Console.ReadLine()!);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix2[i, j] = int.Parse(Console.ReadLine()!);
    }
}

int[,] productMatrix = ComputeMatrixProduct(matrix1, matrix2);

for (int i = 0; i < productMatrix.GetLength(0); i++)
{
    for (int j = 0; j < productMatrix.GetLength(1); j++)
    {
        Console.Write(productMatrix[i,j] + " ");
    }

    Console.WriteLine();
}

static int[,] ComputeMatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}