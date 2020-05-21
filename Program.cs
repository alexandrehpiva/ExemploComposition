using System;

namespace ExemploComposition
{
    /// <summary>
    /// Como exemplo de Composition, as classes DbMigrator e UserLogon não
    /// utilizam herança para obter as funcionalidades de gravação de log.
    ///
    /// Verifique o código das classes para melhor entendimento.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso do método log

            // Exemplo 1
            var dbMigrator = new DbMigrator(new Logger());
            dbMigrator.Migrate();

            // Exemplo 2
            var logger = new Logger();
            var userLogon = new UserLogon(logger);
            userLogon.Login();
        }
    }
}
