using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Papel : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Papel;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Ar,
                TipoDaJogada.Agua,
                TipoDaJogada.Dragao,
                TipoDaJogada.Demonio,
                TipoDaJogada.Trovao,
                TipoDaJogada.Arma,
                TipoDaJogada.Pedra
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
