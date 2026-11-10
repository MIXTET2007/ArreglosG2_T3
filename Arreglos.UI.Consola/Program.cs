using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");
             
        MiArreglo oMiArreglo = new MiArreglo(100);
        MiArreglo oMiArregloPares = new MiArreglo(100);

        try
        {
            oMiArreglo.Llenar(1, 100);
            Console.WriteLine(oMiArreglo);

            Console.ReadKey();

            Console.WriteLine("\nPares desordenados\n");
            var verPares = oMiArreglo.ObtenerPares();
            Console.WriteLine(verPares);

            Console.ReadKey();
            Console.WriteLine("\nPares ordenados\n");
            verPares.Ordenar();
            Console.WriteLine(verPares);
            

            /*
            oMiArreglo.Agregar(10);
            oMiArreglo.Agregar(5);
            oMiArreglo.Agregar(-4);
            oMiArreglo.Eliminar(0);

            Console.WriteLine(oMiArreglo);
            Console.ReadKey();

            oMiArreglo.Insertar(200, -50);

            Console.WriteLine(oMiArreglo);
            Console.ReadKey();

            oMiArreglo.Eliminar(0);*/
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



        Console.WriteLine(oMiArreglo);


        /*oMiArreglo.Llenar(5, 20);
        Console.WriteLine("\nArreglo Desordenado");
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo ordenado descendente");
        oMiArreglo.Ordenar();
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nArreglo ordenado ascendente");
        oMiArreglo.Ordenar(false);
        Console.WriteLine(oMiArreglo);

        Console.WriteLine(oMiArreglo.ToString);*/
        Console.ReadKey();
    }
}