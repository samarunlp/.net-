namespace CalculoSimple;
class Calculador : ICalculador{  //clase de alto nivel()
    ILogger _logger;
    public Calculador(ILogger logger){
        _logger=logger;
    }
    public void Calcular(int n){
        int resul=(n+5)*(n+7);
 
