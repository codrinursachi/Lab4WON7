/*Ex 2
Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k.
Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
 Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
 Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul.*/


int n = int.Parse(Console.ReadLine()!);

int m = int.Parse(Console.ReadLine()!);

int k = int.Parse(Console.ReadLine()!);

int[,,] matrix = new int[n, m, k];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int z = 0; z < k; z++)
        {
            matrix[i, j, z] = int.Parse(Console.ReadLine()!);
        }
    }
}

Console.WriteLine(Get3DMatrixElementsSum(matrix));

Console.WriteLine(Get3DMatrixMaxElement(matrix));

static int Get3DMatrixElementsSum(int[,,] matrix) => matrix.Cast<int>().Sum();

static int Get3DMatrixMaxElement(int[,,] matrix) => matrix.Cast<int>().Max();
