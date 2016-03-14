using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio1_ExamenParcial;

namespace PruebaCopiar
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[2, 2];
            laMatrizUno[0, 0] = 3;
            laMatrizUno[0, 1] = 4;
            laMatrizUno[1, 0] = 5;
            laMatrizUno[1, 1] = 5;

            double[,] laMatrizDos = new double[2, 2];
            laMatrizDos[0, 0] = 3;
            laMatrizDos[0, 1] = 4;
            laMatrizDos[1, 0] = 5;
            laMatrizDos[1, 1] = 3;

            double[,] resultadoEsperado = new double[2, 2];
            resultadoEsperado[0, 0] = 6;
            resultadoEsperado[0, 1] = 8;
            resultadoEsperado[1, 0] = 10;
            resultadoEsperado[1, 1] = 2;

            double[,] resultado = new double[2, 2];

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.SumaOResta resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.SumaOResta();
            resultado = resul.Calcular(laMatrizUno, laMatrizDos, 2, 2, false);

            Assert.AreEqual(resultado[1, 1], resultadoEsperado[1, 1]);

        }
    }
}
