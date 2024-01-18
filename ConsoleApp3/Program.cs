using System;

class Program
{
    static void Main()
    {
        GerenciadorAnimais gerenciador = new GerenciadorAnimais();

        while (true)
        {
            MostrarMenu();

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    gerenciador.AdicionarAnimais();
                    break;
                case "2":
                    gerenciador.ListarAnimais();
                    break;
                case "3":
                    AtualizarAnimal(gerenciador);
                    break;
                case "4":
                    gerenciador.AdotarAnimal();
                    break;
                case "5":
                    gerenciador.RemoverAnimal();
                    break;
                case "6":
                    gerenciador.ListarAnimaisAdotados();
                    break;
                case "7":
                    Console.WriteLine("Saindo do programa. Até logo!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("----- MENU -----");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Cadastrar Animal");
        Console.WriteLine("2. Lista De Animais");
        Console.WriteLine("3. Atualizar Animal");
        Console.WriteLine("4. Adotar Animal");
        Console.WriteLine("5. Excluir animal da lista");
        Console.WriteLine("6. Lista de Animais Adotados");
        Console.WriteLine("7. Encerrar Atendimento");
    }

    static void AtualizarAnimal(GerenciadorAnimais gerenciador)
    {
        gerenciador.ListarAnimais();
        Console.Write("Digite o nome do animal a ser alterado: ");
        string nome = Console.ReadLine();
        gerenciador.AlterarAnimal(nome);
    }
}

