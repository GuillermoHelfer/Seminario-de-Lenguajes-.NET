﻿using System.Text;

object[] v = new object[10];
v[0] = new StringBuilder("Net");
for (int i = 1; i < 10; i++)
{
v[i] = v[i - 1];
}
(v[5] as StringBuilder).Insert(0, "Framework .");
foreach (StringBuilder s in v)
    Console.WriteLine(s);

//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución
/*
 pos    1       2       3       4       5               6       7       8       9       10
 valor  Net     Net     Net     Net     Framework .Net  Net     Net     Net     Net     ?
*/

v[5] = new StringBuilder("CSharp");
foreach (StringBuilder s in v)
    Console.WriteLine(s);

//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución