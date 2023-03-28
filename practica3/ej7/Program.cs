int i = 10;
var x = i * 1.0;
var y = 1f;
var z = i * y;

Console.WriteLine(i.GetType());
Console.WriteLine(x.GetType());
Console.WriteLine(y.GetType());
Console.WriteLine(z.GetType());

//x queda en double, y queda en flotante, z queda en flotante