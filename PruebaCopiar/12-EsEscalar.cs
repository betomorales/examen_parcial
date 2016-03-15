using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _12_EsEscalar
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] laMatrizUno = new double[3, 3];
            laMatrizUno[0, 0] = -8;
            laMatrizUno[0, 1] = 0;
            laMatrizUno[0, 2] = 0;
            laMatrizUno[1, 0] = 0;
            laMatrizUno[1, 1] = -8;
            laMatrizUno[1, 2] = 0;
            laMatrizUno[2, 0] = 0;
            laMatrizUno[2, 1] = 0;
            laMatrizUno[2, 2] = -8;

            bool resultadoEsperado = true;
            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsEscalar resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsEscalar();
            resultado = resul.Calcular(laMatrizUno, 3, 3);

            Assert.AreEqual(resultado, resultadoEsperado);

        }
    }
}
