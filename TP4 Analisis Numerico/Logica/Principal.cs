using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public double ObtenerFuncion(double Limite)
        {
            // Calcula el f(limite) pedido
            double resultadoo = new double();
            double aux1 = 0;
            double aux2 = 0;

            //Actividad 2 A
            aux1 = 1 / (Limite + 0.5);
            aux2 = (1 / 4) * Math.Pow(Limite, 2);
            resultadoo = aux1 + aux2;

            //Actividad 2 B
            resultadoo = 1 + Math.Pow(Limite, 2);
            resultadoo = Math.Log(resultadoo);

            //Actividad 2 C
            resultadoo = Math.Pow(Math.E, Limite) * (1 + (0.5 * Math.Pow(Limite, 2)));

            //Actividad 3
            double Gfuncion = (-3 / 4) * Math.Pow(Limite, 2);
            Gfuncion = Gfuncion - Limite + 4;
            aux1 = (1 / 16) * Math.Pow(Limite, 4);
            aux2 = (1 / 4) * Math.Pow(Limite, 3);
            double Ffuncion = aux1 - aux2;
            resultadoo = Gfuncion - Ffuncion;

            return resultadoo;
        }

        //Trapezoide Simple
        public double MetodoTrapezoideSimple(Datos dato)
        {
            double Area = 0;

            Area = ObtenerFuncion(dato.ValorXA) + ObtenerFuncion(dato.ValorXB);
            Area = Area * (dato.ValorXB * dato.ValorXA);
            Area = Area / 2;

            return Area;
        }

        //TrapezoideMultiple
        public double MetodoTrapezoideMultiple(Datos dato, int Nintervalos)
        {
            double Area = 0;
            double h = dato.ValorXB - dato.ValorXA;
            double aux = (dato.ValorXB - dato.ValorXA) / Nintervalos;
            double intervalo = dato.ValorXA + aux;

            for (int i = 1; i < Nintervalos; i++)
            {
                Area += ObtenerFuncion(intervalo);
                intervalo += aux;
            }
            Area = (Area * 2) + ObtenerFuncion(dato.ValorXA) + ObtenerFuncion(dato.ValorXB);
            Area = Area * (h / 2);

            return Area;
        }

        //Simpson 1/3 Simple
        public double MetodoSimpsonSimpleUnTercio(Datos dato)
        {
            double Area = 0;
            double x1 = (dato.ValorXA + dato.ValorXB) / 2;
            double h = (dato.ValorXB - dato.ValorXA) / 2;

            Area = ObtenerFuncion(dato.ValorXB) + (ObtenerFuncion(x1) * 4) + ObtenerFuncion(dato.ValorXA);

            return Area;
        }

        //Simpson 1/3 Multiple
        public double MetodoSimpsonMultipleUnTercio(Datos dato, int Nintervalos)
        {
            double Area = 0;
            double h = (dato.ValorXB - dato.ValorXA) / Nintervalos;
            double intervalo = dato.ValorXA + h;
            bool ban = false;
            double aux1 = 0;
            double aux2 = 0;

            for (int i = 1; i < Nintervalos; i++)
            {
                if (ban == false)
                {
                    aux1 += ObtenerFuncion(intervalo);
                    ban = true;
                }
                else
                {
                    aux2 += ObtenerFuncion(intervalo);
                    ban = true;
                }
                intervalo += h;
            }
            Area = ObtenerFuncion(dato.ValorXA) + (4 * aux1) + (2 * aux2) + ObtenerFuncion(dato.ValorXB);
            Area = (h / 3) * Area;

            return Area;
        }

        //Simpson 3/8
        public double MetodoSimpsonTresOctavos(Datos dato)
        {
            double Area = 0;
            double h = (dato.ValorXB - dato.ValorXA) / 3;
            double x1 = dato.ValorXA + h;
            double x2 = x1 + h;
            double x3 = x2 + h;

            Area = ObtenerFuncion(dato.ValorXA) + (3 * ObtenerFuncion(x1)) + (3 * ObtenerFuncion(x2)) + ObtenerFuncion(x3);
            Area = Area * ((3 / 8) * h);

            return Area;
        }
    }
}