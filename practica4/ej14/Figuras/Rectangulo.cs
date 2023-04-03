public class Rectangulo
{
    private double ladoX;
    private double ladoY;

    public Rectangulo (double x, double y)
    {
        this.ladoX = x;
        this.ladoY = y;
    }

    public double GetArea()
    {
        return this.ladoX * this.ladoY;
    }
    
}