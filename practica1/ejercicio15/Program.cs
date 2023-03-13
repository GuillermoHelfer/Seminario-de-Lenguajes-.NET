/*Escribir un programa que solicite un año por pantalla y diga si 
es bisiesto. Un año es bisiesto si es divisible por 4 pero no 
por 100. Si es divisible por 100, para ser bisiesto debe ser 
divisible por 400. */

int anio;

Console.WriteLine("Ingrese un anio");
anio = int.Parse(Console.ReadLine());

if (anio % 4 ==0 && anio % 100 != 0)
{
    Console.WriteLine("Es bisiesto");
}
else
{
    Console.WriteLine("No es bisiesto");
}

Console.ReadKey(true);