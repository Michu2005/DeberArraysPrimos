using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Utilitarios
    {
        private static bool esPrimo(int n)
        {
            // No se puede validar con numeros menor de 1
            if (n <= 1) 
                return false;

            // Verifica si no es n=2 o n=3 (SON PRIMOS)
            if (n == 2 || n == 3)
                return true;

            // Verifica si n es divisible para 2 o 3 (Ya no seria primo)
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            // Verificar desde el primo con valor 5 hasta la raiz de n
            // Itera i como la suma de (i+6)
            for (int i = 5; i <= Math.Sqrt(n); i += 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        public static int[] arregloPrimos(int[] analizar)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < analizar.Length; i++)
            {
                if (esPrimo(analizar[i]))
                {
                    list.Add(analizar[i]);  
                }
            }

            return list.ToArray();
        }

        public static int[] repeticiones(int[] vector, bool noRepite)
        { 
            List<int> list = new List<int>();
            //Ordeno el arreglo a analizar
            int[] analizar = ordenar(vector); 
            int conteo;
            //Proceso los elementos del arreglo en base a la cantidad de ocurrencias de la variable conteo
            for (int i = 0; i < analizar.Length; i = i+conteo)
            {
                // Seteo los valore del pivote en la posicion i y seteo el conteo en 1
                var pivote = analizar[i];
                conteo = 1;
                //Realizo el barrido de los elementos restantes del arreglo y actualizo el conteo en caso de existir ocurrencias
                //esto es valido porque el vector esta ordenado
                for (int j = i + 1; j < analizar.Length; j++)
                {
                    conteo += (analizar[j] == pivote ? 1: 0);
                }

                // Bucle para cuando no se repiten
                if (noRepite && conteo == 1)
                {
                    list.Add(pivote);
                }

                // Bucle para cuando si se repiten
                if (!noRepite && conteo > 1)
                {
                    list.Add(pivote);
                }

            }
            
            return list.ToArray();
        }

        public static int[] ordenar(int[] vector)
        {
            int aux;
            int pivote;
            //Clonar el vector original para no modificarlo directamente
            int[] analizar = (int[])vector.Clone();
            for (int i = 0; i < analizar.Length; i++)
            {
                // Se setea el valor del pivote con el valor del vector en la posicion i
                pivote = analizar[i];
                for (int j = i + 1; j < analizar.Length; j++)
                {
                    // Se mueven los valores del pivote al vector orignal
                    if(pivote > analizar[j])
                    {
                        //Almaceno el pivote
                        aux = pivote;
                        //Actualizo el valor pivotal con el valor de comparacion
                        analizar[i] = analizar[j];
                        //Actualizo el valor de comparacion con el pivote original
                        analizar[j] = aux;
                        //Actualizo el valor del pivote con el nuevo valor de la posicion i
                        pivote = analizar[i];
                    }
                }
            }

            return analizar;
        }


    }
}
