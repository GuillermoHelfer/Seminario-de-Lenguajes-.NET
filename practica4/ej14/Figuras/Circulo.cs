using System;
public class Circulo
{
    private double radio;

    public Circulo(double num)
    {
        this.radio = num;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(this.radio, 2);
    }

    
}