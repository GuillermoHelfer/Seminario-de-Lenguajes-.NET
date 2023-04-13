using System.Collections.Generic;
class ListaDePersonas
{
    List<Persona> personas;

    public ListaDePersonas () => 
        personas = new List<Persona>();
    public void Agregar(Persona p) => 
        personas.Add(p);

    public object this[int index]
    {
        get {  
            foreach (var item in personas)
            {
                if ((int)item[2] == index) return item;
            }
            return null;
        }
    }

    public object this[char index]
    {
        get {  
            List<Persona> newList = new List<Persona>();
            foreach (var item in personas)
            {
                if (item[0].ToString().ElementAt(0).Equals(index))
                    personas.Add(item);
            }
            return newList;
        }
    }

}