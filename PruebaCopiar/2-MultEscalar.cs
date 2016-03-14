using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] laMatrizUno = new double[2, 2];
            laMatrizUno[0, 0] = 3;
            laMatrizUno[0, 1] = 4;
            laMatrizUno[1, 0] = 5;
            laMatrizUno[1, 1] = 5;

            double[,] resultadoEsperado = new double[2, 2];
            resultadoEsperado[0, 0] = 12;
            resultadoEsperado[0, 1] = 16;
            resultadoEsperado[1, 0] = 20;
            resultadoEsperado[1, 1] = 20;

            int escalar = 4;

            double[,] resultado = new double[2, 2];
            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.MultiplicarPorEscalar resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.MultiplicarPorEscalar();
            resultado = resul.Calcular(laMatrizUno, 2, 2, escalar);

            Assert.AreEqual(resultado[1, 1], resultadoEsperado[1, 1]);

        }
    }
}
