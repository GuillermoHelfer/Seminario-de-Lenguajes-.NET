using System.Text;
Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
Imprimir(1, 2, "tres");
Imprimir();
Imprimir("-------------");
void Imprimir (params object[] vector)
{
    StringBuilder stb = new StringBuilder("");
    foreach (object obj in vector)
    {
        stb.Append(obj.ToString() + " ");
    }
    Console.WriteLine(stb);
}