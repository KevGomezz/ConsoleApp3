using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodaTime;
public class GerenciadorAnimais
{
    private List<Animal> animais = new List<Animal>();
    private List<Animal> animaisAdotados = new List<Animal>();

    public void AdicionarAnimais()
    {
        Console.WriteLine("Informe o índice do animal:");
        int indice = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o nome do animal que quer cadastrar:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe a Raça do seu animal:");
        string raca = Console.ReadLine();

        Animal novoAnimal = new Animal { Indice = indice, Nome = nome, Raca = raca, DataCadastro = DateTime.Now };
        animais.Add(novoAnimal);

        Console.WriteLine("O seu pet foi adicionado com sucesso!\n");
    }

    public void ListarAnimais()
    {
        if (animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal cadastrado.\n");
        }
        else
        {
            Console.WriteLine("Lista de Animais:");
            foreach (var animal in animais)
            {
                Console.WriteLine($"Indice: {animal.Indice}\nNome: {animal.Nome}\nRaça: {animal.Raca}\nData de Cadastro: {animal.DataCadastro}");
            }
            Console.WriteLine();
        }
    }

    public void ListarAnimaisAdotados()
    {
        if (animaisAdotados.Count == 0)
        {
            Console.WriteLine("Nenhum animal adotado.\n");
        }
        else
        {
            Console.WriteLine("Lista de Animais Adotados:");
            foreach (var animalAdotado in animaisAdotados)
            {
                Console.WriteLine($"Nome: {animalAdotado.Nome}\nRaça: {animalAdotado.Raca}\nData de Cadastro: {animalAdotado.DataCadastro}");
            }
            Console.WriteLine();
        }
        }

        public void RemoverAnimal()
        {
            if (animais.Count > 0)
            {
                ListarAnimais();
                Console.WriteLine();
                Console.WriteLine("**REMOVER ANIMAIS**");
                Console.Write("Insira o código a ser removido: ");
                int codigo = int.Parse(Console.ReadLine());

                Animal removerAnimal = animais.Find(t => t.Indice == codigo);

                if (removerAnimal != null)
                {
                    animais.Remove(removerAnimal);
                    animaisAdotados.Add(removerAnimal);
                    Console.WriteLine("\nAnimal removido com sucesso.\n");
                }
                else
                {
                    Console.WriteLine("\nCódigo não encontrado. Nenhum animal removido.\n");
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!\n");
            }
        }

        public void AdotarAnimal()
        {
            ListarAnimais();

            Console.WriteLine("Informe o índice do pet que deseja adotar:");
            int indice;
            while (!int.TryParse(Console.ReadLine(), out indice) || indice < 0 || indice >= animais.Count)
            {
                Console.WriteLine("Índice inválido. Tente novamente:");
            }

            Animal adotado = animais[indice];
            animais.RemoveAt(indice);
            animaisAdotados.Add(adotado);

            Console.WriteLine("Recebemos sua mensagem de adoção, entraremos em contato em breve!\n");
        }

        public void AlterarAnimal(string nomeAnimalParaAlterar)
        {
            Animal animalParaAlterar = animais.Find(a => a.Nome == nomeAnimalParaAlterar);

            if (animalParaAlterar != null)
            {
                Console.Write("Digite o novo nome para o animal: ");
                string novoNome = Console.ReadLine();

                Console.Write("Digite a nova raça para o animal: ");
                string novaRaca = Console.ReadLine();

                animalParaAlterar.Nome = novoNome;
                animalParaAlterar.Raca = novaRaca;

                Console.WriteLine("Animal alterado: Nome = " + animalParaAlterar.Nome + ", Raça = " + animalParaAlterar.Raca);
            }
            else
            {
                Console.WriteLine("Animal não encontrado");
            }

            Console.WriteLine("Lista de animais após a alteração:");
            foreach (Animal animal in animais)
            {
                Console.WriteLine("Nome: " + animal.Nome + ", Raça: " + animal.Raca);
            }
        }
    }




