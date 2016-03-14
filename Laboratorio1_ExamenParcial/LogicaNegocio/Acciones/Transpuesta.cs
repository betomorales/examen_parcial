using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class Transpuesta
    {

        public double[,] Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {

            double[,] matrizResultante = new Double[maxCol, maxFila];
            int i = 0;
            int curCol = 0;


            for(i = 0; i < maxCol; i++)
            {
                for (curCol = 0; curCol < maxFila; curCol++)
                {
                    matrizResultante.SetValue(matrizUno[curCol, i], i, curCol);

                }
                    

            }

            return matrizResultante;
        }

    }
}