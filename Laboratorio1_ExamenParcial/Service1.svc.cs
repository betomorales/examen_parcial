using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Laboratorio1_ExamenParcial
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public double[][] Copiar(double[,] laMatriz, int numFilas, int numColumnas)
        {
            // Declare local jagged array with numFilas rows.
            double[][] resultado = new double[numFilas][];
            for (int i = 0; i < numFilas; i++)
            {
                double[] laFila = new double[numColumnas];
                for (int j = 0; j < numColumnas; j++)
                {
                    laFila[j] = laMatriz[i, j];
                }
                resultado[i] = laFila;
            }
            return resultado;
        } 
        
       /* public double[,] pruebaSuma()
        {
            double[,] laMatrizUno = new double[2, 2];
            laMatrizUno[0, 0] = 3;
            laMatrizUno[0, 1] = 4;
            laMatrizUno[1, 0] = 5;
            laMatrizUno[1, 1] = 5;

            double[,] laMatrizDos = new double[2, 2];
            laMatrizUno[0, 0] = 3;
            laMatrizUno[0, 1] = 4;
            laMatrizUno[1, 0] = 5;
            laMatrizUno[1, 1] = 5;

            double[,] resultado = new double[2, 2];
            LogicaNegocio.Acciones.SumaOResta resul = new LogicaNegocio.Acciones.SumaOResta();
            resultado = resul.Sumar(laMatrizUno, laMatrizDos, 2, 2);

            return resultado;
            
        }  */

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
