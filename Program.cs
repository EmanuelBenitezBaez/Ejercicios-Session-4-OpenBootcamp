//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.

Console.WriteLine("-------EJERCICIO 1: WHILE.-------");
int numero = 0;
int incremento=1;
Console.WriteLine("Por favor ingrese un numero del 1 al 10.:");
numero = Convert.ToInt32(Console.ReadLine());
while (incremento <= 10)
{
    Console.WriteLine(numero + "x" + incremento +"="+(numero*incremento));
    incremento++;
}
Console.WriteLine("-------EJERCICIO 2: DO WHILE.-------");
/*
 Ejercicio 2 - Do while
Escribe un programa que realice estos pasos:
Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.*/


int negativos = 0;
int positivos = 0;
int nIngresado;

do
{
    Console.WriteLine("Por favor ingrese el numero :");
     nIngresado = Convert.ToInt32(Console.ReadLine());
    if (nIngresado < 0)
    {
        Console.WriteLine("Numero ingresado es negativo.");
        negativos++;
     
    }
    if (nIngresado > 0)
    {
        Console.WriteLine("Numero ingresado es positivo.");
        positivos++;
        
    }
    Console.WriteLine("Total de numeros positivos ingresados:" + positivos);
    Console.WriteLine("Total de numeros positivos ingresados:" + negativos);

} while(nIngresado!=0);


////////////////////////////////////////////////////////
Console.WriteLine("-------EJERCICIO 3: FOR.-------");
/*Ejercicio 3 - For

Escribe un programa que realice estos pasos:
Reciba 3 datos:
ancho
alto
relleno o no.
Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está
relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:
Input: 2,2,2, relleno = true
Output:
** **
** **
Input: 3, 4, 1, relleno = false
Output:
***
* *
* *
***
*/

int Ancho, Alto; string Asteriscos = null;
Console.WriteLine("Por favor ingrese el ancho:");
Ancho = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Por favor ingrese el alto:");
Alto = Convert.ToInt32(Console.ReadLine());



Asteriscos = new string('*', Ancho);
for (int i = 0; i < Alto; i++)
{
    if (i == 0 || i == (Alto - 1))
        Console.WriteLine(Asteriscos);
    else
        Console.WriteLine("*{0," + (Ancho - 2) + "}*", ' ');
}
Console.ReadKey();



