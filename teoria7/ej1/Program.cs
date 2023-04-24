using ej1;

object[] vector = new object[] {
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera")
   };

for (int i=0; i< vector.Length; i++)
{
    (vector[i] as IImprimible).Imprimir();
}