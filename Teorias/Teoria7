//------------- Program.cs --------------
using teoria7;

object[] vector = new object[] { //object es elancestro comun mas cercano entre Moto y Empleado
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera")
   };

foreach (object o in vector)
{
   if(o is Empleado e){  //le asigno Empleado a la var e , o tmb lo puedo hacer dentro del if
       e.Imprimir();
   }
   else if(o is Moto m){
       m.Imprimir();
   }
}
