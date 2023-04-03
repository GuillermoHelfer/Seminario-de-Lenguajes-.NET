public class Auto
{
    private string? _marca;
    private int _modelo;
    public Auto()
    {
        this._modelo = 2023;
    }
    public Auto (string marca, int modelo)
    {
        _marca = marca;
        _modelo = modelo;
    }

    public Auto (string marca) : this()
    {
        _marca = marca;
    }
    public string GetDescripcion() =>
        $"Auto {_marca} {_modelo}";
}