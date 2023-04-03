using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Collections;

public class Nodo
{
    private int value;
    private Nodo subLeft;
    private Nodo subRight;

    public Nodo (int newValue)
    {
        this.value = newValue;
        this.subLeft = null;
        this.subRight = null;
    }

    public void Insertar(int value)
    {
        if (this.value > value)
        {
            if (this.subLeft == null)
                this.subLeft = new Nodo(value);
            else
                this.subLeft.Insertar(value);
        }
        else if (this.value < value)
        {
            if (this.subRight == null)
                this.subRight = new Nodo(value);
            else
                this.subRight.Insertar(value);
        }
    }

    public int GetValue()
    {
        return this.value;
    }

    protected void InOrden(ArrayList list)
    {
        if (this.subLeft != null)
            this.subLeft.InOrden(list);
        list.Add(this.value);
        if (this.subRight != null)
            this.subRight.InOrden(list);
    }

    public ArrayList GetInOrden()
    {
        ArrayList list = new ArrayList();
        InOrden(list);
        return list;
    }

    public int GetAltura()
    {
        int a = -1;
        if (this.subLeft == null && this.subRight == null)
            return 0;
        else
        {
            if (this.subLeft != null)
                a = Math.Max(a, this.subLeft.GetAltura());
            if (this.subRight != null)
                a = Math.Max(a, this.subRight.GetAltura());
            return a + 1;
        }
    }

    public int GetCantNodos()
    {
        if (this.subLeft == null && this.subRight == null)
            return 1;
        else if ((this.subLeft != null) && (this.subRight != null))
            return this.subLeft.GetCantNodos() + this.subRight.GetCantNodos() + 1;
        else if (this.subLeft != null)
            return this.subLeft.GetCantNodos() + 1;
        else if (this.subRight != null)
            return this.subRight.GetCantNodos() + 1;
        return 0;
    }

    public int GetValorMaximo()
    {
        if (this.subLeft == null && this.subRight == null)
            return this.value;
        if (this.subLeft != null && this.subRight != null)
            return Math.Max(this.subLeft.GetValorMaximo(), this.subRight.GetValorMaximo());
        if (this.subLeft != null)
            return this.subLeft.GetValorMaximo();
        if (this.subRight != null)
            return this.subRight.GetValorMaximo();
        return int.MinValue;
    }

    public int GetValorMinimo()
    {
        if (this.subLeft == null && this.subRight == null)
            return this.value;
        if (this.subLeft != null && this.subRight != null)
            return Math.Min(this.subLeft.GetValorMinimo(), this.subRight.GetValorMinimo());
        if (this.subLeft != null)
            return this.subLeft.GetValorMinimo();
        if (this.subRight != null)
            return this.subRight.GetValorMinimo();
        return int.MaxValue;
    }

}