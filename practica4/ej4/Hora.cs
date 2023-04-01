namespace ej4;

public class Hora
{
    private int hours;
    private double mins;
    private dynamic secs;
    private Boolean completo;

    public Hora (int hs, int mn, int sc)
    {
        this.hours = hs;
        this.mins = mn;
        this.secs = sc;
        this.completo = true;
    }

    public Hora (double d)
    {
        this.hours = (int)d;
        this.mins = (d % this.hours * 60);
        this.secs = (d % this.mins * 60);
        this.completo = false;
    }

    public void Imprimir ()
    {
        if (this.completo)
            Console.WriteLine(this.hours + " Horas, " + (int)this.mins + " Minutos, " + this.secs + " Segundos");
        else
            Console.WriteLine(this.hours + " Horas, " + this.mins + " Minutos, " + string.Format("{0:0.000}", this.secs) + " Segundos");
    }
}