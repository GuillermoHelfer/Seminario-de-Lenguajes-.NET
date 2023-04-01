using System.Globalization;
using System.Reflection.Metadata.Ecma335;
namespace ej1;

class Persona
{
    private string nombre;
    private int edad;
    private string dni;

    public Persona(string nom, int eda, string d)
    {
        nombre = nom;
        edad = eda;
        dni = d;
    }

    public string Imprimir()
    {
        return $"{this.nombre,-15}{this.edad,-10}{this.dni}";
    }

    public int GetEdad()
    {
        return this.edad;
    }

    public Boolean EsMayorQue(Persona p)
    {
        return this.edad > p.GetEdad();
    }

}