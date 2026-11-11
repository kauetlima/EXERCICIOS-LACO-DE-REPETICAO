/*
1. TABUADA
Escreva um programa que solicite ao usuário um número inteiro e exiba sua tabuada de multiplicação, do 1 ao 10.
*/

int num = 0;
int contador = 1;

Console.WriteLine("Digite um número inteiro para ver sua tabuada: ");
num = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("==========TABUADA DO NUMERO " + num + " ==========");
do
{
    int tabuada = num * contador;
    Console.WriteLine(num + "X" + contador + "=" + tabuada);
    contador++;
} while (contador < 10);

