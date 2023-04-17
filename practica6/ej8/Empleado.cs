public abstract class Empleado
{
    public string _Nombre {get;}
    public string _DNI {get;}
    public DateTime _FechaDeIngreso {get;}
    public virtual double _SalarioBase {get; protected set;}
    public abstract double _Salario {get;}

    public Empleado (string Nombre, string DNI, DateTime fecha, double SalarioBase)
    {
        this._Nombre = Nombre;
        this._DNI = DNI;
        this._FechaDeIngreso = fecha;
        this._SalarioBase = SalarioBase;
    }

    public abstract void AumentarSalario();

}