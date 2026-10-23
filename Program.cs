using EstudosCinema.Enums;
using EstudosCinema.LoginPage;

LoginPage loginPage = new LoginPage();

LoginTypes login = LoginTypes.NaoLogado;

while (true)
{
    if (login == LoginTypes.NaoLogado)
    {
        login = loginPage.ExibirMenu();
    }

    if (login == LoginTypes.Cliente)
    {
        Console.Clear();
        Console.WriteLine("Tela do Cliente");
        Console.WriteLine("1 - Sair");

        Console.ReadLine();

        login = LoginTypes.NaoLogado;
    }
    else if (login == LoginTypes.Gerente)
    {
        Console.Clear();
        Console.WriteLine("Tela do Gerente");
        Console.WriteLine("1 - Sair");

        Console.ReadLine();

        login = LoginTypes.NaoLogado;
    }
}