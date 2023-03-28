/*¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
las palabras (una por línea) de una frase ingresada por consola por el usuario*/

String[] subST = args[0].Split(' ');

foreach (string palabra in subST)
{
    Console.WriteLine(palabra);
}