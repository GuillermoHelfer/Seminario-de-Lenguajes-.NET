double [,] matriz = new double [10,10];

imprimirMatriz(matriz);

void imprimirMatriz (double[,] matriz)
{
    int x = matriz.GetLength(0);
    int y = matriz.GetLength(1);
    for (int i = 0; i<(x * y); i++)
    {
        matriz[i/y,i%y] = i;
        Console.WriteLine(matriz[i/y,i%y]);
    }
}