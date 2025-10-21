using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Arma : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Arma;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Pedra,
                TipoDaJogada.Fogo,
                TipoDaJogada.Tesoura,
                TipoDaJogada.Cobra,
                TipoDaJogada.Humano,
                TipoDaJogada.Arvore,
                TipoDaJogada.Lobo
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
