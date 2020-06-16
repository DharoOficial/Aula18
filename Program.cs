using System;

namespace aula18
{
    class Program
    {
        static void Main(string[] args)
        {
        Jogador cr7 = new Jogador();
        cr7.Nome = "Cristiano Ronaldo";
        System.Console.WriteLine("digite sua funçao em campo, com a primeira letra maiuscula");
        cr7.Posicao = Console.ReadLine();
        
        cr7.Nascimento = DateTime.Parse("05/02/1985");            

        cr7.MostrarDados();
        Console.WriteLine( cr7.CalcularIdade() );
        Console.WriteLine( cr7.CalcularAposentadoria() );
        cr7.CalcularSalario();
        }
    }
}
