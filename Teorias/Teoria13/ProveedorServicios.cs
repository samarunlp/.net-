//no lo usamos pero lo tengo 

namespace CalculoSimple;
class ProveedorServicios{
    public ILogger GetLogger();
    => new Logger();
    public ICalculador GetCalculador();
    => new Calculador(this.GetLogger());
}
