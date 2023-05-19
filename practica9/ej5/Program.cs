Nodo<int> nodo1 = new Nodo<int>(5);
Agregar(nodo1, 1, 10, 3, 4, 56, 22, 31, 0, 15, 14);
Imprimir(nodo1);
Nodo<string> nodo2 = new Nodo<string>("hola");
Agregar(nodo2, "Mundo", "XYZ", "ABC", "nada");
Imprimir(nodo2);

    static void Agregar <T> (Nodo<T> node, params T[] pList)
    where T: IComparable<T>
    {
        foreach (T element in pList)
        {
            node.Insertar(element);
        }
    }

    static void Imprimir<T> (Nodo<T> node)
    where T : IComparable<T>
    {
        foreach (T element in node.InOrder)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Altura: " + node.Altura);
        Console.WriteLine("Cantidad: " + node.CantNodos);
        Console.WriteLine("Minimo: " + node.ValorMinimo);
        Console.WriteLine("Maximo: " + node.ValorMaximo);
    }