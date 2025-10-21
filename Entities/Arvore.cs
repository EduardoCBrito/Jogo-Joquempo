using Jogo_Joquempo.Enums;
using Jogo_Joquempo.Interfaces;

namespace Jogo_Joquempo.Entities
{
    public class Arvore : ITipo
    {
        public TipoDaJogada Tipo => TipoDaJogada.Arvore;

        public bool Vence(ITipo outro)
        {
            var vence = new[]
            {
                TipoDaJogada.Lobo,
                TipoDaJogada.Esponja,
                TipoDaJogada.Papel,
                TipoDaJogada.Ar,
                TipoDaJogada.Agua,
                TipoDaJogada.Dragao,
                TipoDaJogada.Demonio
            };

            return vence.Contains(outro.Tipo);
        }
    }
}
