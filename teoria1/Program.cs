// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//tarea 1; diferente resultado por diferente tipo, int div int = int; int div real = real.
double r1 = 17 / 3;
double r2 = 17 / 3.0;
Console.WriteLine(r1);
Console.WriteLine(r2);
//tarea2; imprime 4 true, si se le asigna a x el valor 0 hay error en div por 0.
int x = 2;
int y = 5;
Console.WriteLine(x != 0 && y / x == 2);
Console.WriteLine(x != 0 & y / x == 2);
Console.WriteLine(x == 0 || y / x == 2);
Console.WriteLine(x == 0 | y / x == 2);
//tarea 3; post incremento primero imprime y luego suma, pre incremento primero suma luego imprime
x = 1;
Console.WriteLine(x++); //post incremento
Console.WriteLine(x);
Console.WriteLine(++x); //pre incremento
Console.WriteLine(x);
//tarea 4; post decremento primero se asigna el valor de lla variable y luego resta a la variable original, post es viceversa.
x = 10;
y = x--; //post decremento
Console.WriteLine(y);
Console.WriteLine(x);
y = --x; //pre decremento
Console.WriteLine(y);
Console.WriteLine(x);
//tarea 5; post = primero compara luego incrementa/decrementa, pre primero incrementa/decrementa y luego compara
x = 10;
Console.WriteLine(x++ == 10);
Console.WriteLine(x-- == 10);
Console.WriteLine(++x == 10);
Console.WriteLine(--x == 10);
