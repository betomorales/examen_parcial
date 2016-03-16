using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsSimetrica
    {

        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            /* TO BE MOVED TO VALIDACIONES */
            if (maxCol != maxFila) { return false; }

            double[,] matrizTranspuesta = new Double[maxCol, maxFila];

            Transpuesta resul = new Transpuesta();
            matrizTranspuesta = resul.Calcular(matrizUno, maxCol, maxFila);

            int i = 0;
            int j = 0;

            bool sonIguales = true;

            for(i = 0; i < maxCol; i++)
            {
                for(j = 0; j < maxFila; j++)
                {
                    if(matrizUno[i,j] != matrizTranspuesta[i, j])
                    {
                        sonIguales = false;
                    }

                }

            }

            return sonIguales;
        }
        }
}