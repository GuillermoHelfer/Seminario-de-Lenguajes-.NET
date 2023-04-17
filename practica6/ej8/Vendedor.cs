public class Vendedor : Empleado
{
    public double _Comision {get;set;}
    public override double _Salario {
        get => this._SalarioBase + this._Comision;
    }


    public Vendedor(string Nombre, string DNI, DateTime fecha, double SalarioBase) : base(Nombre, DNI, fecha, SalarioBase)
    {}

    public override void AumentarSalario()
    {
        if (DateTime.Now.Year - this._FechaDeIngreso.Year < 10)
            this._SalarioBase += this._SalarioBase * 0.05;
        else
            this._SalarioBase += this._SalarioBase * 0.1;
    }
}