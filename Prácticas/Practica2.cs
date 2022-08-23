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
//La salida por consola es falso y 0 ya que args no tiene contenido declarado.

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

