using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[51];

        
        for (int i = 0; i <= 50; i++)
        {
            numeros[i] = i;
        }

        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Metodos de busqueda");
            Console.WriteLine("Arreglo del 0 al 50:\n");

            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nIngrese el numero que desea buscar:");
            int valor = int.Parse(Console.ReadLine());

            int resultadoLineal = BusquedaLineal(numeros, valor);

            if (resultadoLineal != -1)
                Console.WriteLine("Busqueda Lineal: Encontrado en posicion " + resultadoLineal);
            else
                Console.WriteLine("Busqueda Lineal: No encontrado");

            int resultadoBinaria = BusquedaBinaria(numeros, valor);

            if (resultadoBinaria != -1)
                Console.WriteLine("Busqueda Binaria: Encontrado en posicion " + resultadoBinaria);
            else
                Console.WriteLine("Busqueda Binaria: No encontrado");

            Console.WriteLine("\nDesea buscar otro numero? (si/no)");
            opcion = Console.ReadLine();

        } while (opcion.ToLower() == "si");

        Console.WriteLine("Programa finalizado.");
        Console.ReadKey();
    }

    static int BusquedaLineal(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
            {
                return i;
            }
        }
        return -1;
    }

    static int BusquedaBinaria(int[] arreglo, int valor)
    {
        int izquierda = 0;
        int derecha = arreglo.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;

            if (arreglo[medio] == valor)
                return medio;
            else if (arreglo[medio] < valor)
                izquierda = medio + 1;
            else
                derecha = medio - 1;
        }

        return -1;
    }
}