using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese Linea de Entrada");
                string msjEntrada = Console.ReadLine();

                if (msjEntrada.Length != 25)
                {
                    throw new Exception($"Error en la linea de entrada de datos. Se esperaba una entrada de 24 caracteres." +
                        $" Se obtuvieron " + msjEntrada.Length + $" caracteres");
                }

                if (!(DateTime.TryParseExact(msjEntrada.Substring(0, 14), "yyyyMMddHHmmss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechahora)))
                { throw new Exception("Los valores para fecha y hora ingresados no son validos. Se obtuvo: " + msjEntrada.Substring(0, 14)); }

                if (!(int.TryParse(msjEntrada.Substring(14, 3), out int num)))
                { throw new Exception("El valor ingresado para Temperatura es incorrecto. Se obtuvo: " + msjEntrada.Substring(14, 3)); }

                if (!(int.TryParse(msjEntrada.Substring(17, 3), out int num2)))
                { throw new Exception("El valor ingresado para Humedad es incorrecto. Se obtuvo: " + msjEntrada.Substring(18, 3)); }

                //Dividir linea de entrada
                string fecha = $"{msjEntrada.Substring(0, 4)}/{msjEntrada.Substring(4, 2)}/{msjEntrada.Substring(6, 2)}";
                string hora = $"{msjEntrada.Substring(8, 2)}:{msjEntrada.Substring(10, 2)}:{msjEntrada.Substring(12, 2)}.000";
                string temperatura = $"{msjEntrada.Substring(14, 2)},{msjEntrada.Substring(16, 1)}°";
                string humedad = $"{msjEntrada.Substring(17, 2)},{msjEntrada.Substring(19, 1)}%";
                string codigo = string.Concat("\"", msjEntrada.Substring(20, 4), "\"");
                string activo = msjEntrada.Substring(24, 1) == "1" ? "SI" : (msjEntrada.Substring(24, 1) == "0" ? "NO"
                        : throw new Exception("El estado ingresado es incorrecto. Se espera 1 o 0. Se obtuvo " + msjEntrada.Substring(24, 1)));


                //Salida en Formato1
                Console.WriteLine("Respuesta Tipo 1");
                Console.WriteLine("Fecha del registro: {0}", fecha);
                Console.WriteLine("Hora del registro: {0}", hora);
                Console.WriteLine("Temperatura: {0}", temperatura);
                Console.WriteLine("Humedad: {0}", humedad);
                Console.WriteLine("Codigo: {0}", codigo);
                Console.WriteLine("Activo: {0}", activo);

                //Salida Formato2
                //Console.WriteLine("Respuesta Tipo 2");
                //Console.WriteLine("Fecha/Hora registro: {0} {1}",fecha, hora);
                //Console.WriteLine("Temperatura: {0}", temperatura);
                //Console.WriteLine("Humedad: {0}", humedad);
                //Console.WriteLine("Codigo: {0}", codigo);
                //Console.WriteLine("Activo: {0}", activo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



