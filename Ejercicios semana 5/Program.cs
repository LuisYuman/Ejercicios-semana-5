using System.Numerics;

double cradio(double radio)  //funcion numero uno: radio
{
    double pi = Math.PI;
    double resultado;

    resultado = pi * (radio*radio);

    return resultado;
}

double crec(double ancho, double altura) //funcion numero dos: perimetro rectangulo
{
    double resultador;

    resultador = (ancho + altura) * 2;
    return resultador;
}

double prom(int[] numeros) //funcion numero tres: promedio 
{
    int suma = 0;
    double promedio;
    for (int i = 0; i < numeros.Length; i++)
    {
        suma += numeros[i];
        
    }
    promedio = suma / numeros.Length;

    return promedio;
    
}

void par(int npi) //funcion numero cuatro: par o impar
{ 
    if(npi % 2 ==0)
    {
        Console.WriteLine("Su numero es par");
    }
    else
    {
        Console.WriteLine("Su numero no es par");
    }
}

void mayus(string fmin) //funcion numero cinco: mayusculas
{
    Console.WriteLine($"Su cadena de texto en mayusculas: {fmin.ToUpper()}");
}

double distancia(double x, double y, double x1, double y1) //funcion numero 6: distancia puntos
{
    double dx = x1 - x;
    double dy = y1 - y;

    double rdistancia = Math.Sqrt(Math.Pow(dx, 2)) + Math.Pow(dy, 2);

    return rdistancia;
}

int suman(int n1) // funcion numero 7: suma de n
{
    int suma = 0;

    for(int i= 1; i <= n1; i++)
    {
        suma += i;
    }
    return suma;
}

int vectorial(int n) //funcion numero 8: factorial
{
    int rv = 1;

    while (n >1)
    {
        rv *= n;
        n--;
    }

    return rv;
}


double radio, re;
double ancho, altura, rer, rep;
int npi;
String fmin;
double x, x1, y, y1, rd;
int n1, rs;
int n, nr;

Console.WriteLine("Ingrese el radio del circulo");
radio = int.Parse(Console.ReadLine());

re=cradio(radio);

Console.WriteLine($"El area del circulo es: {re} centimetros cuadrados");

//****************************************************************************

Console.WriteLine("Ingrese el ancho del rectangulo: ");
ancho = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el alto del rectangulo: ");
altura= int.Parse(Console.ReadLine());

rer = crec(ancho, altura);

Console.WriteLine($"El perimetro del rectangulo es {rer} centimetros");

//******************************************************************************

Console.WriteLine("Ingrese la cantidad de numeros a ingresar: ");
int numero = int.Parse(Console.ReadLine());

int []numeros = new int[numero];

Console.WriteLine("Ingrese los numeros");

for (int i = 0;i < numero; i++)
{
    Console.WriteLine($"Ingrese el valor {i} ");
    numeros[i] = int.Parse(Console.ReadLine());
}
rep = prom(numeros);
Console.WriteLine($"El promedio de sus numero es: {rep}");

//********************************************************************************

Console.WriteLine("Ingrese el numero para determinar si es par o no es par");
npi = int.Parse(Console.ReadLine());

par(npi);

//*********************************************************************************

Console.WriteLine("Ingrese la cadena de texto a convertir");
fmin = Console.ReadLine();

mayus(fmin);

//***********************************************************************************

Console.WriteLine("Ingrese el valor de x1");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de x2");
x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de y1");
y = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de y1");
y1 = int.Parse(Console.ReadLine());

rd = distancia(x, y, x1, y1);

Console.WriteLine($"La distancia entre estos dos puntos es: {rd}");

//************************************************************************************

Console.WriteLine("Ingrese el numero natural al cual quiere realizar la suma");
n1 = int.Parse(Console.ReadLine());

rs = suman(n1);

Console.WriteLine($"El resultado de la suma es: {rs}");

//*************************************************************************************

Console.WriteLine("Ingrese el numero que quiere calcular el factorial");
n = int.Parse(Console.ReadLine());

nr = vectorial(n);

Console.WriteLine($"El factorial de su numero es: {nr}");
