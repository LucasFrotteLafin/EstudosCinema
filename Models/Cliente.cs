namespace EstudosCinema.Models.Clientes
{
    public class Cliente
    {
        public string Nome { get; set; } 
        public string Senha { get; set; }
        public string Email { get; set; }
        public float Saldo { get; set; } = 0;

        //public string pedidos { get; set; } = string.Empty;

        public Cliente(string nome, string senha, string email)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            Saldo = 0;
        }

        public static string Mensagem()
        {
            return "Usuario criado com sucesso!!";
        }
    }
}
