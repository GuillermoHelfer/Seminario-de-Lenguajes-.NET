class A
{
char c;
static string st;
void metodo1()
{
st = "string";
c = 'A';
}
static void metodo2()
{
new A().c = 'a';
    st = "st2";
    c = 'B';
new A().st = "otro string";
}
}

//no se puede usar staticos con variables de instancia
//no se puede usar vv.ii sin la referencia al objeto