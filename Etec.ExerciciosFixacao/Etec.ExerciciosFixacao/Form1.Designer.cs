namespace Etec.ExerciciosFixacao
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.MaskedTextBox();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(9, 70);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(13, 102);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(21, 13);
            this.lblRg.TabIndex = 2;
            this.lblRg.Text = "Rg";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 131);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 162);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 192);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(9, 220);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(88, 35);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 7;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(88, 67);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(100, 20);
            this.txbEndereco.TabIndex = 8;
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(88, 99);
            this.txbRg.Mask = "00.000.000-0";
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(100, 20);
            this.txbRg.TabIndex = 9;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(89, 128);
            this.txbCPF.Mask = "000.000.000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 10;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(88, 155);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(100, 20);
            this.txbCidade.TabIndex = 11;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(89, 185);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(100, 20);
            this.txbEstado.TabIndex = 12;
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(88, 217);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(100, 20);
            this.txbSalario.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 253);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(88, 6);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(94, 253);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(12, 282);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(94, 282);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 316);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.MaskedTextBox txbRg;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbSalario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

