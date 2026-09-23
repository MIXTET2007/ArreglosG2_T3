using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");
             
        MiArreglo oMiArreglo = new MiArreglo(10);

        oMiArreglo.Llenar(5, 20);
        Console.WriteLine("\nArreglo Desordenado");
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo ordenado descendente");
        oMiArreglo.Ordenar();
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo ordenado ascendente");
        oMiArreglo.Ordenar(false);
        Console.WriteLine(oMiArreglo);

        Console.WriteLine(oMiArreglo.ToString);
        Console.ReadKey();
    }
}