using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Collections;

public class Nodo <T> : IComparable <Nodo<T>>
    where T : IComparable<T>
{
    private T value;
    private Nodo<T>? subLeft;
    private Nodo<T>? subRight;

    public Nodo (T newValue)
    {
        this.value = newValue;
        this.subLeft = null;
        this.subRight = null;
    }

    public T GetValue()
    {
        return this.value;
    }

    public List<T> InOrder
    {
        get 
        {
            List<T> listaRet = new List<T>();
            InOrderRec(this, listaRet);
            return listaRet;
        }
    }

    public int Altura
    {
        get
        {
        // If the node is null, return 0
        if (this == null)
            return -1;

        // Calculate the height of the left and right subtrees
        int leftHeight = (this.subLeft == null) ? -1 : this.subLeft.Altura;
        int rightHeight = (this.subRight == null) ? -1 : this.subRight.Altura;

        // Return the maximum height between the left and right subtrees
        return Math.Max(leftHeight, rightHeight) + 1;
        }
    }

    public int CantNodos
    {
        get
        {
            int count = 1;
            if (this.subLeft != null)
                count += this.subLeft.CantNodos;
            if (this.subRight != null)
                count += this.subRight.CantNodos;
            return count;
        }
    }

    public T ValorMaximo
    {
        get
        {
            if (this.subRight == null)
                return this.value;
            return this.subRight.ValorMaximo;
        }
    }

    public T ValorMinimo
    {
        get
        {
            if (this.subLeft == null)
                return this.value;
            return this.subLeft.ValorMinimo;
        }
    }

    private void InOrderRec (Nodo<T> nodo, List<T> listaRet)
    {
        if (nodo.subLeft != null)
            InOrderRec(nodo.subLeft, listaRet);
        listaRet.Add(nodo.value);
        if (nodo.subRight != null)
            InOrderRec(nodo.subRight, listaRet);
    }

    public void Insertar(T newValue)
    {
        if (newValue.CompareTo(this.value) < 0)
        {
            if (this.subLeft == null)
                this.subLeft = new Nodo<T>(newValue);
            else
                this.subLeft.Insertar(newValue);
        }
        else if (newValue.CompareTo(this.value) > 0)
        {
            if (this.subRight == null)
                this.subRight = new Nodo<T>(newValue);
            else
                this.subRight.Insertar(newValue);
        }
    }

    public int CompareTo(Nodo<T>? other)
    {
        if (other == null) return 1;
        return this.value.CompareTo(other.value);
    }

    public int CompareTo (T? other)
    {
        if (other == null) return 1;
        return this.value.CompareTo(other);
    }
    
}