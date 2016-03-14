using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class SumaOResta
    {
        public double[,] Calcular(double[,] matrizUno, double[,] matrizDos, int men, int max, bool Operacion)
        {
            double[,] matrizResultante = new Double[men,max];
            int i = 0, j = 0;

            for(i = 0; i < men; i++)
            {
                for(j = 0; j < max; j++)
                {
                    matrizResultante.SetValue(Operacion == true ? (matrizUno[i, j] + matrizDos[i, j]) : (matrizUno[i, j] - matrizDos[i, j]), i, j);
                }
            }

            return matrizResultante;
        }
    }
}