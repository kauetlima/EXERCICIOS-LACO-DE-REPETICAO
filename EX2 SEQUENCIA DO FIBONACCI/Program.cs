/*
2. Sequência de Fibonacci
Escreva um programa que solicite ao usuário um número inteiro que represente a quantidade de posições da sequência de Fibonacci que deverão ser exibidas. Em seguida, apresente a sequência até a posição informada.
 */


int num;
int a = 0;
int b = 1;
int c = 0;


Console.WriteLine("Digite a posição da sequencia de fibonacci que deseja: ");
num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    c = a;
    a = b;
    b = c + a;

    Console.WriteLine(c);
}

