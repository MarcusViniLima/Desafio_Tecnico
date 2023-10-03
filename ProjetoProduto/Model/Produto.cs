using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProduto.Model
{
    internal class Produto
    {
        private int Id;
        private string Descricao;
        private int Quantidade;

        public Produto(int Id, string descricao, int quantidade) {
            this.Id = Id;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
        }

        public int getId()
        { return Id; }
        public string getDescricao()
        { return Descricao; }
        public int getQuantidade()
        {
            return Quantidade;
        }
        public void setDescricao(string descricao)
        {
            this.Descricao = descricao;
        }
        public void setQuantidade(int quantidade) { this.Quantidade = quantidade; }
        public override string ToString()
        {
            return base.ToString() + ": Código: " + getId() + ", Descrição: "
            + this.getDescricao() + ", Quantidade: " + getQuantidade();
        }
    }
}
