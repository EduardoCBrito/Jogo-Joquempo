using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Esponja : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Esponja;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Papel,
                TipoDaJogada.Ar,
                TipoDaJogada.Agua,
                TipoDaJogada.Dragao,
                TipoDaJogada.Demonio,
                TipoDaJogada.Trovao,
                TipoDaJogada.Arma
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
