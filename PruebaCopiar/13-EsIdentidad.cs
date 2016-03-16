using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaCopiar
{
    [TestClass]
    public class _13_EsIdentidad
    {
        [TestMethod]
        public void TestMethod1()
        {

            double[,] laMatrizUno = new double[3, 3];
            laMatrizUno[0, 0] = 1;
            laMatrizUno[0, 1] = 0;
            laMatrizUno[0, 2] = 0;
            laMatrizUno[1, 0] = 0;
            laMatrizUno[1, 1] = 1;
            laMatrizUno[1, 2] = 0;
            laMatrizUno[2, 0] = 0;
            laMatrizUno[2, 1] = 0;
            laMatrizUno[2, 2] = 1;

            bool resultadoEsperado = true;
            bool resultado;

            Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsIdentidad resul = new Laboratorio1_ExamenParcial.LogicaNegocio.Acciones.EsIdentidad();
            resultado = resul.Calcular(laMatrizUno, 3, 3);

            Assert.AreEqual(resultado, resultadoEsperado);

        }
    }
}
