using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_csharp_controle_de_velocidade_robo.Models
{
class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }
    


    public Robo(string[] valoresMinMax)
    {
        VelocidadeMinima = int.Parse(valoresMinMax[0]);
        VelocidadeMaxima = int.Parse(valoresMinMax[1]);
        VelocidadeAtual = int.Parse(valoresMinMax[0]);
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;

        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
            
        }
    }
    
}

class Program
{
    static void Main()
    {
      
      Robo robo1 = new Robo(Console.ReadLine().Split());
      
      string comandos = Console.ReadLine();
      foreach(char item in comandos)
      {
        if (item == 'A')
        {
          robo1.Acelerar();
        }
        else if (item == 'D')
        {
          robo1.Desacelerar();
        }
      }


      Console.WriteLine(robo1.VelocidadeAtual);
        
    }
}
}