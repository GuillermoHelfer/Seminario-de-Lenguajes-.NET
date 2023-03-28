string marca = "Ford";
int modelo = 2000;
string st = ($"Es un {marca,-7} año {modelo}");
string st2 = ($"Es un {"Nissan",-7} año {2003}");
Console.WriteLine(st);
Console.WriteLine(st.GetType());

double r = 2.417;
Console.WriteLine($"Valor = {r:0.0}");
Console.WriteLine($"Valor = {r:0.00}");
//redondea, no trunca