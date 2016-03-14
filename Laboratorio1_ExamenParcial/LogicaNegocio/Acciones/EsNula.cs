using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsNula
    {

        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            /* TO BE MOVED TO VALIDACIONES */
            bool result = true;
            int i = 0;
            int j = 0;

            for(i = 0; i < maxCol; i++)
            {
                for(j = 0; j < maxFila; j++)
                {
                    if(matrizUno[i, j] != 0)
                    {
                        result = false;
                    }
                }
            }

            return result;

        }

    }
}