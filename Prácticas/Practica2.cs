//1Qué líneas del siguiente código provocan conversiones boxing y unboxing.
char c1 = 'A';
string st1 = "A";
object o1 = c1;//boxing
object o2 = st1;//boxing
char c2 = (char)o1; //unboxing
string st2 = (string)o2; //unboxing



/*
2. Sea el siguiente código:
object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);
El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas
variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la
consola no sea “Z Z”?
*/
object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);
/*No es el resultado " Z Z" porque o1 siempre apunta la misma dirección y o2 copia el valor de o1
y luego modifica su valor*/
