using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class ObtenerDiagonal
    {
        public double[] Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            /* TO BE MOVED TO VALIDACIONES */
            if (maxCol != maxFila) { return null; }

            double[] vectorResultante = new double[maxCol];

            int i = 0;
            int j = 0;
            int posActual = 0;

            for (i = 0; i < maxCol; i++)
            {
                for (j = 0; j < maxFila; j++)
                {
                    if (i == j)
                    {
                        vectorResultante.SetValue(matrizUno[i, j], posActual);
                        //vectorResultante.SetValue(matrizUno[i, j], posActual);
                        //vectorResultante[posActual] = matrizUno[i, j];
                        posActual++;

                    }

                }
            }
            return vectorResultante;
        }
    }

}