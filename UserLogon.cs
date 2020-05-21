namespace ExemploComposition
{
    /// <summary>
    /// UserLogon é um exemplo de classe responsável por gerenciar o login do usuário no sistema
    /// </summary>
    class UserLogon
    {
        private readonly Logger _logger;

        public UserLogon(Logger logger)
        {
            _logger = logger;
        }

        public void Login()
        {
            // Como parte do código de efetuar login, seria gravado um log
            _logger.Log("Efetuando login do usuário...");
        }
    }
}