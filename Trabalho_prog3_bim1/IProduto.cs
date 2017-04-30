using System;
namespace Trabalho_prog3_bim1
{
    public class IProduto
    {
        protected String nome;
        protected Double valor;

        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public Double getValor()
        {
            return valor;
        }
        public void setValor(Double valor)
        {
            this.valor = valor;
        }
    }
}
