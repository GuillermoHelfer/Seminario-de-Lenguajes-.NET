namespace teoria4;

class Auto
{
    private string? _marca;
    private int _modelo;
    public Auto(){}
    public Auto (string marca, int modelo)
    {
        _marca = marca;
        _modelo = modelo;
    }

    public Auto (string marca) : this()
    {
        _marca = marca;
    }
    public string getDescripcion() =>
        $"Auto {_marca} {_modelo}";
}