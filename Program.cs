using System;

namespace Objeto_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personagem objPersonagem = new Personagem();

            objPersonagem.nome = "Tsukamoto";
            objPersonagem.idade = 32;
            objPersonagem.armadura = "Voadora";

            Personagem objPersonagem2 = new Personagem();

            objPersonagem2.nome = "Joyce";
            objPersonagem2.idade = 18;
            objPersonagem2.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objPersonagem.nome}");
            Console.WriteLine($"Personagem 2 = {objPersonagem2.nome}"); 
            Console.WriteLine($"Ataque = {objPersonagem.Atacar()}");
            Console.WriteLine($"Defesa = {objPersonagem2.Defender()}"); 
        }
    }
}
