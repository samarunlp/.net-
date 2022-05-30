using CalculoSimple;

ILogger logger= new LoggerArchivo();
Calculador calc=new Calculador(logger); //inyeccion de dependencia
calc.Calcular(3);
