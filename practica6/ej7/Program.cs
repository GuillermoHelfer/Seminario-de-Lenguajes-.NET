Imprimidor.Imprimir(new A(), new B(), new C(), new D());

class Letra {
    public virtual void Imprimir() => Console.Write("Soy una instancia ");
}

class A : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("A");
    }
}
class B : Letra{
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("B");
    }
}
class C : Letra{
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("C");
    }
}
class D : Letra{
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("C");
    }
}
static class Imprimidor {
    public static void Imprimir(params Letra[] vector) {
        foreach (Letra l in vector) {
            l.Imprimir();
        }
    }
}

//hola :p