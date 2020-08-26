/*2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final*/
  
using System;

class MainClass {
  public static double CalculaTotal (int codigo, int q){
    double preco;
    if (q<1){
      Console.WriteLine("Quantidade invalida!!!");
      return -1;
    }
    switch (codigo)
    {
     case 100:
      preco = 1.7;
      return (preco*Convert.ToSingle(q));
     case 101:
      preco = 2.3;
       return (preco*Convert.ToSingle(q));
     case 102:
      preco = 2.6;
       return (preco*Convert.ToSingle(q));
     case 103:
      preco = 2.4;
      return (preco*Convert.ToSingle(q));
     case 104:
      preco = 2.5;
      return (preco*Convert.ToSingle(q));
     case 105:
      preco = 1.0;
      return (preco*Convert.ToSingle(q));
     default: 
      Console.WriteLine("Codigo não cadastrado!!!");
      return -1; 
    }
  } 
  public static void Main () {
    
    int codigo, quantidade;

    Console.WriteLine("Digite o código do produto: ");
    codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade consumida: ");
    quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine("Valor Final: {0} ", CalculaTotal(codigo,quantidade));
  } 
}