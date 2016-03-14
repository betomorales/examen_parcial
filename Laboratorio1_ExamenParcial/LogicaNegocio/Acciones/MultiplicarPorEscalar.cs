using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class MultiplicarPorEscalar
    {

        public double[,] Calcular(double[,] matrizUno, int men, int max, int escalar)
        {

            double[,] matrizResultante = new Double[men, max];
            int i = 0, j = 0;

            for (i = 0; i < men; i++)
            {
                for (j = 0; j < max; j++)
                {
                    matrizResultante.SetValue(matrizUno[i, j] * escalar, i, j);
                }
            }

            return matrizResultante;

        }
    }
}