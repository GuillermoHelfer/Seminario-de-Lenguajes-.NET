namespace practica5;
using System;
public class Persona
{
    private string _nombre {get;set;}
    private char _sexo {get;set;}
    private int _dni {get;set;}
    private DateTime _fechaNacimiento {get;set;}
    private readonly int edad;
    public object this[int i]
    {
        get { 
            switch(i)
            {
                case 0: return this._nombre;
                case 1: return this._sexo;
                case 2: return this._dni;
                case 3: return this._fechaNacimiento;
                case 4: return this.edad;
                default : throw new IndexOutOfRangeException ("parameter must be between 0-4");
            }
        }
        set {  
            switch(i)
            {
                case 0: this._nombre = (string)value; break;
                case 1: this._sexo = (char)value; break;
                case 2: this._dni = (int)value; break;
                case 3: this._fechaNacimiento = (DateTime)value; break;
                case 4: break;
                default : throw new IndexOutOfRangeException ("parameter must be between 0-4");
            }
        }
    }


}