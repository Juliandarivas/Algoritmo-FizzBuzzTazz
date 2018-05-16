using System;

namespace FizzBuzzTazz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Cantidad: ");
            string valor = Console.ReadLine();
            string[] resultado =
            EjecutarPrograma(valor);
            Console.WriteLine("\n" + String.Join(",", resultado));
            Console.ReadKey();
        }

        public static string[] EjecutarPrograma(string valor)
        {
            int cantidad = 0;

            if (int.TryParse(valor, out cantidad) != true)
            {   
                throw new FormatException("El valor es inválido");
            }

            return LlenarFizzBuzzTazz(cantidad);
        }

        public static string[] LlenarFizzBuzzTazz(int cantidad)
        {
            string[] lista = new string[cantidad];
            int indice;

            for (int i = 0; i < cantidad; i++)
            {
                indice = i + 1;

                lista[i] = string.Empty;

                if (indice % 3 == 0)
                    lista[i] += "Fizz";

                if (indice % 5 == 0)
                    lista[i] += "Buzz";

                if (indice % 7 == 0)
                    lista[i] += "Tazz";

                if (string.IsNullOrEmpty(lista[i]))
                    lista[i] = indice.ToString();
            }

            return lista;
        }
    }
}
