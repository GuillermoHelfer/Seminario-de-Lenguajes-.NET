namespace Teoria6;

class Colectivo: Automotor
{
   public string Marca = "";
   public override int Modelo
    {
        protected set =>
           base.Modelo = (value < 2015) ? 2015 : value;
    }
   public int CantPasajeros;

   public Colectivo(string marca, int modelo, int cantPasajeros):base(marca, modelo)
    {
        this.CantPasajeros = cantPasajeros;
    }
   public override void Imprimir()
   {
        base.Imprimir();
        Console.Write($"({CantPasajeros} pasajeros)");
   }
}