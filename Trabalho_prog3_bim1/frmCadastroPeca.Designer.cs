namespace Trabalho_prog3_bim1
{
    partial class frmCadastroPeca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAnoTitle = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblModeloCarroTitle = new System.Windows.Forms.Label();
            this.txtAnoInicial = new System.Windows.Forms.TextBox();
            this.lblNomePecaTitle = new System.Windows.Forms.Label();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.cbModeloCarro = new System.Windows.Forms.ComboBox();
            this.lblValorTitle = new System.Windows.Forms.Label();
            this.txtAnoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(223, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(107, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAnoTitle
            // 
            this.lblAnoTitle.AutoSize = true;
            this.lblAnoTitle.Location = new System.Drawing.Point(13, 92);
            this.lblAnoTitle.Name = "lblAnoTitle";
            this.lblAnoTitle.Size = new System.Drawing.Size(29, 13);
            this.lblAnoTitle.TabIndex = 13;
            this.lblAnoTitle.Text = "Ano:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(107, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(191, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblModeloCarroTitle
            // 
            this.lblModeloCarroTitle.AutoSize = true;
            this.lblModeloCarroTitle.Location = new System.Drawing.Point(13, 55);
            this.lblModeloCarroTitle.Name = "lblModeloCarroTitle";
            this.lblModeloCarroTitle.Size = new System.Drawing.Size(88, 13);
            this.lblModeloCarroTitle.TabIndex = 11;
            this.lblModeloCarroTitle.Text = "Modelo do Carro:";
            // 
            // txtAnoInicial
            // 
            this.txtAnoInicial.Location = new System.Drawing.Point(107, 90);
            this.txtAnoInicial.Name = "txtAnoInicial";
            this.txtAnoInicial.Size = new System.Drawing.Size(75, 20);
            this.txtAnoInicial.TabIndex = 3;
            this.txtAnoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoInicial_KeyPress);
            // 
            // lblNomePecaTitle
            // 
            this.lblNomePecaTitle.AutoSize = true;
            this.lblNomePecaTitle.Location = new System.Drawing.Point(13, 18);
            this.lblNomePecaTitle.Name = "lblNomePecaTitle";
            this.lblNomePecaTitle.Size = new System.Drawing.Size(81, 13);
            this.lblNomePecaTitle.TabIndex = 9;
            this.lblNomePecaTitle.Text = "Nome da Peça:";
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.Location = new System.Drawing.Point(107, 18);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(191, 20);
            this.txtNomePeca.TabIndex = 1;
            // 
            // cbModeloCarro
            // 
            this.cbModeloCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeloCarro.FormattingEnabled = true;
            this.cbModeloCarro.Location = new System.Drawing.Point(107, 55);
            this.cbModeloCarro.Name = "cbModeloCarro";
            this.cbModeloCarro.Size = new System.Drawing.Size(191, 21);
            this.cbModeloCarro.TabIndex = 2;
            // 
            // lblValorTitle
            // 
            this.lblValorTitle.AutoSize = true;
            this.lblValorTitle.Location = new System.Drawing.Point(13, 134);
            this.lblValorTitle.Name = "lblValorTitle";
            this.lblValorTitle.Size = new System.Drawing.Size(34, 13);
            this.lblValorTitle.TabIndex = 17;
            this.lblValorTitle.Text = "Valor:";
            // 
            // txtAnoFinal
            // 
            this.txtAnoFinal.Location = new System.Drawing.Point(223, 90);
            this.txtAnoFinal.Name = "txtAnoFinal";
            this.txtAnoFinal.Size = new System.Drawing.Size(75, 20);
            this.txtAnoFinal.TabIndex = 4;
            this.txtAnoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoFinal_KeyPress);
            // 
            // frmCadastroPeca
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(319, 205);
            this.Controls.Add(this.txtAnoFinal);
            this.Controls.Add(this.lblValorTitle);
            this.Controls.Add(this.cbModeloCarro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAnoTitle);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblModeloCarroTitle);
            this.Controls.Add(this.txtAnoInicial);
            this.Controls.Add(this.lblNomePecaTitle);
            this.Controls.Add(this.txtNomePeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peça";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PecaCadastrada);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAnoTitle;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblModeloCarroTitle;
        private System.Windows.Forms.TextBox txtAnoInicial;
        private System.Windows.Forms.Label lblNomePecaTitle;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.ComboBox cbModeloCarro;
        private System.Windows.Forms.Label lblValorTitle;
        private System.Windows.Forms.TextBox txtAnoFinal;
    }
}