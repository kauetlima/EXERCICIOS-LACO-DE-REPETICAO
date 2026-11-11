/* 
4. Identificação de números primos
Escreva um programa que solicite ao usuário um número inteiro positivo e exiba todos os números primos existentes entre 1 e o número informado, incluindo o próprio número caso ele seja primo.
*/


int num = 0;


Console.WriteLine("Digite um número inteiro positivo: ");
num = int.Parse(Console.ReadLine());

for (int i = 2; i < num; i++)
{
    int divisores = 0;

    for (int j = 1;j<=i; j++)
    {
        if (i % j == 0)
        {
            divisores++;
        }
        
    }
    if (divisores == 2) 
    {
        Console.WriteLine(i);
    }
}


   