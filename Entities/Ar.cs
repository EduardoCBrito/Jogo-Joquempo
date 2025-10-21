using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Ar : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Ar;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Agua,
                TipoDaJogada.Dragao,
                TipoDaJogada.Demonio,
                TipoDaJogada.Trovao,
                TipoDaJogada.Arma,
                TipoDaJogada.Pedra,
                TipoDaJogada.Fogo
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
