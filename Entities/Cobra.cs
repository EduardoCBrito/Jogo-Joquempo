using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Cobra : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Cobra;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Humano,
                TipoDaJogada.Arvore,
                TipoDaJogada.Lobo,
                TipoDaJogada.Esponja,
                TipoDaJogada.Papel,
                TipoDaJogada.Ar,
                TipoDaJogada.Agua
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
