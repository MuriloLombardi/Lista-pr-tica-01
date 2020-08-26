/*3- Crie um programa que funcione para uma votação eleitoral. Existem três Opcoes:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;*/
  
using System;

class MainClass {

  

  public static void Votacao() {
    string candidato;
      
    int jose = 0;
    int joana = 0;
    int roberto = 0;
    int branco = 0;
    int nulo = 0;
    
     do
    {
      Opcoes();
      Console.WriteLine("Digite sua opção de voto: ");
      candidato = Console.ReadLine();
      switch (candidato) {
        case "33":
          jose++;
          break;
        case "25":
          joana++;
          break;
        case "10":
          roberto++;
          break;
        case "0":
          branco++;
          break;
        case "4":
          nulo++;
          break; 
        default:
          Console.WriteLine("Opção invalida, tente novamente!");
          break;
      }
      Console.WriteLine("Aperte 'ESC' para finalizar a votação ou outra tecla para continuar a votação");
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
    FinalizaVot(jose, joana, roberto, branco, nulo);
  }
     
  public static void FinalizaVot(int jose, int joana, int roberto, int branco, int nulo){
    if (jose > joana && jose > roberto)
     {
       Console.WriteLine("O vencedor foi: José Couve com {0} votos", jose);
     }
    else if (joana > jose && joana > roberto){
       Console.WriteLine("O vencedor foi: Joana Bravo com {0} votos", joana);
    }    
    else if(roberto > jose && roberto > joana)
     {
       Console.WriteLine("O vencedor foi: Roberto Nove com {0} votos", roberto);
     }
    else {
      Console.WriteLine("Empate na votação!");
    }
    Console.WriteLine("Nulos: {0}",nulo);
    Console.WriteLine("Brancos: {0}",branco);
  }
  


  public static void Opcoes(){
   Console.WriteLine("------------------");
   Console.WriteLine("|33 - José Couve  |");
   Console.WriteLine("------------------");
   Console.WriteLine("|25 - Joana Bravo |");
   Console.WriteLine("------------------");
   Console.WriteLine("|10 - Roberto Nove|");
   Console.WriteLine("------------------");
   Console.WriteLine("|0  - Voto branco |");
   Console.WriteLine("------------------");
   Console.WriteLine("|4  - Voto nulo   |");
   Console.WriteLine("------------------");
  }
  
  public static void Main () {
    Votacao();
  }
}
