using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsIdentidad
    {

        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            /* TO BE MOVED TO VALIDACIONES */
            if (maxCol != maxFila) { return false; }

            bool esEstaDiagonal = false;
            int i = 0;
            int j = 0;

            EsDiagonal resul = new EsDiagonal();
            esEstaDiagonal = resul.Calcular(matrizUno, maxCol, maxFila);

            if (!esEstaDiagonal) { return false; }

            bool resultado = false;


            for (i = 0; i < maxCol; i++)
            {
                for (j = 0; j < maxFila; j++)
                {
                    if (i == j)
                    {
                        if (matrizUno[i, j] != 1)
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