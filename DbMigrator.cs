namespace ExemploComposition
{
    /// <summary>
    /// DbMigrator é um exemplo de classe responsável por efetuar migrações entre
    /// banco de dados.
    /// </summary>
    class DbMigrator
    {
        private readonly Logger _logger;

        // Utilizando o princípio de Composition ao invés de Inheritance (herança) DbMigrator acessa o método Log
        // de uma instância recebida no constructor ao invés de herdá-lo diretamente da classe Logger. 
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // Como parte do código de implementação da migração, seriam gravadas mensagens no log
            _logger.Log("Migrando database...");
        }
    }
}