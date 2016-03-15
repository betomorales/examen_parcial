using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsDiagonal
    {

        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            /* TO BE MOVED TO VALIDACIONES */
            if(maxCol != maxFila) { return false;  }

            int i = 0;
            int j = 0;
            bool resultado = false;

            for(i = 0; i < maxCol; i++)
            {
                for(j = 0; j < maxFila; j++)
                {
                    if(i != j)
                    {
                        if(matrizUno[i, j] != 0)
                        {
                            resultado = true;
                        }
                    }

                }
                
            }
            return !resultado;
        }



    }
}