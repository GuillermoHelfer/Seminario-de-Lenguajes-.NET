public class Persona
{
    public string? Nombre { get; set; }
}
public class Auto
{
    private Persona? _dueño1, _dueño2;
    public Persona? GetPrimerDueño() => _dueño1;
    protected Persona SegundoDueño
    {
        set => _dueño2 = value;
    }
}

//error de compilacion en la exposicion de la clase Persona
//(era default y debia ser public).

//error de ejecucion en la inicializacion de las Personas
//(valores nulos seran devueltos)