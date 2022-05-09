class Program
{
    static void main(string []args){
    int a=17;
    int b=23;
    Swap<int>(ref a, ref b);  //con esta invocacion, evito la sobre carga
    Console.WriteLine($"a={a} y b={b}");
    string st1="hola";
    string st2="mundo";
    Swap<string>(ref st1, ref st2);
    Console.WriteLine($"string1={st1} y string2={st2}");


    int i= (int) Maximo(100,5);
    Console.WriteLine(i);
    string st=(string) Maximo("hola","mundo");
    Console.WriteLine(st);
    Console.WriteLine(Maximo('A','B'));
    }

 
static void Swap<T>(ref T i, ref T j){ //solucion modificada
    T auxi=i;
    i=j;
    j=auxi;
}

static T Maximo <T> (T a, T b) where T : IComparable{ //se resuelve imponiendo 
    if(a.CompareTo(b) > 0){
        return a;
    }
    return b;
}

}

    

        /*con object es confusa y larga, no eficiente
        MAIN
        object o1,o2;
        int a=17;
        int b=23;
        o1=a;
        o2=b;
        Swap(ref o1, ref o2);
        Console.WriteLine($"a={a} y b={b}");
        string st1="hola";
        string st2="mundo";
        o1=st1;
        o2=st2;
        Swap(ref o1, ref o2);
        st1=(string)o1;
        st2=(string)o2;
        Console.WriteLine($"string1={st1} y string2={st2}");
        
        static void Swap (ref object i, ref object j){  //esta es la solucion para simplificar, el problema esta en ref porque apunta
                                                // a un tipo de dato q no seria el mismo 
        object auxi=i;
        i=j;
       j=auxi;
        }
        */
 
        /*con dynamic no es una buena solucion pq se pierden chequeos de seg y realiza boxing 
        dynamic a=17;
        dynamic b=23;
        Swap(ref await,ref b);
        Console.WriteLine($"a={a} y b={b}");
        dynamic st1="hola";
        dynamic st2="mundo";
        Swap(ref st1, ref st2);
        Console.WriteLine($"string1={st1} y string2={st2}");

        static void Swap(ref dynamic i, dynamic string j){
         dynamic auxi=i;
          i=j;
         j=auxi;
        }*/
