using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Pedra : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Pedra;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Fogo,
                TipoDaJogada.Tesoura,
                TipoDaJogada.Cobra,
                TipoDaJogada.Humano,
                TipoDaJogada.Arvore,
                TipoDaJogada.Lobo,
                TipoDaJogada.Esponja
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
