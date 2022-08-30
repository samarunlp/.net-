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




/*
3. Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
¿Qué hace realmente? */
           int sum = 0;
           int i = 1;
           while (i <= 10);   //El error esta en poner el ; ya que frena la ejecucion del metodo
           {
              sum += i++; 
           }

/*
4.¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos? */
Console.WriteLine(args == null);
Console.WriteLine(args.Length);
//La salida por consola es falso y 0 ya que args no tiene contenido declarado, no dice que sea null y no tiene tamaño.

/*
5. ¿Qué hace la instrucción? ¿asigna a la variable vector el valor null?
La instruccion creando el vector con ? , logra incorporar el null por si existe la probabilidad q lo contenga*/

int[]? vector = new int[0];



/*
7.Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué? */

char c;
char? c2;
string? st;
c = "";  //error porque no pueden declarar una var vacia
c = '';  //error porque no pueden declarar una var vacia
c = null;  //error ya que la var c no esta creada para que acepte null
c2 = null;
c2 = (65 as char?);
st = "";  
st = '';  //error porque st es un string y no se puede asignarle valor con ''
st = null;
st = (char)65;   //error pq no se puede convertir implicitamente un char a un string
st = (string)65;  //error pq no se puede convertir un int a un string
st = 47.89.ToString();


/*
8. Escribir un programa que reciba una lista de nombres como parámetro e imprima por consola un
saludo personalizado para cada uno de ellos.
a) utilizando la sentencia for
b) utilizando la sentencia foreach , es usado cuando quiero recorrer todo el vector */

string[] vector= new string [3] {"Samar", "Rocio", "Emanuel"}; //o puede ir sin el new string y tamaño.

//a) utilizando la sentencia for
for (int i=0;i < vector.Length;i++){
           Console.WriteLine("Hola "+ vector[i]);
           }
//b) utilizando la sentencia foreach
foreach (string st in vector){              //st que va a asignarse con cada uno de los elementos de la colección
   Console.WriteLine("Hola "+st);
           }
/*
9. Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar
un caso de ejemplo en el que el rendimiento sea claramente superior utilizando
StringBuilder en lugar de string y otro en el que no.
> Es preferible utilizar StringBuilder en vez de string en el caso de que a lo largo de la ejecucion del programa, querramos modificar la cadena.
*/

using System.Text;

StringBuilder cad;
cad = new StringBuilder ("casa");
Console.WriteLine(cad);
cad[0] = 'C';
Console.WriteLine(cad);


/*
10. Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
implementados en el ejercicio anterior. */
using System.Text;
// Inicia el contador:
DateTime start = DateTime.Now;
 

StringBuilder cad;
cad = new StringBuilder ("casa");
Console.WriteLine(cad);
cad[0] = 'C';
Console.WriteLine(cad);
 
// Para el contador e imprime el resultado:
DateTime end = DateTime.Now;
TimeSpan total = new TimeSpan(end.Ticks - start.Ticks);
Console.Write( "TIEMPO: " + total.ToString() );


/*
11)¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
las palabras (una por línea) de una frase ingresada por consola por el usuario. */

