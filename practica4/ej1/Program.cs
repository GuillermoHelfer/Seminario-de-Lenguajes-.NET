using ej1;

List<Persona> personas = new List<Persona>();
Console.WriteLine("ingrese el nombre, la edad y el dni");
Console.WriteLine("formato: NOMBRE,DNI,EDAD<ENTER>");
Console.WriteLine("Ingrese edad -1 para imprimir todos los cargados");
string st = Console.ReadLine();
string nom = st.Split(',')[0];
string dni = st.Split(',')[1];
int edad = int.Parse(st.Split(',')[2]);

while (edad != -1)
{   
    personas.Add(new Persona(nom,edad,dni));

    Console.WriteLine("ingrese el nombre, la edad y el dni");
    Console.WriteLine("formato: NOMBRE,DNI,EDAD<ENTER>");
    Console.WriteLine("Ingrese nombre vacio para imprimir todos los cargados");
    st = Console.ReadLine();

    nom = st.Split(',')[0];
    dni = st.Split(',')[1];
    edad = int.Parse(st.Split(',')[2]);

}

for (int i=0; i< personas.Count; i++)
{
    Console.WriteLine(i + ")   " + personas.ElementAt(i).Imprimir());
}

Console.ReadKey(true);