int x = 0;
try
{
Console.WriteLine(1.0 / x);
Console.WriteLine(1 / x);
Console.WriteLine("todo OK");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}

//primero muestra infinito pq: 1.0 / 0.0 is calculable since it takes place in floating point arithmetic