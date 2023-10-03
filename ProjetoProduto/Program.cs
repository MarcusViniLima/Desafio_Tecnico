// See https://aka.ms/new-console-template for more information
using ProjetoProduto.Controller;
using ProjetoProduto.Model;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
ProdutoController sc = new ProdutoController();

Console.WriteLine("-------SISTEMA INICIADO-------");

    Console.WriteLine("Escolha a função:");
    Console.WriteLine("1 - Sair");
    Console.WriteLine("2 - Cadastrar Produto");
    Console.WriteLine("3 - Listar produtos");
    Console.WriteLine("4 - Alterar nome de um produto");
    Console.WriteLine("5 - remover Produto");
    int opcao  = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Sistema finalizando.");
            break;
        case 2:
            sc.AddProduto();
            break;
        case 3:
            sc.listaDeProdutos();
            break;
        case 4:
            sc.editarProduto();
            break;
        case 5:
            sc.removerProduto();
            break;
        default:
            Console.WriteLine("Digite uma opção valida.");
            break;
    }
