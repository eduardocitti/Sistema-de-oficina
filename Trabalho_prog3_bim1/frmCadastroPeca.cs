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
    public partial class frmCadastroPeca : Form
    {
        private List<Peca> listaPecas;
        private frmPrincipal frmPrincipal;

        public frmCadastroPeca(List<Peca> listaPecas, frmPrincipal frmPrincipal, List<Carro> listaCarros)
        {
            this.listaPecas = listaPecas;
            this.frmPrincipal = frmPrincipal;

            HashSet<String> modelos = new HashSet<String>();
            foreach (Carro c in listaCarros)
            {
                modelos.Add(c.getModelo());
            }

            InitializeComponent();

            cbModeloCarro.Items.AddRange(modelos.ToArray());
            txtNomePeca.Text = "";
            txtAnoInicial.Text = "";
            txtAnoFinal.Text = "";
            txtValor.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomePeca.Text != "" && cbModeloCarro.Text != "" && txtAnoInicial.Text != "" && txtAnoFinal.Text != "" && txtValor.Text != "")
            {
                if (Convert.ToInt16(txtAnoInicial.Text) > Convert.ToInt16(txtAnoFinal.Text))
                {
                    MessageBox.Show("O Ano inicial deve ser menor que ano final!");
                }
                else
                {
                    Peca peca = new Peca(
                        txtNomePeca.Text,
                        cbModeloCarro.SelectedItem.ToString(),
                        Convert.ToInt16(txtAnoInicial.Text),
                        Convert.ToInt16(txtAnoFinal.Text),
                        Convert.ToDouble(txtValor.Text)
                    );
                    listaPecas.Add(peca);
                    StreamWriter streamListaPecas = File.AppendText("lista_pecas.csv");
                    var csv = new CsvWriter(streamListaPecas);
                    csv.WriteField(peca.getNome());
                    csv.WriteField(peca.getModelo());
                    csv.WriteField(peca.getAnoInicial());
                    csv.WriteField(peca.getAnoFinal());
                    csv.WriteField(peca.getValor());
                    csv.NextRecord();
                    streamListaPecas.Close();
                    this.Close();
                    frmPrincipal.AtualizaListaPecas();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void PecaCadastrada(object sender, FormClosingEventArgs e)
        {
        }

        private void txtAnoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica.validaAno(sender, e);
        }

        private void txtAnoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica.validaAno(sender, e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumerica.validaValor(sender, e);
        }
    }
}
