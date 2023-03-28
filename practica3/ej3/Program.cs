double [,] matriz = new double [10,10];
string form = "0.0";

ImprimirMatrizConFormato(matriz, form);

void ImprimirMatrizConFormato(double[,] matriz, string formatString)
{
    int x = matriz.GetLength(0);
    int y = matriz.GetLength(1);
    for (int i = 0; i<(x * y); i++)
    {
        matriz[i/y,i%y] = i;
        double valor = matriz[i/y,i%y];
        Console.WriteLine(valor.ToString(formatString));
    }
}