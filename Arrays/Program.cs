// See https://aka.ms/new-console-template for more information
using Arrays;

Console.WriteLine("******************************************");
Console.WriteLine("********** MICHELLE VACA *****************");
Console.WriteLine("******************************************");


int[] validarPrimos = { 1, 2, 3, 4, 5, 6, 7, 8, 11};
int[] validarRepeticiones = { 1, 2, 3, 1, 1, 4, 2, 1, 2, 1 };


int[] primos = Utilitarios.arregloPrimos(validarPrimos);
int[] noRepetidos = Utilitarios.repeticiones(validarRepeticiones, true);
int[] repetidos = Utilitarios.repeticiones(validarRepeticiones, false);

Console.WriteLine("\n=========== INICIO NUMEROS PRIMOS ==============");
Console.WriteLine("Arreglo de elementos a validar: ");
for (int i = 0; i < validarPrimos.Length; i++)
{
    Console.Write($"{validarPrimos[i]}{(i + 1 < validarPrimos.Length ? ",":"")}");
}

Console.WriteLine("\n\nResultado: ");
foreach (int i in primos)
{
    Console.WriteLine($"{i} es primo");
}
Console.WriteLine("=========== FIN NUMEROS PRIMOS ==============");


Console.WriteLine("\n=========== INICIO NO REPETIDOS ==============");
Console.WriteLine("Arreglo de elementos a validar: ");
for (int i = 0; i < validarRepeticiones.Length; i++)
{
    Console.Write($"{validarRepeticiones[i]}{(i + 1 < validarRepeticiones.Length ? "," : "")}");
}

Console.WriteLine("\n\nResultado: ");
foreach (int i in noRepetidos)
{
    Console.WriteLine($"{i} no se repite");
}
Console.WriteLine("=========== FIN NO REPETIDOS ==============");


Console.WriteLine("\n=========== INICIO REPETIDOS ==============");
Console.WriteLine("Arreglo de elementos a validar: ");
for (int i = 0; i < validarRepeticiones.Length; i++)
{
    Console.Write($"{validarRepeticiones[i]}{(i + 1 < validarRepeticiones.Length ? "," : "")}");
}

Console.WriteLine("\n\nResultado: ");
foreach (int i in repetidos)
{
    Console.WriteLine($"{i} SI se repite");
}
Console.WriteLine("=========== FIN REPETIDOS ==============");