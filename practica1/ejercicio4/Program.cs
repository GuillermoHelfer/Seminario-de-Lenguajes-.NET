String st;

Console.WriteLine("Ingrese su nombre");
st = Console.ReadLine();
if (st.Equals("")){
    Console.Write("Hola, Mundo");
}
else{
    Console.Write("Hola, " + st + '.');
}
Console.ReadKey(true);