    //a) Lista con todos los múltiplos de 5 entre 100 y 200
    IEnumerable<int> mult5 = Enumerable.Range(100,200 - 99);
    var listaMult = mult5.Where(m => m % 5 == 0).ToList();

    //b) Lista con todos los números primos menores que 100
    IEnumerable<int> primosM = Enumerable.Range(2,100 - 2);
    var listaPrimos = primosM.
                        Where(p => Enumerable.Range(2, (int)Math.Sqrt(p) - 1).
                        All(d => p % d != 0)).ToList();

    //c) Lista con las potencias de 2, desde 2^0 a 2^10
    IEnumerable<int> pote2 = Enumerable.Range((int)Math.Pow(2,0), (int)Math.Pow(2,10) - 1);
    var listaPote = pote2
                        .Where(p => Math.Log2(p) % 1 == 0)
                        .ToList();

    //d) La suma y el promedio de los valores de la lista anterior
    var suma = listaPote.Sum();
    var prom = listaPote.Average();

    //e) Lista de todos los n^2 que terminan con el dígito 6, para n entre 1 y 20
    IEnumerable<int> nTerm = Enumerable.Range(1,20);
    var listsaNTerm = nTerm
                            .Where(n => ((int)(n*n) % 10) == 6)
                            .ToList();

    //f) Lista con los nombres de los días de la semana en inglés que contengan una letra ‘u’
    IEnumerable<int> dias = Enumerable.Range(0,7);
    var listaNombreSemanaConU = dias
                                    .Select(d => ((DayOfWeek)d).ToString())
                                    .Where(d => d.ToLower().Contains('u'))
                                    .ToList();

    Console.WriteLine(listaMult);
    foreach (int i in listaMult)
        Console.WriteLine(i);
    foreach (int i in listaPrimos)
        Console.WriteLine(i);
    foreach (int i in listaPote)
        Console.WriteLine(i);
    Console.WriteLine(suma);
    Console.WriteLine(prom);
    foreach (string st in listaNombreSemanaConU)
        Console.WriteLine(st);