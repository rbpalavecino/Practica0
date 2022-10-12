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
            string infoIngresada = "";      //!! Se puede evitar la inicializacion

            Console.WriteLine("Ingrese la información:");
            //string palabra = infoIngresada + "hola";
            
            //string infoIngresada = Console.ReadLine();

            //!! Faltaria validar los datos de entrada
            //!! Una linea mas larga o con caracteres incorrectos es procesada como si fuera correcta. Ej: HOLA1121231110123456AC1C1
            //!! Una linea con un caracter de menos hace explotar el programa y el mismo no da explicaciones de por que falló
            
            try
            {
                //DateTime.TryParseExact
                string fecha = infoIngresada.Substring(0, 4) + '/' + infoIngresada.Substring(4, 2) + '/' + infoIngresada.Substring(6, 2);
                string hora = infoIngresada.Substring(8, 2) + "Hs " + infoIngresada.Substring(10, 2) + "Min " + infoIngresada.Substring(12, 2) + "Seg";
                
                //int.TryParse()
                //Double.TryParse()
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

                //!! Normalmente los programas de consola (aplicativos de Win y linux), terminan sin solicitar presionar una tecla
                // pero en caso de decidir hacerlo, estaria bueno, poner un cartel avisando "Presione una tecla para salir..."
                Console.ReadKey();
            }
            catch //(Exception ex)
            {
                //!! Me avisa que hubo un error, pero no me dice que pasó, ni donde.
                Console.WriteLine("Se produjo un error.");
                Console.ReadKey();
            }


        }

    }
}
