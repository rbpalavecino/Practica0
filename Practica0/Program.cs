using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoIngresada = "";

            Console.WriteLine("Ingrese la información:");
            infoIngresada = Console.ReadLine();

            try
            {
                string fecha = infoIngresada.Substring(0, 4) + '/' + infoIngresada.Substring(4, 2) + '/' + infoIngresada.Substring(6, 2);
                string hora = infoIngresada.Substring(8, 2) + "Hs " + infoIngresada.Substring(10, 2) + "Min " + infoIngresada.Substring(12, 2) + "Seg";
                string temperatura = infoIngresada.Substring(14, 2) + ',' + infoIngresada.Substring(16, 1);
                string humedad = infoIngresada.Substring(17, 2) + ',' + infoIngresada.Substring(19, 1);

                string codigoSensor = infoIngresada.Substring(20,4);
                string estadoActivoSensor = (infoIngresada.Substring(24,1) == "1")? "SI" : "NO";

                //Se elige el primer tipo de respuesta ya que la información queda mejor organizada visualmente para el usuario 
                Console.WriteLine("Fecha del registro: {0} ", fecha);
                Console.WriteLine("Hora del registro: {0} ", hora);
                Console.WriteLine("Temperatura: {0}°", temperatura);
                Console.WriteLine("Humedad: {0}% ", humedad);
                Console.WriteLine("Código: “{0}” ", codigoSensor);
                Console.WriteLine("Activo: {0} ", estadoActivoSensor);

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Se produjo un error.");
                Console.ReadKey();
            }

        }

    }
}
