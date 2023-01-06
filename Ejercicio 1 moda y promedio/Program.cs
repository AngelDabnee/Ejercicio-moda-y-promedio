// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
Console.WriteLine("Mediante un ciclo pedir al usuario que capture 10 números, calcular el promedio y moda.Imprimir resultados");
//De
double[] numeros = new double[10];//Arreglo para capturar 10 números
double moda = 0;//numero que más veces se repite
double cont1 = 0;//Variables que nos ayudarán a determinar cuantas veces n numero se repite
double cont2 = 0;//igual que la anterior. 
double prom = 0;
double ind = 0;
//Proceso
Console.WriteLine("Vamos a capturar 10 números");
for (int i = 0; i < numeros.Length; i++)//Ciclo para capturar los 10 números del arreglo
{
    Console.WriteLine("Captuta tu número No. " + (i + 1));
    numeros[i] = double.Parse(Console.ReadLine());//Leemos los números
    prom = numeros[i] / numeros.Length;
}
for (int k = 0; k < numeros.Length; k++)//inicializamos otro ciclo para almacenar en una variable lo que más se repite
{   //Hago otro ciclo, para los números compararlos uno por uno. (ejemplo que vaya recorriendo la una linea de numeros)
    for (int j = 0; j < numeros.Length; j++)//arreglo para compararlos y almacenarlos. 
    {
        if (numeros[k] == numeros[j] && k != j) 
            cont1++;//le damos el valor de comparación para saber si son iguales, y que no sean diferentes, si son diferentes aumenta 1 el contador
        //donde almacenamos la variable que necesitamos
    }//Cuando la condición se cumpla, comparamos si los contadores son mayor que cont2. si es así hacemos lo siguiente
    ind = cont1;

    if (cont1>cont2)
    {
        cont2 = cont1;//Aquí se almacenan y se intercambian
        moda = numeros[k];//La moda sería el dato que se está repitiendo. 
    }
    cont1 = 0;//Inicializarlo o igualarlo en 0 para que entre al bucle, y comience con el otro numeroo
                //y los vaya almacenando uno a uno y se repitan los bucles. 
}
Console.WriteLine($"El númeor que más veces se repite de los capturados es {moda}");
Console.WriteLine($"El promedio de los números que capturaste es {prom}{ind}");