using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _11_EsDiagonal
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[3, 3];
            laMatrizUno[0, 0] = 7;
            laMatrizUno[0, 1] = 0;
            laMatrizUno[0, 2] = 0;
            laMatrizUno[1, 0] = 0;
            laMatrizUno[1, 1] = 3;
            laMatrizUno[1, 2] = 0;
            laMatrizUno[2, 0] = 0;
            laMatrizUno[2, 1] = 0;
            laMatrizUno[2, 2] = -8;


            bool resultadoEsperado = true;
            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsDiagonal resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsDiagonal();
            resultado = resul.Calcular(laMatrizUno, 3, 3);

            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}
