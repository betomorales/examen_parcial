using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _3_Multiplicacion
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[2, 3];
            laMatrizUno[0, 0] = 20;
            laMatrizUno[0, 1] = 30;
            laMatrizUno[0, 2] = 60;
            laMatrizUno[1, 0] = 40;
            laMatrizUno[1, 1] = 50;
            laMatrizUno[1, 2] = 70;

            double[,] laMatrizDos = new double[3, 2];
            laMatrizDos[0, 0] = 20;
            laMatrizDos[0, 1] = 40;
            laMatrizDos[1, 0] = 30;
            laMatrizDos[1, 1] = 50;
            laMatrizDos[2, 0] = 60;
            laMatrizDos[2, 1] = 70;


            double[,] resultadoEsperado = new double[2, 2];
            resultadoEsperado[0, 0] = 4900;
            resultadoEsperado[0, 1] = 6500;
            resultadoEsperado[1, 0] = 6500;
            resultadoEsperado[1, 1] = 9000;

            double[,] resultado = new double[2, 2];


            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.Multiplicacion resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.Multiplicacion();
            resultado = resul.Calcular(laMatrizUno, laMatrizDos, 2, 3, 2);

            Assert.AreEqual(resultado[1, 1], resultadoEsperado[1, 1]);

        }
    }
}
