using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _4_Transpuesta
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[3, 2];
            laMatrizUno[0, 0] = 2;
            laMatrizUno[0, 1] = 3;
            laMatrizUno[1, 0] = 2;
            laMatrizUno[1, 1] = 4;
            laMatrizUno[2, 0] = 2;
            laMatrizUno[2, 1] = 5;


            double[,] resultadoEsperado = new double[2, 3];
            resultadoEsperado[0, 0] = 2;
            resultadoEsperado[0, 1] = 2;
            resultadoEsperado[0, 2] = 2;
            resultadoEsperado[1, 0] = 3;
            resultadoEsperado[1, 1] = 4;
            resultadoEsperado[1, 2] = 5;

            double[,] resultado = new double[2, 3];

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.Transpuesta resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.Transpuesta();
            resultado = resul.Calcular(laMatrizUno,2,3);

            Assert.AreEqual(resultado[1, 1], resultadoEsperado[1, 1]);

        }
    }
}
