using System.Reflection.Emit;
public class Administrativo : Empleado
{
    public double _Premio {get;set;}

    public override double _Salario {
        get => this._SalarioBase + this._Premio;
    }

    public Administrativo(string Nombre, string DNI, DateTime fecha, double SalarioBase) : base(Nombre, DNI, fecha, SalarioBase)
    {}

    public override void AumentarSalario()
    {
        double aux = DateTime.Now.Year - this._FechaDeIngreso.Date.Year;
        if (DateTime.Now.Month <= this._FechaDeIngreso.Date.Month)
            if (DateTime.Now.Day < this._FechaDeIngreso.Date.Day)
                aux--;
        this._SalarioBase += this._SalarioBase * (aux/100);
    }
}