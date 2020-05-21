using System;

namespace ExemploComposition
{
    /// <summary>
    /// Como exemplo de Composition, a classe Logger (que é responsável por gravar a
    /// mensagem de log) está desacoplada das classes que a utilizam.
    /// </summary>
    class Logger
    {
        public void Log(string message)
        {
            // Para fins demonstrativos, não vamos nos preocupar com implementação de
            // salvar em um arquivo, por isso somente exibe a mensagem no console.
            Console.WriteLine(message);
        }
    }
}