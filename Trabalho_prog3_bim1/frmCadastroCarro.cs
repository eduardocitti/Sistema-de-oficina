using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_prog3_bim1
{
    public partial class frmCadastroCarro : Form
    {
        private frmPrincipal frmPrincipal;        
        public List<Carro> listaCarro;

        public frmCadastroCarro(List<Carro> listaCarro, frmPrincipal frmPrincipal)
        {
            this.listaCarro = listaCarro;
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
            txtNomeCarro.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCarro.Text != "" && txtModelo.Text != "" && txtAno.Text != "")
            {
                Carro carro = new Carro(txtNomeCarro.Text, txtModelo.Text, Convert.ToInt16(txtAno.Text));
                this.listaCarro.Add(carro);
                StreamWriter streamListaCarros = File.AppendText("lista_carros.csv");
                var csv = new CsvWriter(streamListaCarros);
                csv.WriteField(carro.getNome());
                csv.WriteField(carro.getModelo());
                csv.WriteField(carro.getAno());
                csv.NextRecord();
                streamListaCarros.Close();
                this.Close();
                this.frmPrincipal.AtualizaListaCarros();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void CarroCadastrado(object sender, FormClosingEventArgs e)
        {
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica.validaAno(sender, e);
        }
    }
}
