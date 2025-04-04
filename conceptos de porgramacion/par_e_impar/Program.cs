Console.WriteLine("ingrese un numero,por favor");

int numero;
if (int.TryParse(Console.ReadLine(), out numero))
{
    if (numero % 2 == 0)
    {
        Console.WriteLine($"El número es par ");

    }
    else
    {
        Console.WriteLine($"El número es impar");
    }
}
else
{
    Console.WriteLine("Entrada no valida");
}

