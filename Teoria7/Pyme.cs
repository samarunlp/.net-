namespace teoria7;
using System.Collections;

class Pyme: IEnumerable
{
    Empleado[] empleados = new Empleado[3];
    public Pyme(Empleado e1, Empleado e2, Empleado e3){
        empleados [0] = e1;
        empleados [1] =e2;
        empleados [2] = e3;
    }

    public IEnumerator GetEnumerator()
    {
        return empleados.GetEnumerator();
    }
}
