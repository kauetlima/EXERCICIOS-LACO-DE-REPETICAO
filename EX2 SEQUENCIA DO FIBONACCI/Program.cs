/*
2. Sequência de Fibonacci
Escreva um programa que solicite ao usuário um número inteiro que represente a quantidade de posições da sequência de Fibonacci que deverão ser exibidas. Em seguida, apresente a sequência até a posição informada.
 */

void CalculaFibonacci(int numero)
{
    int a = 0;
    int b = 1;
    int c = 0;

    for (int i=0; i <= numero; i++)
    {
        a = b;
        b = c;
        c = a + b;

        Console.WriteLine("Numeros Fibonacci:" + b);
    }
}

int num;

Console.WriteLine("Digite a posição da sequencia de fibonacci que deseja: ");
num = int.Parse(Console.ReadLine());
CalculaFibonacci(num);

