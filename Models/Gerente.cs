namespace EstudosCinema.Pages.Gerente
{
    public class Gerente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        private Gerente(
            string nome,
            string email,
            string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public static Gerente Criar(
            string nome,
            string email,
            string senha,
            string senhaMestra)
        {
            if (senhaMestra != "240505")
            {
                throw new Exception("Senha mestra incorreta.");
            }

            return new Gerente(
                nome,
                email,
                senha);
        }
    }
}
