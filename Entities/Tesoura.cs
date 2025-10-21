using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Tesoura : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Tesoura;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Cobra,
                TipoDaJogada.Humano,
                TipoDaJogada.Arvore,
                TipoDaJogada.Lobo,
                TipoDaJogada.Esponja,
                TipoDaJogada.Papel,
                TipoDaJogada.Ar
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
