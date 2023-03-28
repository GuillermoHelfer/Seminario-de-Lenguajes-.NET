for (int i = 0; i<args.Length; i++)
{
    Console.WriteLine("Hola, {0}", args[i]);
}

foreach (string name in args)
{
    Console.WriteLine("Hello, " + name);
}