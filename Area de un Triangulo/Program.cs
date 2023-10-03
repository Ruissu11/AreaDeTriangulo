using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_Triangulo
{
    class Program
    {
        static void Main()
        {
            // Pedir al usuario que ingrese la base y la altura del triángulo
            Console.Write("Ingresa la longitud de la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del triángulo
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            // Mostrar el resultado
            Console.WriteLine("El área del triángulo es: " + areaTriangulo);

            // Esperar a que el usuario presione Enter para salir
            Console.ReadLine();
        }
    }
}
