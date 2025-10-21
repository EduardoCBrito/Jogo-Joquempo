using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Demonio : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Demonio;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Trovao,
                TipoDaJogada.Arma,
                TipoDaJogada.Pedra,
                TipoDaJogada.Fogo,
                TipoDaJogada.Tesoura,
                TipoDaJogada.Cobra,
                TipoDaJogada.Humano
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
