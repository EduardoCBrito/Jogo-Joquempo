using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Humano : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Humano;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Arvore,
                TipoDaJogada.Lobo,
                TipoDaJogada.Esponja,
                TipoDaJogada.Papel,
                TipoDaJogada.Ar,
                TipoDaJogada.Agua,
                TipoDaJogada.Dragao
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
