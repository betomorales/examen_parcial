using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class Multiplicacion
    {

        public double[,] Calcular(double[,] matrizUno, double[,] matrizDos, int colA, int filA, int filB)
        {
            /* TO BE COMPLETED */
            int j = 0;
            int i = 0;

            double resParcial = 0;
            double resParcial2 = 0;
            int movCol = 0;
            int movFil = 0;

            colA = colA - 1;
            filA = filA - 1;
            filB = filB - 1;

            double[,] matrizResultante = new Double[filA, filA];

            for (i = 0; i <= colA; i++)
            {
                   for(j = 0; j <= filA; j++)
                {
                    resParcial = resParcial + (matrizUno[i, j] * matrizDos[j, i]);
                    resParcial2 = resParcial2 + (matrizUno[i, j] * matrizDos[i+1, j]);
                    //matrizResultante.SetValue(matrizUno[i, j] * matrizDos[j,i], i, j);
                }
                matrizResultante.SetValue(resParcial, movCol, movFil);
                matrizResultante.SetValue(resParcial2, movCol, movFil+1);
                movCol = movCol + 1;
                movFil = 0;
                resParcial = 0;
                resParcial2 = 0;

            }

            return matrizResultante;
        }


    }
}