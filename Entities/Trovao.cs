using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Trovao : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Trovao;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Arma,
                TipoDaJogada.Pedra,
                TipoDaJogada.Fogo,
                TipoDaJogada.Tesoura,
                TipoDaJogada.Cobra,
                TipoDaJogada.Humano,
                TipoDaJogada.Arvore
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
