using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("S - Sair");

                Console.WriteLine("Opção Desejada");
                comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();  

                switch (comandoEscolhido)
                {
                    case "1":
                        Console.Write("\nNome do Produto:" );
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
                            Console.WriteLine("\nNão Há Produtos Cadastrados");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        string nomeProduto = Console.ReadLine();
                        var produtoParaExcluir = produtos.FirstOrDefault(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
                        if (produtoParaExcluir != null || produtos.Count > 0)
                        {
                            Console.Write("\nDigite o Nome do Produto a Ser Excluído: ");
                            foreach (Product p in produtos)
                            {
                                Console.WriteLine(p.ObterTexto());
                            }

                            produtos.Remove(produtoParaExcluir);
                            Console.WriteLine("Produto Excluído Com Sucesso!");
                        }
                            else
                        {
                            Console.WriteLine("Não há itens na lista");
                        }
                        Console.ReadKey();
                        break;
                    case "S":

                        Console.WriteLine("Obrigado Por Usar o Programa");
                        Console.ReadKey();
                        break;
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
