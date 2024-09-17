// See https://aka.ms/new-console-template for more information


using System;
using System.Net.Http.Headers;

MenuOpciones();
void MenuOpciones()
{
    int opcion = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("1. Determinar si un número es positivo, negativo o cero");
        Console.WriteLine("2. Mostrar día de semana");
        Console.WriteLine("3. Suma números naturales hasta el 100");
        Console.WriteLine("4. Imprimir números hasta el valor ingresado");
        Console.WriteLine("5. Calcular el área del circulo");
        Console.WriteLine("6. Mostrar valores de un arreglo");
        Console.WriteLine("7. Mostrar valores de una lista");
        Console.WriteLine("8. Salir");
        Console.WriteLine("------------");
        Console.WriteLine("Ingresa la opción");
        opcion = Convert.ToInt32(Console.ReadLine());
        Console.Clear ();
        switch (opcion)
        {
            case 1:
                {
                    Console.WriteLine($"El numero ingrresado es {TipoNumero()}");
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.WriteLine($"El día ingresado es {MensajeDiaSemana()}");
                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    Console.WriteLine($"La suma de los primeros 100 números naturales es: {SumaNumeroNaturales()}");
                    Console.ReadKey();
                    break;
                }
            case 4:
                {
                    int numMax = 0;
                    Console.WriteLine("Ingresa el número máximo para imprimir");
                    numMax = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    ImprimirTotalNumeros(numMax);
                    Console.ReadKey();
                    break;
                }
            case 5:
                {
                    double radio = 0;
                    Console.WriteLine("Ingresa el radio del circulo");
                    radio = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"El área del circulo es: {AreaCiculo(radio)}");
                    Console.ReadKey();
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Mostrando arreglo");
                    MostrarArreglo();
                    Console.ReadKey();
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Mostrando lista");
                    MostrarLista();
                    Console.ReadKey();
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Gracias!");
                    break;
                }
            default:
                {
                    break;
                    Console.WriteLine("Opcion inválida");
                }
        }
    }
    while (opcion != 8);
}
string TipoNumero()
{
    string resultado;
    double numero = 0;

    Console.WriteLine("Ingrese el número a validar: ");
    numero = Convert.ToDouble(Console.ReadLine());

    if (numero > 0)
    {
        resultado = "positivo";
    }
    else if (numero == 0)
    {
        resultado = "cero";
    }
    else
    {
        resultado = "negativo";
    }
    return resultado;
}

string MensajeDiaSemana()
{
    int diaSem = 0;
    Console.WriteLine("Ingresa el día de la semana como número");
    diaSem = Convert.ToInt32(Console.ReadLine());
    string dia;

    switch (diaSem)
    {
        case 1:
            {
                dia = "Lunes";
                break;
            }
        case 2:
            {
                dia = "Martes";
                break;
            }
        case 3:
            {
                dia = "Miercoles";
                break;
            }
        case 4:
            {
                dia = "Jueves";
                break;
            }
        case 5:
            {
                dia = "Viernes";
                break;
            }
        case 6:
            {
                dia = "Sábado";
                break;
            }
        case 7:
            {
                dia = "Domingo";
                break;
            }
        default:
            {
                dia = "No es válido";
                break;
            }
    }
    return dia;
}     

int SumaNumeroNaturales()
{
    int maximo = 100;
    int suma = 0;

    for (int i = 1; i <= maximo; i++)
    {
        suma = suma + i;
    }

    return suma;
}

void ImprimirTotalNumeros(int maximo)
{
    for (int i = 1;i <= maximo; i++)
    {
        Console.WriteLine(i);
    }
}

double AreaCiculo(double radio)
{
    double area = 0;
    area = Math.PI * (Math.Pow(radio, 2));
    return area;
}

void MostrarArreglo()
{
    string[] nombres = new string[] { "Luis", "Pedro", "Jorge", "Jose", "Ana" };
    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine(nombres[i]);
    }
}

void MostrarLista()
{
    List<string> nombres = new List<string>();

    nombres.Add("Luis");
    nombres.Add("Pedro");
    nombres.Add("Jorge");
    nombres.Add("Jose");
    nombres.Add("Ana");

    foreach (string item in nombres)
    {
        Console.WriteLine(item);
    }
}