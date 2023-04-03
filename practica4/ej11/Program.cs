object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o);
s.Procesar((dynamic)o, o);
s.Procesar((dynamic)o, (dynamic)o);
s.Procesar(o, (dynamic)o);
s.Procesar(5, 5);
class Sobrecarga
{
public void Procesar(int i, object o)
{
Console.WriteLine($"entero: {i} objeto:{o}");
}
public void Procesar(dynamic d1, dynamic d2)
{
Console.WriteLine($"dynamic d1: {d1}    dynamic d2:{d2}");
}
}