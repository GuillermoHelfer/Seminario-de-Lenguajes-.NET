/*Escribir un programa que calcule la suma de dos números reales 
introducidos por teclado y muestre el resultado en la consola 
(utilizar double.Parse(st) para obtener el valor double a
partir del string st.*/

double d1;
double d2;

Console.WriteLine("Ingrese un numero real");
d1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero real");
d2 = double.Parse(Console.ReadLine());

//int suma;

Console.WriteLine(d1 + d2);

Console.ReadKey(true);