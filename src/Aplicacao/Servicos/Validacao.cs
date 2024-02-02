namespace Aplicacao.Servicos
{
    public static class Validacao
    {
        public static (bool, string) NaoNulo(object objeto)
        {
            if (objeto == null)
                return (false, "O objeto não pode ser nulo.");
           
            return (true, string.Empty);
        }
    }
}
