using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_Datos
{
    internal class Program
    {
        static void Main(string[] args) // void = métodos
        {
            // Comentario
            // Tipos de datos
            /*
             Comentario de varias líneas
             */

            // Enteros
            int num1 = 0; // 32bits
            int num2, num3;
            long largo = 678976896879869; //64 bits
            byte b = 255; // 8 bits Solo admite positivos
            short corto = -789; // 16 bits
            ushort cortomenus = 252; // No admite negativos

            // Decimales
            float flotante = 4.99f; // 32 bits
            double doble = 14.89; // 64 bits
            decimal deci = 30.5m;

            // Texto
            string cadena = "Hola mundo";
            char letra = 'A';

            // Booleano
            bool Buleano = true;

            // Dinámicos
            var VARIABLE = true; //El var acepta cualquier tipo
            dynamic dinamico = 200; //La variable dinamico es un entero.
            dinamico = true; //Ahora es un boolean
            dinamico = "Hola mundo"; //Ahora es una cadena de carácteres.

            Console.WriteLine("Hola mundo");
            string nombre = "Alex";
            string apellido = "Solís";
            Console.WriteLine(nombre + " " + apellido);
            Console.WriteLine("Mi nombre es {0} {1}", nombre, apellido); // Concatenación haciendo una referencia
            Console.WriteLine($"Mi nombre es {nombre} {apellido}");
            num1 = 10;
            num2 = 5;
            int resultado = num1 + num2;
            Console.WriteLine("La suma de: " + num1 + "+" + num2 + "=" + resultado);
            Console.WriteLine($"La suma de {num1} + {num2} = {resultado}");
            Console.WriteLine("La suma de {0} + {1} = ", num1, num2, resultado);
            Console.WriteLine("La suma de {0} + {1} = ", num1, num2, num1+num2);
            Console.WriteLine("La resta de {0} + {1} = ", num1, num2, num2-num1);

            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine($"Mi nombre es {nombre}");
            Console.WriteLine("Digite su edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su salario");
            double salario = double.Parse(Console.ReadLine());
            double iva = salario * 0.13;
            Console.WriteLine($"Mi nombre es {nombre} y tengo {edad} años.Mi salario es de ${salario}");
            Console.WriteLine($"El IVA de este salario de {salario} es de {iva}");


            // Condiciones
            if (1>2)
            {
                Console.WriteLine("1 es mayor que 2.");
            }
            else
            {
                Console.WriteLine("1 no es mayor que 2.");
            }

            if (num1>num2)
            {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Son el mismo número");
            }
            else
            {
                Console.WriteLine($"{num2} es mayor que {num1}");
            }


            // Ciclo While
            int i = 0;
            int numero1 = 8;
            int numero2 = 3;
            while (i != 5)
            {
                Console.WriteLine(i);
                i += 1;
            }

            while (numero1 > numero2)
            {
                Console.WriteLine(numero1);
                numero1 -= 1;
            }

            // Ciclo For
            for (int x = 0; i < 10; i++) // i = i + 1: i++
            {                            // i = i - 1: i--
                Console.WriteLine(x);
            }

            for(int e = 12; e > 10; e--)
            {
                Console.WriteLine(e);
            }

            int indice = 12;
            while (indice > 0)
            {
                Console.WriteLine(indice);
                indice--;
            }

            Console.Read();
        }
    }
}
