Taxi t = new Taxi(3, "mercedes");
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}
class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros, string marca) : base(marca)
    {
        this.Pasajeros = pasajeros;
    }
}