using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _8_EsFila
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[1, 3];
            laMatrizUno[0, 0] = 0;
            laMatrizUno[0, 1] = 0;
            laMatrizUno[0, 2] = 0;

            bool resultadoEsperado = true;
            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsFila resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsFila();
            resultado = resul.Calcular(laMatrizUno, 1, 3);

            Assert.AreEqual(resultado, resultadoEsperado);


        }
    }
}
