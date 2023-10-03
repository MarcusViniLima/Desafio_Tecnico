using ProjetoProduto.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProduto.Controller
{
    internal class ProdutoController
    {
        public Produto produto;
        ArrayList Aprodutos;
        public ProdutoController() {
            this.Aprodutos = new ArrayList();
            ProdutoDB();
        }

        private void ProdutoDB()
        {
            Produto Perfume = new Produto(1,"Kaiak",250);
            Aprodutos.Add(Perfume);
            Produto Perfume2 = new Produto(2, "LiLi", 100);
            Aprodutos.Add(Perfume2);
            Produto Perfume3 = new Produto(3, "TwoOneTwo", 250);
            Aprodutos.Add(Perfume3);
        }

        public void AddProduto()
        {
            Console.WriteLine("--------------CADASTRO DE ALUNOS--------------------");
            Console.WriteLine("Quantos produtos serão cadastrados?");
            int produtos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < produtos; i++)
            {
                Console.WriteLine("Digite o nome completo do produto:");
                String nomeP = Console.ReadLine();
                Console.WriteLine("Digite a quantidade do produto:");
                int quantidadeP = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o código do Produto:");
                int codigoP = Convert.ToInt32(Console.ReadLine());
                Produto novo = new Produto(codigoP, nomeP, quantidadeP);
                Aprodutos.Add(novo);
                listaDeProdutos();

                Console.WriteLine("Produto Cadastrado com sucesso!!");
            }

        }
        public void listaDeProdutos()
        {
            Console.WriteLine("-----------------------LISTA DE PRODUTO----------------------");
            foreach (Produto value in Aprodutos)
            {
                Console.WriteLine(value.ToString());
            }
        }

        public void removerProduto()
        {
            bool resultado = false;
            Console.WriteLine("-----------------------REMOÇÃO DE PRODUTO----------------------");
            Console.WriteLine("Digite o codigo do produto");
            int codigoP = Convert.ToInt32(Console.ReadLine());
            foreach (Produto value in Aprodutos)
            {
                if (value.getId().Equals(codigoP))
                {
                    Aprodutos.Remove(value);
                    Console.WriteLine("Produto removido com sucesso!!");
                    listaDeProdutos();
                }
                else { Console.WriteLine("Produto não encontrado"); }
            }

        }
        public void editarProduto()
        {
            bool resultado = false;
            Console.WriteLine("-----------------------ATUALIZAÇÃO DE PRODUTO----------------------");
            Console.WriteLine("Digite o codigo do produto");
            int codigoP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o novo nome do produto");
            string nomeP = Console.ReadLine();
            foreach (Produto value in Aprodutos)
            {
                if (value.getId().Equals(codigoP))
                {
                    value.setDescricao(nomeP);
                    Console.WriteLine("Produto alterado com sucesso!!");
                    listaDeProdutos();
                }
            }

        }
        
    }
}
