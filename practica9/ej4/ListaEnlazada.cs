using System.Collections;

class ListaEnlazada <T>
{
    public Nodo<T>? _nodo {get;set;}

    public ListaEnlazada ()
    {
        _nodo = null;
    }

    public void AgregarAdelante (T value)
    {
        Nodo<T> nuevo = new Nodo<T>(value);
        nuevo.Proximo = _nodo;
        this._nodo = nuevo;
    }

    public void AgregarAtras (T value)
    {
        Nodo<T> nuevo = new Nodo<T>(value);
        if (this._nodo == null)
        {
            this._nodo = nuevo;
            return;
        }
        Nodo<T> actual = this._nodo;
        while (actual.Proximo != null)
            actual = actual.Proximo;
        actual.Proximo = nuevo;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Nodo<T>? actual = this._nodo;
        while (actual != null)
        {
            yield return actual.Valor;
            actual = actual.Proximo;
        }
    }
}