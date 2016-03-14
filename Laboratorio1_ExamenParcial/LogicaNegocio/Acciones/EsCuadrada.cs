using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsCuadrada
    {
        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            bool resultado = false;
            if (maxFila == maxCol) resultado = true;

            return resultado;

        }

    }
}