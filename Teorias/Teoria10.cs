class Program
{
    static void Main (string[] args){
        Task t= PrintAsync();
        for(int i=1;i <= 100; i++){
            Console.Write("-");
        }
        Console.WriteLine();
        t.Wait();
    }

    
    static void ImprimirA(){
        for(int i=1;i <= 1000; i++){
            Console.Write("A");
        }
        Console.WriteLine(" FIN");
    }  

    static async Task PrintAsync(){  //metodo cortito , al utilizar await dentro de un metodo hay que calificarlo con async
        Task t = new Task(ImprimirA);
        DateTime inicio=DateTime.Now;
        t.Start();   //aca comienza el metodo
        //t.Wait();  esto funciona pero hace a Print sincronico , secuencial
        await t; // el operador await realiza la espera de manera asincronica de t que necesitamos
        double mlseg= (DateTime.Now - inicio).TotalMilliseconds;  //se calcula el tiempo q termino la tarea (imprimir)
        Console.Write($" \n Tiempo transcurrido: {mlseg} \n");
        //return t;     eliminamos esta linea por el await y no retorna t, retorna una tarea nueva q hace el operador
    }
}

