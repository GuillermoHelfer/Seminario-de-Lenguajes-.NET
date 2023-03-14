Object obj = 7.3;                           // obj apunta a un valor de tipo double
Console.WriteLine(obj);
obj = "casa";                               // ahora de tipo string
Console.WriteLine(obj);
obj = 4;                                    // ahora de tipo int
Console.WriteLine(obj);

////////////////////////
Console.WriteLine("/////////////////////////////");
////////////////////////

obj = 1 + 2.3;

Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

////////////////////////
Console.WriteLine("/////////////////////////////");
////////////////////////

obj = 1 + 'A';

Console.WriteLine(obj);

////////////////////////
Console.WriteLine("/////////////////////////////");
////////////////////////

obj = "CAS" + 'A';

Console.WriteLine(obj);

////////////////////////
Console.WriteLine("/////////////////////////////");
////////////////////////

obj = "AREA" + 51;

Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

////////////////////////
Console.WriteLine("/////////////////////////////");
////////////////////////

Console.WriteLine("Area" + 5 + 1);
Console.WriteLine(5 + 1 + "Area");

////////////////////////
Console.WriteLine("/////////////////////////////");
////////////////////////

char c1 = 'A';
char c2 = 'A';
Console.WriteLine(c1 == c2);

object o1 = 'A';
object o2 = 'A';
Console.WriteLine(o1 == o2);