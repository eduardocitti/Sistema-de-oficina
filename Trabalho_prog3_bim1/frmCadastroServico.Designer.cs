namespace Trabalho_prog3_bim1
{
    partial class frmCadastroServico
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
            this.lblValorTitle = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblNomeServicoTitle = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(223, 96);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(107, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblValorTitle
            // 
            this.lblValorTitle.AutoSize = true;
            this.lblValorTitle.Location = new System.Drawing.Point(12, 55);
            this.lblValorTitle.Name = "lblValorTitle";
            this.lblValorTitle.Size = new System.Drawing.Size(76, 13);
            this.lblValorTitle.TabIndex = 11;
            this.lblValorTitle.Text = "Valor por hora:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(107, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(191, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblNomeServicoTitle
            // 
            this.lblNomeServicoTitle.AutoSize = true;
            this.lblNomeServicoTitle.Location = new System.Drawing.Point(12, 18);
            this.lblNomeServicoTitle.Name = "lblNomeServicoTitle";
            this.lblNomeServicoTitle.Size = new System.Drawing.Size(92, 13);
            this.lblNomeServicoTitle.TabIndex = 9;
            this.lblNomeServicoTitle.Text = "Nome do Serviço:";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(107, 18);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(191, 20);
            this.txtNomeServico.TabIndex = 1;
            // 
            // frmCadastroServico
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(319, 132);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblValorTitle);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblNomeServicoTitle);
            this.Controls.Add(this.txtNomeServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroServico_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblValorTitle;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblNomeServicoTitle;
        private System.Windows.Forms.TextBox txtNomeServico;

    }
}