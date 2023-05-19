static class NodoExtension
{
    public static void Agregar (this Nodo<int> node, params int[] pList)
    {
        foreach (int element in pList)
        {
            node.Insertar(element);
        }
    }

    public static void Agregar (this Nodo<string> node, params string[] pList)
    {
        foreach (string element in pList)
        {
            node.Insertar(element);
        }
    }

    public static void Imprimir (this Nodo<int> node)
    {
        Console.WriteLine(node.InOrder);
        Console.WriteLine(node.Altura);
        Console.WriteLine(node.CantNodos);
        Console.WriteLine(node.ValorMinimo);
        Console.WriteLine(node.ValorMaximo);
    }

    public static void Imprimir (this Nodo<string> node)
    {
        Console.WriteLine(node.InOrder);
        Console.WriteLine(node.Altura);
        Console.WriteLine(node.CantNodos);
        Console.WriteLine(node.ValorMinimo);
        Console.WriteLine(node.ValorMaximo);
    }

}