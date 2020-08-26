/*1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.*/

using System;

class MainClass {

public static int Calcula (int n1, int n2, char ope){
  int resp;
  
    switch(ope)
    {
      case '+':
              return n1+n2;
      case '-':
              return n1-n2;     
      case '*':
              return n1*n2;
      case '/':
              return n1/n2;            
      default:
              Console.WriteLine("operação invalida!");
              break;
    }
  return 0;
}


public static void Main (string[] args) 
{
  char sinal;
  int num1=0, num2=0;
  Console.WriteLine("Digite a operação desejada:  "); 
  sinal = char.Parse(Console.ReadLine());
  Console.WriteLine("Digite o numero 1:");
  num1 = int.Parse(Console.ReadLine());
  Console.WriteLine("Digite o numero 2:");
  num2 = int.Parse(Console.ReadLine());
  Console.WriteLine("O resultado da operação é: {0}", Calcula(num1, num2, sinal));
}
}