using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _16_ObtenerDiagonal
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[3, 3];
            laMatrizUno[0, 0] = -11;
            laMatrizUno[0, 1] = 7;
            laMatrizUno[0, 2] = -3;
            laMatrizUno[1, 0] = 4;
            laMatrizUno[1, 1] = 6;
            laMatrizUno[1, 2] = -8;
            laMatrizUno[2, 0] = 0;
            laMatrizUno[2, 1] = 2;
            laMatrizUno[2, 2] = -17;

            double[] resultadoEsperado = new double[3];
            resultadoEsperado[0] = -11;
            resultadoEsperado[1] = 6;
            resultadoEsperado[2] = -17;

            double[] resultado = new double[3];

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.ObtenerDiagonal resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.ObtenerDiagonal();
            resultado = resul.Calcular(laMatrizUno, 3,3);

            Assert.AreEqual(resultado[2], resultadoEsperado[2]);

        }
    }
}
