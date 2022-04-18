//Strings de formato compuesto
{
string marca= "Ford";
int modelo = 2000; 
string st;
st = string.Format("Es un {0} año {1}", marca, modelo); //esto es un string con marcadores de posicion indizados, y lo otro un vector de objetos 
                   //elementosdeformatos  
Console.WriteLine(st);
}

Console.WriteLine("\n");


//Strings interpolados
{
string marca= "Ford";
int modelo = 2000; 
string st = $"Es un {marca,7} año {modelo}";
string st2 = $"Es un {"Nissan",-7} año {2020}";  //el 7 le da alineacion a la izq y con el - le da a la der
Console.WriteLine(st2);
}
Console.WriteLine("\n");

{
    double r= 2.417;                     //este prog redondea, no trunca 
    Console.WriteLine($"Valor = {r:0.0}");
    Console.WriteLine($"Valor = {r:0.00}");
}
Console.WriteLine("\n");

//Ejercitando con List<int>
{
List<int> lista = new List<int>() {10,20,30,40 };
lista.Add(55);
lista.Remove(30);
lista.RemoveAt(1); //borra el elem de la posicion 1
lista.Insert(2,22); //en la pos 2,agrega el elem 22
int [] vector = new int []{31,32,33};
lista.InsertRange(3,vector);
for (int i=0;i< lista.Count;i++){
    Console.WriteLine(lista[i]);
    }
}
Console.WriteLine("\n");

{
double[]? vector = new double [10];
Procesar(vector, 1, 1);

    void Procesar(double[]? v, int i, int c)
    {
        c=c+10;
        v[i]= 1000 /c;
        Console.WriteLine(v[i]);
    }
}
