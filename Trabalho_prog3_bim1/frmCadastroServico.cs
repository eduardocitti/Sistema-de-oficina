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
    public partial class frmCadastroServico : Form
    {
        private List<Servico> listaServicos;
        private frmPrincipal frmPrincipal;

        public frmCadastroServico(List<Servico> listaServicos, frmPrincipal frmPrincipal)
        {
            this.listaServicos = listaServicos;
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
            txtNomeServico.Text = "";
            txtValor.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeServico.Text != "" && txtValor.Text != "")
            {
                Servico servico = new Servico(txtNomeServico.Text, Convert.ToDouble(txtValor.Text));
                listaServicos.Add(servico);
                StreamWriter streamListaServicos = File.AppendText("lista_servicos.csv");
                var csv = new CsvWriter(streamListaServicos);
                csv.WriteField(servico.getNome());
                csv.WriteField(servico.getValor());
                csv.NextRecord();
                streamListaServicos.Close();
                this.Close();
                frmPrincipal.AtualizaListaServicos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void frmCadastroServico_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica.validaValor(sender, e);
        }
    }
}
