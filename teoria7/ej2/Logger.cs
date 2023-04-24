namespace ej2;

public class Logger : ILogger
{
    public void Log(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}