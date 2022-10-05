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
                //!! Falta validar los datos de entrada
                //!! Una linea mas larga, o con caracteres incorrectos es procesada como si fuera correcta.
                //!! Una linea con un caracter de menos hace explotar el programa y el mismo no da explicaciones de por que falló

                //!! Sugerencia: Quizas sea mas legible con el operador "$"
                //string fechaTxt = $"{msjEntrada.Substring(0, 4)}/{msjEntrada.Substring(4, 2)}/{msjEntrada.Substring(6, 2)}";

                //!! No se recomienda poner el tipo de variable en el nombre. El nombre de la variable debe ser tal que el lector pueda inferir rapidamente
                //de que tipo de dato se trata.
                string fechaTxt = string.Concat(msjEntrada.Substring(0, 4), "/", msjEntrada.Substring(4, 2), "/", msjEntrada.Substring(6, 2));
                string hsTxt2 = string.Concat(msjEntrada.Substring(8, 2), ":", msjEntrada.Substring(10, 2), ":", msjEntrada.Substring(12, 2), ".000");
                string hsTxt = string.Concat(msjEntrada.Substring(8, 2), "Hs ", msjEntrada.Substring(10, 2), "Min ", msjEntrada.Substring(12, 2), "Seg");
                string temperaturaTxt = string.Concat(msjEntrada.Substring(14, 2), ",", msjEntrada.Substring(16, 1), "°");
                string humedadTxt = string.Concat(msjEntrada.Substring(17, 2), ",", msjEntrada.Substring(19, 1), "%");
                
                //!! Se puede simplificar el escapeo "@"
                string codigoTxt = string.Concat("\"", msjEntrada.Substring(20, 4), "\"");
                char activoChar = char.Parse(msjEntrada.Substring(24, 1));

                string activo = "No";

                //!! Se parsea a char una letra, funciona pero es rebuscado (hay formas mas sencillas de hacerlo)
                //Se podria preguntar en el if por == "1" y el resultado seria el mismo, solo que se ahorraria un casteo
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
                //!! Bien por el control de error, pero guarda el error pero no dice que fue. Termina sin mostrar datos, y encima no me dice por que no los mostró
                string error = ex.Message;
            }
        }
    }
}
