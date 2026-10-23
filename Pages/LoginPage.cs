using EstudosCinema.Enums;
using System.Threading;

namespace EstudosCinema.LoginPage
{
    public class LoginPage
    {
        public LoginTypes ExibirMenu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Bem-vindo ao cinema!");
                Console.WriteLine("1 - Entrar");
                Console.WriteLine("2 - Login");

                if (!int.TryParse(Console.ReadLine(), out int index) ||
                (index != 1 && index != 2))
                {
                    Console.WriteLine("Digite apenas 1 ou 2.");
                    Thread.Sleep(2000);
                    continue;
                }

                switch (index)
                {
                    //case 1:
                       

                    //case 2:
                     
                }
            }
        }
    }
}