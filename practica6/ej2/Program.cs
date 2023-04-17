A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{
    if (a is B)
    {
        a.Imprimir();
    }
}

/*
(is) is an operator to obtain a type of an object, but it 
returns true if the object is a subclass of the right
parameter object;

typeof is an operator to obtain a type known at compile-time 
(or at least a generic type parameter). The operand of typeof 
is always the name of a type or type parameter - never an 
expression with a value (e.g. a variable).

GetType() is a method you call on individual objects, to 
get the execution-time type of the object.
*/

class A
{
    protected int _id;
    public A(int id) => _id = id;
    public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
}
class B : A
{
    public B(int id) : base(id){}

    public override void Imprimir()
    {
        Console.Write($"B_{_id} --> ");
        base.Imprimir();
    }
}
class C : B
{
    public C(int id) : base(id){}

    public override void Imprimir()
    {
        Console.Write($"C_{_id} --> ");
        base.Imprimir();
    }
}
class D : C
{
    public D(int id) : base(id){}
    public override void Imprimir()
    {
        Console.Write($"D_{_id} --> ");
        base.Imprimir();
    }   
}