using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_ExamenParcial.LogicaNegocio.Acciones
{
    public class EsFila
    {
        public bool Calcular(double[,] matrizUno, int maxCol, int maxFila)
        {
            bool resultado = false;
            if (maxCol == 1) resultado = true;

            return resultado;

        }

    }
}