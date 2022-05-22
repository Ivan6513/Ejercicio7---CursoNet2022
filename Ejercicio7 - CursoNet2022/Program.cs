/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
 */

//Perdir 10 numeros al usuario
using System.Globalization;

double[] numeros = new double[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingrese numero = ");

    //N
    numeros[i] = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
}

//Suma 
double suma = numeros.Sum();

//Mayor de todos los numeros
double mayorIngresados = numeros.Max();

//Menor de todos los numeros
double menorIngresados = numeros.Min();

//Promedio ingresados
double promedioIngresados = numeros.Average();

//Impresion de todos los valores
Console.WriteLine("==========================");
Console.WriteLine($"Suma {suma}\nPromedio {promedioIngresados}\n" +
    $"Maximo {mayorIngresados}\n" + $"Minimo {menorIngresados}\n");


