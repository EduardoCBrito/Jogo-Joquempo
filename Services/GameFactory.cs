using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;
using static Jogo_Joquempo.Services.OcultarJogada;

namespace Jogo_Joquempo.Services
{
    public class GameFactory
    {
        private readonly IEnumerable<ITipo> _tipos;

        public GameFactory(IEnumerable<ITipo> tipos)
        {
            _tipos = tipos;
        }

        public ITipo Criar(string jogada)
        {
            var convertType = (TipoDaJogada)int.Parse(jogada);
            var tipo = _tipos.FirstOrDefault(t => t.Tipo == convertType);
            if (tipo == null)            
                throw new ArgumentException($"Tipo {jogada} não enocontrado.");
            
            return tipo;
        }

        public void GameStart()
        {
            Console.WriteLine("JOKENPÔ - MODO 2 JOGADORES");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            // Jogador 1
            Console.WriteLine("Jogador 1, Escolha: Pedra (0), Fogo (1), Tesoura (2), Cobra (3), Humano (4)," +
                " Arvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9), Agua (10), Dragao (11), Demonio (12)," +
                " Trovao (13), Arma (14):");
            var jogada1 = LerJogadaOculta();
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            // Jogador 2
            Console.WriteLine("Jogador 1, Escolha: Pedra (0), Fogo (1), Tesoura (2), Cobra (3)," +
                " Humano (4), Arvore (5), Lobo (6), Esponja (7), Papel (8), Ar (9), Agua (10)," +
                " Dragao (11), Demonio (12), Trovao (13), Arma (14):");
            var jogada2 = LerJogadaOculta();
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();      

            // Resultado
            var tipo1 = Criar(jogada1);
            var tipo2 = Criar(jogada2);
            var ValorJogador1 = (TipoDaJogada)int.Parse(jogada1);
            var ValorJogador2 = (TipoDaJogada)int.Parse(jogada2);

            Console.WriteLine($"Jogador 1 escolheu: {ValorJogador1}");
            Console.WriteLine();
            Console.WriteLine($"Jogador 2 escolheu: {ValorJogador2}");
            Console.WriteLine();

            if (tipo1.Vence(tipo2))
                Console.WriteLine($"Jogador 1 venceu! {tipo1.Tipo} derrota {tipo2.Tipo}");
            else if (tipo2.Vence(tipo1))
                Console.WriteLine($"Jogador 2 venceu! {tipo2.Tipo} derrota {tipo1.Tipo}");
            else
                Console.WriteLine("Empate!");
        }
    }
}
