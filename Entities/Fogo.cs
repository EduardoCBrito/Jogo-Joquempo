using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Fogo : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Fogo;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Tesoura,
                TipoDaJogada.Cobra,
                TipoDaJogada.Humano,
                TipoDaJogada.Arvore,
                TipoDaJogada.Lobo,
                TipoDaJogada.Esponja,
                TipoDaJogada.Papel
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
