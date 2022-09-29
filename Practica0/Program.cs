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
            string msjEntrada = "";

            Console.WriteLine("Ingrese Linea de Entrada");
            msjEntrada = Console.ReadLine();
            try
            {
                string fechaTxt = string.Concat(msjEntrada.Substring(0, 4), "/", msjEntrada.Substring(4, 2), "/", msjEntrada.Substring(6, 2));
                string hsTxt2 = string.Concat(msjEntrada.Substring(8, 2), ":", msjEntrada.Substring(10, 2), ":", msjEntrada.Substring(12, 2), ".000");
                string hsTxt = string.Concat(msjEntrada.Substring(8, 2), "Hs ", msjEntrada.Substring(10, 2), "Min ", msjEntrada.Substring(12, 2), "Seg");
                string temperaturaTxt = string.Concat(msjEntrada.Substring(14, 2), ",", msjEntrada.Substring(16, 1), "°");
                string humedadTxt = string.Concat(msjEntrada.Substring(17, 2), ",", msjEntrada.Substring(19, 1), "%");
                string codigoTxt = string.Concat("\"", msjEntrada.Substring(20, 4), "\"");
                char activoChar = char.Parse(msjEntrada.Substring(24, 1));
                string activo = "No";

                if (activoChar == 1)
                {
                    activo = "Si";
                }

                //Salida en Formato1. Elegi esta porque me parece mas claro la manera de mostrar fecha y hora
                Console.WriteLine("Respuesta Tipo 1");
                Console.WriteLine("Fecha del registro: {0}", fechaTxt);
                Console.WriteLine("Hora del registro: {0}", hsTxt);
                Console.WriteLine("Temperatura: {0}", temperaturaTxt);
                Console.WriteLine("Humedad: {0}", humedadTxt);
                Console.WriteLine("Codigo: {0}", codigoTxt);
                Console.WriteLine("Activo: {0}", activo);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}
