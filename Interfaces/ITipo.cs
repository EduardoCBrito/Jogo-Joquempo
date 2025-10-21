using Jogo_Joquempo.Enums;

namespace Jogo_Joquempo.Interfaces
{
    public interface ITipo
    {
        TipoDaJogada Tipo {  get; }

        bool Vence(ITipo outro);
    }
}
