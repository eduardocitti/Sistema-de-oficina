using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    public class ProdutoOrcamento
    {
        protected IProduto produto;
        protected Int16 quantidade;

		public IProduto getProduto()
        {
            return produto;
        }

		public void setProduto(IProduto produto)
        {
            this.produto = produto;
        }

		public Int16 getQuantidade()
        {
            return quantidade;
        }

        public void setQuantidade(Int16 quantidade)
        {
            this.quantidade = quantidade;
        }

        public void incrementaQuantidade()
        {
            quantidade++;
        }

        public void reduzQuantidade()
        {
            quantidade--;
        }

        public Double getValor()
        {
            return quantidade * produto.getValor();
        }

        public override string ToString()
        {
            return produto.getNome();
        }
    }
}
