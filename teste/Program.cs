
void VerificaPrimo(int numero)
{
    int contador = 0;
    if (numero <= 1)
    {
        Console.WriteLine("Não tem numeros primos nessa sequencia");
    }

    for (int x =numero; x>1; x--) //enquanto X for menor que o numero digitado continua (começa com valor de 2)
    {
        contador = 0;
        for (int y = 2; y <x; y++) // enquanto Y for maior ou igual a 2 ele continua (começa com valor de numero)
        {
            if (x % y == 0) // se o numero tiver resto 0, ele adiciona 1 ao contador
            {
                contador++;
            }
        }
        if (contador == 0)
        {
         Console.WriteLine(x);
        }

    }
}


int numero;
Console.WriteLine("Digite o numero que deseja verificar se é primo:");
numero = int.Parse(Console.ReadLine());
VerificaPrimo(numero);