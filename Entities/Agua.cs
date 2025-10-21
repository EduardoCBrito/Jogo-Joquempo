using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Agua : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Agua;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Dragao,
                TipoDaJogada.Demonio,
                TipoDaJogada.Trovao,
                TipoDaJogada.Arma,
                TipoDaJogada.Pedra,
                TipoDaJogada.Fogo,
                TipoDaJogada.Tesoura
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
