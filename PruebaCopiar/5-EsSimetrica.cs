using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _5_EsSimetrica
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[3, 3];
            laMatrizUno[0, 0] = 2;
            laMatrizUno[0, 1] = 1;
            laMatrizUno[0, 2] = 3;
            laMatrizUno[1, 0] = 1;
            laMatrizUno[1, 1] = 0;
            laMatrizUno[1, 2] = -2;
            laMatrizUno[2, 0] = 3;
            laMatrizUno[2, 1] = -2;
            laMatrizUno[2, 2] = -47;

            bool resultadoEsperado = true;

            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsSimetrica resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsSimetrica();
            resultado = resul.Calcular(laMatrizUno, 3, 3);

            Assert.AreEqual(resultado, resultadoEsperado);

        }
    }
}
