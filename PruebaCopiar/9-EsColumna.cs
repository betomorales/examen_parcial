using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _8_EsColumna
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] laMatrizUno = new double[3, 1];
            laMatrizUno[0, 0] = 0;
            laMatrizUno[1, 0] = 0;
            laMatrizUno[2, 0] = 0;

            bool resultadoEsperado = true;
            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsColumna resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsColumna();
            resultado = resul.Calcular(laMatrizUno, 3, 1);

            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}
