//SEGUNDA CLASE TEORIA

//El siguiente codigo tiene algunos errores
byte b= 10;
double x=12.25;
int i=b;   //esta ok pq hay conversion implicita de byte a int 
double y_i; //esta ok pq hay conversion impĺicita de int a double
short j=i;  //En estas dos lineas hay error de compilacion
i=x;        // porque no es posible la conversion implicita, solucion: castear
short j = (short) i;  // conversion explicita ulitizando la expresion cast
i= (int) x;

{
object obj = 7.3; //obj apunta a un valor de tipo double
Console.WriteLine(obj.GetType()); //nos devuelve el tipo de dato que tiene la var obj
obj = "Casa"; //ahora a un valor de tipo string
Console.WriteLine(obj.GetType());
obj= 4; //ahora de tipo string
Console.WriteLine(obj.GetType());
}


Console.WriteLine("\n");

{object obj = 7.3; //obj apunta a un valor de tipo double
Console.WriteLine(obj);
obj = "Casa"; //ahora a un valor de tipo string
Console.WriteLine(obj);
obj= 4; //ahora de tipo string
// Console.WriteLine(obj + 1); , si quisiera hacer esto deberia castear 
Console.WriteLine( (int) obj + 1); 
}

Console.WriteLine("\n");
{
object obj = 1 + 2.3;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);
}


Console.WriteLine("\n");
{
object obj = "CAS" + 'A';
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);
}


Console.WriteLine("\n");
{
object obj = "Area" + 51;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);
}


Console.WriteLine("\n");
{
object obj = "Area" + 5 + 1;
//object obj5 = 5 + 1 + "Area"; //imprime de tipo string y 6Area
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);
}



//EL VALOR NULL
//Asignaciones de valor null
{
int? i1 = null; //OK
string? st1 = null; //OK
//int i2 = null; //Asignar null a una var de valor provoca un error de compilacion
string st2= null; //Asignar null a una var de referencia provoca un warning del compilador
}

Console.WriteLine("\n");

{
char c1= 'A';
char c2= 'A';
Console.WriteLine(c1==c2); //da verdadero porque el valor q contiene es igual
object o1= 'A';
object o2= 'A';
Console.WriteLine(o1==o2); //este da falso porque obj tiene la dir de memoria (es de referencia ) que no son iguales
}

Console.WriteLine("\n");

{
char c1= 'A';
char c2= c1;
Console.WriteLine(c1==c2); //da verdadero porque el valor q contiene es igual
object o1= 'A';
object o2= o1;
Console.WriteLine(o1==o2); //ahora da verdadero pq los dos apuntan a la misma dir de memoria
}


