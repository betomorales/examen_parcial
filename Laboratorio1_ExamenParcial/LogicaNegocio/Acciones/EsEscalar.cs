using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsEscalar
    {
        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            /* TO BE MOVED TO VALIDACIONES */
            if (maxCol != maxFila) { return false; }

            bool esEstaDiagonal = false;
            int i = 0;
            int j = 0;
            double recordadora = 0;
            bool resultado = true;

            EsDiagonal resul = new EsDiagonal();
            esEstaDiagonal = resul.Calcular(matrizUno, maxCol, maxFila);

            if (!esEstaDiagonal) { return false; }

           // if (esEstaDiagonal)
            //{
                recordadora = matrizUno[0, 0];
                for (i = 0; i < maxCol; i++)
                {
                    for(j = 0; j < maxFila; j++)
                    {
                        if(i == j)
                        {
                            
                            if(matrizUno[i, j] != recordadora)
                            {
                                resultado = false;
                                ////exit????
                            }
                            recordadora = matrizUno[i, j];
                        }
                    }

                }
           // }
            return resultado;
        }
        
    }
}