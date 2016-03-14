using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _10_EsCuadrada
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] laMatrizUno = new double[2, 2];
            laMatrizUno[0, 0] = 0;
            laMatrizUno[0, 1] = 0;
            laMatrizUno[1, 0] = 0;
            laMatrizUno[1, 1] = 0;

            bool resultadoEsperado = true;
            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsCuadrada resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsCuadrada();
            resultado = resul.Calcular(laMatrizUno, 2, 2);

            Assert.AreEqual(resultado, resultadoEsperado);

        }
    }
}
