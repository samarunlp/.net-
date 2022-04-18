//------------- Program.cs --------------

using teoria7;

/*object[] vector = new object[] { //object es el ancestro comun mas cercano entre Moto y Empleado
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
}*/

//version mejorada, trabajando el polimorfismo -->
IImprimible[] vector1 = new IImprimible[]{
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera"),
};

foreach (IImprimible imp in vector1){
    imp.Imprimir();
}

Console.WriteLine("\n");

Console.WriteLine("Ejemplo2");

var vector2= new Empleado[]
{
    new Empleado("Juan"),
    new Empleado ("Adriana"),
    new Empleado("Diego"),
};
Array.Sort(vector2);    //si quisiera generar un orden para imprimir, que se compare y se muestre deberia ser aca
foreach(Empleado e in vector2){
    e.Imprimir();
}
Console.WriteLine("\n");

Console.WriteLine("Ejemplo4, Enumeracion");

Pyme miPyme = new Pyme(new Empleado("Juan"), 
                       new Empleado("Adriana"), 
                       new Empleado ("Diego"));

foreach(Empleado e in miPyme){ //esto tendria error de compilacion pq Pyme no contiene extension
    e.Imprimir();
}
