using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsColumna
    {
        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            bool resultado = false;
            if (maxFila == 1) resultado = true;

            return resultado;

        }

    }
}