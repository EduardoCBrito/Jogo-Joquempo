using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Dragao : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Dragao;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Demonio,
                TipoDaJogada.Trovao,
                TipoDaJogada.Arma,
                TipoDaJogada.Pedra,
                TipoDaJogada.Fogo,
                TipoDaJogada.Tesoura,
                TipoDaJogada.Cobra
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
