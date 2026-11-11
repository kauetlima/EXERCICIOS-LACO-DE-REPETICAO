/*
 3. Separação de números pares e ímpares
 Escreva um programa que solicite ao usuário um número inteiro positivo e exiba todos os números ímpares de 1 até o número informado. Em seguida, exiba todos os números pares dentro do mesmo intervalo. Impares crescente e pares descrescente 
*/
int numero = 0;
Console.WriteLine("Digite um número inteiro positivo: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("IMPARES:" + i);
    }
    
}

Console.WriteLine("======================================");

for (int i = numero; i >= 1; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("PARES:" + i);
    }

}


