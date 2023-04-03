namespace practica4;

public class Ecuacion2
{
    private double a;
    private double b;
    private double c;

    public Ecuacion2(double d, double e, double f)
    {
        this.a = d;
        this.b = e;
        this.c = f;
    }

    public double GetDiscriminante()
    {
        return ((b*b)-4*a*c);
    }

    public int GetCantidadDeRaices()
    {
        if (GetDiscriminante() < 0)
            return 0;
        else
            if (GetDiscriminante() > 0)
                return 2;
            else
                return 1;
    }

    public void ImprimirRaices()
    {
        if (GetCantidadDeRaices() == 2)
        {
            Console.WriteLine(GetDiscriminante());
            Console.WriteLine(GetDiscriminante() * -1);
        }
        else if (GetCantidadDeRaices() == 1)
        {
            Console.WriteLine(GetDiscriminante());
        }
    }
}