using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    public class Carro
    {
        private String nome;
        private String modelo;
        private Int16 ano;

        public Carro(String nome, String modelo, Int16 ano)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.ano = ano;
        }

        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getModelo()
        {
            return modelo;
        }
        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }

        public Int16 getAno()
        {
            return ano;
        }
        public void setAno(Int16 ano)
        {
            this.ano = ano;
        }

        override public String ToString()
        {
            return nome;
        }
    }
}
