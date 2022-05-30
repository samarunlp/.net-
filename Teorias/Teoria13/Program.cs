using Microsoft.Extensions.DependencyInjection;
using CalculoSimple;

var servicios= new ServiceCollection();
servicios.AddTransient<ICalculador,Calculador>();   //se registran los servicios y se construye el proveedor
servicios.AddTransient<ILogger,Logger>();
var proveedor= servicios.BuildServiceProvider();    //hasta acá
var calc=proveedor.GetService<ICalculador>(); 
calc?.Calcular(3);  //? evita posible null

//de esta forma, la clase ProveedorServicios ya no es necesaria
