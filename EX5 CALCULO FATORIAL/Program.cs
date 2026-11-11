/*
5. Cálculo de fatorial
Escreva um programa que solicite ao usuário um número inteiro não negativo e calcule seu fatorial. Ao final, apresente o resultado e a operação realizada.
*/
void CalculaFatorial(int fatorial)
{
    int resultado = 1;
    for (int i = 1; i <= fatorial; i++)
    {
        resultado = resultado * i;

        if (i == fatorial)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i + " x ");
        }
    }
    Console.WriteLine(": " + resultado);
}


int fatorial = 0;
Console.WriteLine("Digite o numero que deseja calcular o fatorial: ");
fatorial = int.Parse(Console.ReadLine());
CalculaFatorial(fatorial);
