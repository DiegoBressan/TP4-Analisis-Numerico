using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logica;

namespace Formulario
{
    interface FormularioPrincipal
    {
        double MetodoTrapezoideSimple(Datos dato);
        double MetodoTrapezoideMultiple(Datos dato, int Nintervalos);
        double MetodoSimpsonSimpleUnTercio(Datos dato);
        double MetodoSimpsonMultipleUnTercio(Datos dato, int Nintervalos);
        double MetodoSimpsonTresOctavos(Datos dato);
    }
}
