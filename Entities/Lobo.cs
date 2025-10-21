using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Lobo : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Lobo;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Esponja,
                TipoDaJogada.Papel,
                TipoDaJogada.Ar,
                TipoDaJogada.Agua,
                TipoDaJogada.Dragao,
                TipoDaJogada.Demonio,
                TipoDaJogada.Trovao
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
