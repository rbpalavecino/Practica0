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
            string infoEntrada = "";
            //PIDO INFORMACION DEL SENSOR
            Console.WriteLine("Ingrese información del sensor");
            infoEntrada = Console.ReadLine();

            //!! Falta validar los datos de entrada
            //!! Una linea mas larga, o con caracteres incorrectos es procesada como si fuera correcta.
            //!! Una linea con un caracter de menos hace explotar el programa y el mismo no da explicaciones de por que falló

            
            //!!Se puede evitar el uso de las variables "crudas", reutilizando el mismo string para la lectura cruda
            //y luego la formateada. Ejemplo: 
            string fechaRegistro = infoEntrada.Substring(0, 8);
            fechaRegistro = fechaRegistro.Substring(0, 4) + "/" + fechaRegistro.Substring(4, 2) + "/" + fechaRegistro.Substring(6, 2);
            //Al haber menos variables, se usa menos memoria y menos procesamiento.


            //PARSEO DE DATOS
            //Fecha / año mes dia 
            //string fechaRegistroCruda = infoEntrada.Substring(0, 8);
            //string fechaRegistroFormateada = fechaRegistroCruda.Substring(0, 4) + "/" + fechaRegistroCruda.Substring(4, 2) + "/" + fechaRegistroCruda.Substring(6, 2);
            
            //Horario / Hora minuto segundo
            string horarioRegistroCruda = infoEntrada.Substring(8, 6);
            string horarioRegistroFormateada = horarioRegistroCruda.Substring(0, 2) + "Hs " + horarioRegistroCruda.Substring(2, 2) + "Min " + horarioRegistroCruda.Substring(4, 2) + "Seg";
           
            //Temperatura
            string temperaturaCrudo = infoEntrada.Substring(14, 3);
                    // damos formato esperado
            string temperaturaFormateada = temperaturaCrudo.Substring(0, 2) + "," + temperaturaCrudo.Substring(2, 1) + "°";

            //Humedad
            // damos formato esperado
            string humedadCruda = infoEntrada.Substring(17, 3);
            string humedadFormateada = humedadCruda.Substring(0, 2) + "," + humedadCruda.Substring(2, 1) + "%";

            //Codigo sensor
            string codigoSensor = infoEntrada.Substring(20, 4);

            //Estado
            string estadoSensorCrudo = infoEntrada.Substring(24, 1);
            string estadoSensorFormateado = "";
            if (estadoSensorCrudo == "1")
                { estadoSensorFormateado = "SI"; } 
            else 
                { estadoSensorFormateado = "NO"; }


            //Impresion de datos
            // Elegí la respuesta "Tipo 1" xq me pareció mas practico tener por separado la fecha y la hora en caso que despues necesite los datos
            Console.WriteLine("Fecha del registro: {0}", fechaRegistro);
            Console.WriteLine("Hora del registro: {0}", horarioRegistroFormateada);
            Console.WriteLine("Temperatura: {0}", temperaturaFormateada);
            Console.WriteLine("Humedad: {0}", humedadFormateada);
            Console.WriteLine("Codigo: \"{0}\" ", codigoSensor);
            Console.WriteLine("Activo: {0} ", estadoSensorFormateado);
            
            //!! Normlamente en los programas de consola, no se utiliza, ya que se llaman desde la consola y la misma permanece abierta.
            //En caso de decidir usarlo, recomiendo usar RedKey() e imprimir el msje "Presione una tecla para finalizar..."  o similar

            //si no pongo este readline se cierra el programa y no llego a ver lo que imprimi
            string a = Console.ReadLine(); 
            
        }
    }
}
