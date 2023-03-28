using System.Numerics;
double [,] mtx = new double [10,10];

for (int i = 0; i< 10*10; i++)
    mtx[i/10,i%10] = i;

double [][] unArre = GetArregloDeArreglo(mtx);


double[][] GetArregloDeArreglo(double [,] matriz)
{
    double[][] unArre = new double[matriz.GetLength(0)] [];
    for (int i=0; i< matriz.GetLength(0); i++)
    {
        unArre[i] = new double[matriz.GetLength(1)];
        for(int j=0; j<matriz.GetLength(1); j++)
        {
            unArre[i][j] = matriz[i,j];
        }
    }
    return unArre;
}