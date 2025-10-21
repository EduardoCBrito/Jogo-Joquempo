namespace Jogo_Joquempo.Services
{
    public class OcultarJogada
    {
        // Lê a jogada ocultando o que é digitado
        public static string LerJogadaOculta()
        {
            string entrada = "";
            ConsoleKeyInfo tecla;

            while (true)
            {
                tecla = Console.ReadKey(intercept: true); // intercept = true => não mostra no console

                if (tecla.Key == ConsoleKey.Enter)
                    break;

                if (tecla.Key == ConsoleKey.Backspace)
                {
                    if (entrada.Length > 0)
                        entrada = entrada.Substring(0, entrada.Length - 1);
                }
                else
                {
                    entrada += tecla.KeyChar;
                }
            }

            return entrada;
        }
    }
}
