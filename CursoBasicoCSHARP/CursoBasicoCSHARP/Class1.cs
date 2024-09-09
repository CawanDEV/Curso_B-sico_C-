using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CursoBasicoCSHARP
{
    internal class Class1
    {
        private static List<Product> produtos = new List<Product>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

            string comandoEscolhido = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha Uma Opção");
                Console.WriteLine("1 - Cadastrar Um Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Excluir Produto");
                Console.WriteLine("4 - Adicionar Quantidade a um Produto");
                Console.WriteLine("S - Sair");

                Console.WriteLine("Opção Desejada");
                comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();

                switch (comandoEscolhido)
                {
                    case "1":
                        Console.Write("\nNome do Produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Preço do Produto: ");
                        string preco = Console.ReadLine();
                        Product novoProduto = new Product(nome, Convert.ToDouble(preco));
                        produtos.Add(novoProduto);
                        Console.WriteLine("Produto Adicionado Com Sucesso!");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        if (produtos.Count > 0)
                        {
                            Console.WriteLine("\nListagem de Produtos");
                            foreach (Product p in produtos)
                            {
                                Console.WriteLine(p.ObterTexto());
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNão Há Produtos Cadastrados");
                        }
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        if (produtos.Count > 0)
                        {
                            Console.WriteLine("Lista de Produtos:");
                            for (int i = 0; i < produtos.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {produtos[i].ObterTexto()}");
                            }
                            Console.Write("\nDigite o número do produto que deseja excluir: ");
                            string input = Console.ReadLine();
                            int indice;
                            if (int.TryParse(input, out indice) && indice > 0 && indice <= produtos.Count)
                            {
                                Product produtoParaExcluir = produtos[indice - 1];
                                produtos.RemoveAt(indice - 1);
                                Console.WriteLine($"\nProduto '{produtoParaExcluir.Nome}' excluído com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Nenhum produto foi excluído.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há itens na lista.");
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        if (produtos.Count >0)
                        {
                            Console.WriteLine("Digite o Produto que Deseja Adicionar Estoque");
                            string estoque = Console.ReadLine();
                            produtos.Add    
                        }
                        else
                        {
                            Console.WriteLine("Não Itens na Lista Para Adicionar Esroque");
                        }
                        break;

                    case "S":
                        Console.WriteLine("Obrigado Por Usar o Programa");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("\nOpção Inválida! Tente Novamente");
                        Console.ReadKey();
                        break;
                }
            }
            while (true);
        }
    }
}
