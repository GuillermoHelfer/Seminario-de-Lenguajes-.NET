var a = 3L;
dynamic b = 32;
object obj = 3;
//a = a * 2.0; //error long a double
b = b * 2.0;
b = "hola";
obj = b;
b = b + 11; //hace una conv implicita de int a string
//obj = obj + 11; //error string a int32
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
//f.Edad = 22; // no se puede acceder a vv.ii. privadas
d = c;
//e = d; //no se puede convertir entre tipos con atributos diferentes
//f = e; //no se puede convertir entre tipos con firmas diferentes