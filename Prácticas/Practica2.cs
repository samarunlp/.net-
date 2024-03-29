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
String frase = Console.ReadLine();
string[] mensaje = frase.Split(' ');
foreach (var word in mensaje)
{
    Console.WriteLine($"{word}");
}

/*
13. Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
noviembre, octubre ..., enero)
c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al
nombre de un mes
Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses */
namespace ejercicios;
//declarar antes del programa
enum Meses
{
    enero=1,febrero=2, marzo=3, abril=4, mayo=5, junio=6, julio=7,
    agosto=8, septiembre=9, octubre=10, noviembre=11, diciembre=12
}
//basta con poner enero=1 para que el resto quede 2,3,4,..,12
class Program
{
  static void Main(string[] args) //preguntar porq necesita el main
  {
      
    Console.WriteLine("Los meses en orden inverso ");
    for (Meses i = Meses.diciembre; i >= Meses.enero; i--)
    {
                    Console.WriteLine(i);
    }

    Console.WriteLine("Ingrese un mes");
    string st=Console.ReadLine();


    for (Meses i = Meses.diciembre; i >= Meses.enero; i--)
    {
        if(st.Equals(Meses.GetName(i) ) )
        {
            Console.WriteLine("Es un mes");
        }
    }

  }
}
/*
14. Implementar un programa que muestre todos los números primos entre 1 y un número natural
dado (pasado al programa como argumento por la línea de comandos). Definir el método bool
EsPrimo(int n) que devuelve true sólo si n es primo. Esta función debe comprobar si n es
divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d)
devuelve la raíz cuadrada de d)  */
int  numDado = Convertir . ToInt32 ( argumentos [ 0 ]); // como es un string tengo q pasarlo a int
consola _ WriteLine ( " Numeros primos del 1 al "  +  numDado );
for ( int  i  =  1 ; i  <=  numDado ; i ++ )
// para (int i = 1; i < 11; i++)
{
   si ( EsPrimo ( yo ))
   {
       consola _ WriteLine ( i );
   }
}

 booleano estático EsPrimo  ( int n ) 
{
    bool  EsP = falso ;
    si ( ( n  %  2  !=  0 ) && ( Matemáticas . Sqrt ( n ) %  2  !=  0 ) )
    {
        ESP = verdadero ;
    }
    volver  ESP ;
}

*//*
Escribir una función (método int Fib(int n)) que calcule el término n de la serie de
Fibonacci. */
Fib(n) = 1, si n <=2
Fib(n) = Fib(n-1) + Fib(n-2), si n > 2
*/
static int Fib(int n)
{
    if(n<=2) return 1;
    else return Fib(n-1) + Fib(n-2);
}

int i=1;
Console.WriteLine(Fib(i));
Console.WriteLine(Fib(i+2));
