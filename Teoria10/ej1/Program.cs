int[] vector = new int[] { 1, 2, 3, 4, 5 };
List<string> lista = new List<string> () {"uno", "dos", "tres"};
IEnumerable<string> secList = lista.Select(st => '(' + st.ToUpper() + ')');
IEnumerable<int> secuencia = vector.Select(n => n * 3);
IEnumerable<int> secuencia2 = secList.Select(st => st.Length);
var secuencia3 = secuencia2.Select(n => n / 2.0); //todas estas pueden ser var
Mostrar(secuencia);
Mostrar(secList);
Mostrar(secuencia2);
Mostrar(secuencia3);


void Mostrar<T>(IEnumerable<T> secuencia)
{
   foreach (T elemento in secuencia)
   {
       Console.Write(elemento + " ");
   }
   Console.WriteLine();
}

/////////////////////////////////////////////////////////////

var personas = Persona.GetLista();
personas.ForEach(p => Console.WriteLine(p));
Console.WriteLine();
personas.Where(p => p.Edad >= 18)
        .ToList()
        .ForEach(p => Console.WriteLine(p));

var agrupadas = personas.GroupBy(p => p.Nombre[0]);
foreach(var grupo in agrupadas)
{
    Console.WriteLine($"Inicial: {grupo.Key}");
    grupo.ToList().ForEach(p => Console.WriteLine(" - " + p));
}