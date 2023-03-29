using System.Text;

Console.WriteLine("ingrese la frase a encriptar");
String frase = Console.ReadLine();


Console.WriteLine("ingrese la clave de cifrado");
string key = Console.ReadLine();
Queue<int> q = new Queue<int>();
for(int i=0; i<key.Length; i++){
    q.Enqueue((int)key[i] - 48);
}

Dictionary<char,int> dct = new Dictionary<char,int>();

for (int i=1, j= 65; j<= 90; i++, j++)
    dct.Add((char)j, i);
dct.Add((char)32, 27);

string st = cifrar(frase,ref q, dct).ToString();
Console.WriteLine(st);
q.Clear();
for(int i=0; i<key.Length; i++){
    q.Enqueue((int)key[i] - 48);
}
Console.WriteLine(decifrar(st,ref q, dct));
Console.ReadKey(true);

StringBuilder cifrar (string frase, ref Queue<int> kq, Dictionary<char,int> dct)
{
    StringBuilder cifrada = new StringBuilder();
    int qValue;
    for (int i=0; i<frase.Length; i++)
    {
        qValue = kq.Dequeue();
        dct[frase[i]]+= qValue;
        if (dct[frase[i]] > 27)
            dct[frase[i]] -= 27;
        char value = (char)(dct[frase[i]]+ 64);
        cifrada.Append(value);
        dct[frase[i]]-= qValue;
        kq.Enqueue(qValue);
    }
    return cifrada;
}

StringBuilder decifrar (string frase, ref Queue<int> kq, Dictionary<char,int> dct)
{
    StringBuilder cifrada = new StringBuilder();
    int qValue;
    for (int i=0; i<frase.Length; i++)
    {
        qValue = kq.Dequeue();
        dct[frase[i]]-= qValue;
        char value;
        if (dct[frase[i]] == 0)
        {
            dct[frase[i]] = 32;
            value = (char)(dct[frase[i]]);
        }
        else
        {
            if (dct[frase[i]] < 0)
                dct[frase[i]] += 27;
            value = (char)(dct[frase[i]]+ 64);
        }
        cifrada.Append(value);
        dct[frase[i]]+= qValue;
        kq.Enqueue(qValue);
    }
    return cifrada;
}