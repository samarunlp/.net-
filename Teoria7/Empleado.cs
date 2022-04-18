//----------- Empleado.cs ------------
namespace teoria7;

class Empleado : Persona, IImprimible, IComparable
{
   public Empleado(string nombre)
      => Nombre = nombre;

    public int CompareTo(object? obj)
    {
      int result=0;
      if(obj is Empleado){
         string nombre= ((Empleado) obj).Nombre;
         result=this.Nombre.CompareTo(nombre);
      }
      return result;
    }

    public void Imprimir()
      => Console.WriteLine($"Soy el empleado {Nombre}");
}
