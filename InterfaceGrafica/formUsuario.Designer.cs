namespace FROGI_OS
{
    partial class formUsuario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEditar = new System.Windows.Forms.PictureBox();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.picturePesquisar = new System.Windows.Forms.PictureBox();
            this.pictureNovo = new System.Windows.Forms.PictureBox();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabFornecedor = new FROGI_OS.TablessControl();
            this.tabFisica = new System.Windows.Forms.TabPage();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.treeSecao = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.treeOpcao = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabFornecedor.SuspendLayout();
            this.tabFisica.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(906, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(48, 48);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFechar.TabIndex = 2;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 40F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuários";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureEditar);
            this.panel2.Controls.Add(this.pictureExcluir);
            this.panel2.Controls.Add(this.pictureSalvar);
            this.panel2.Controls.Add(this.picturePesquisar);
            this.panel2.Controls.Add(this.pictureNovo);
            this.panel2.Controls.Add(this.labelDataCadastro);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 75);
            this.panel2.TabIndex = 1;
            // 
            // pictureEditar
            // 
            this.pictureEditar.Image = global::FROGI_OS.Properties.Resources.icone_editar;
            this.pictureEditar.Location = new System.Drawing.Point(688, 8);
            this.pictureEditar.Name = "pictureEditar";
            this.pictureEditar.Size = new System.Drawing.Size(64, 64);
            this.pictureEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEditar.TabIndex = 10;
            this.pictureEditar.TabStop = false;
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Image = global::FROGI_OS.Properties.Resources.icone_excluir;
            this.pictureExcluir.Location = new System.Drawing.Point(758, 8);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(64, 64);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 9;
            this.pictureExcluir.TabStop = false;
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(828, 8);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalvar.TabIndex = 8;
            this.pictureSalvar.TabStop = false;
            // 
            // picturePesquisar
            // 
            this.picturePesquisar.Image = global::FROGI_OS.Properties.Resources.icone_pesquisar;
            this.picturePesquisar.Location = new System.Drawing.Point(898, 8);
            this.picturePesquisar.Name = "picturePesquisar";
            this.picturePesquisar.Size = new System.Drawing.Size(64, 64);
            this.picturePesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePesquisar.TabIndex = 7;
            this.picturePesquisar.TabStop = false;
            // 
            // pictureNovo
            // 
            this.pictureNovo.Image = global::FROGI_OS.Properties.Resources.icone_novo;
            this.pictureNovo.Location = new System.Drawing.Point(618, 8);
            this.pictureNovo.Name = "pictureNovo";
            this.pictureNovo.Size = new System.Drawing.Size(64, 64);
            this.pictureNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovo.TabIndex = 6;
            this.pictureNovo.TabStop = false;
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelDataCadastro.ForeColor = System.Drawing.Color.White;
            this.labelDataCadastro.Location = new System.Drawing.Point(402, 0);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(149, 37);
            this.labelDataCadastro.TabIndex = 5;
            this.labelDataCadastro.Text = "00/00/0000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(197, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(213, 37);
            this.label20.TabIndex = 4;
            this.label20.Text = "Data de cadastro:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(147, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(44, 54);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.tabFornecedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 343);
            this.panel3.TabIndex = 2;
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.tabFisica);
            this.tabFornecedor.Controls.Add(this.tabPesquisa);
            this.tabFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFornecedor.Location = new System.Drawing.Point(0, 0);
            this.tabFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.SelectedIndex = 0;
            this.tabFornecedor.Size = new System.Drawing.Size(966, 343);
            this.tabFornecedor.TabIndex = 0;
            // 
            // tabFisica
            // 
            this.tabFisica.AutoScroll = true;
            this.tabFisica.BackColor = System.Drawing.Color.LightBlue;
            this.tabFisica.Controls.Add(this.label6);
            this.tabFisica.Controls.Add(this.treeOpcao);
            this.tabFisica.Controls.Add(this.label3);
            this.tabFisica.Controls.Add(this.treeSecao);
            this.tabFisica.Controls.Add(this.textSenha);
            this.tabFisica.Controls.Add(this.label5);
            this.tabFisica.Controls.Add(this.label4);
            this.tabFisica.Controls.Add(this.textNome);
            this.tabFisica.Location = new System.Drawing.Point(4, 22);
            this.tabFisica.Margin = new System.Windows.Forms.Padding(0);
            this.tabFisica.Name = "tabFisica";
            this.tabFisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisica.Size = new System.Drawing.Size(958, 317);
            this.tabFisica.TabIndex = 0;
            this.tabFisica.Text = "tabPage1";
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.textSenha.Location = new System.Drawing.Point(509, 46);
            this.textSenha.MaxLength = 10;
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(261, 32);
            this.textSenha.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(504, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 55;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.textNome.Location = new System.Drawing.Point(11, 46);
            this.textNome.MaxLength = 60;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(492, 32);
            this.textNome.TabIndex = 50;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.BackColor = System.Drawing.Color.LightBlue;
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Size = new System.Drawing.Size(958, 317);
            this.tabPesquisa.TabIndex = 2;
            this.tabPesquisa.Text = "tabPage3";
            // 
            // treeSecao
            // 
            this.treeSecao.Location = new System.Drawing.Point(11, 126);
            this.treeSecao.Name = "treeSecao";
            this.treeSecao.Size = new System.Drawing.Size(339, 185);
            this.treeSecao.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 30);
            this.label3.TabIndex = 57;
            this.label3.Text = "Seções do sisema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(351, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 30);
            this.label6.TabIndex = 59;
            this.label6.Text = "Opções da seção";
            // 
            // treeOpcao
            // 
            this.treeOpcao.Location = new System.Drawing.Point(356, 126);
            this.treeOpcao.Name = "treeOpcao";
            this.treeOpcao.Size = new System.Drawing.Size(414, 185);
            this.treeOpcao.TabIndex = 58;
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClienteCadastro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabFornecedor.ResumeLayout(false);
            this.tabFisica.ResumeLayout(false);
            this.tabFisica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDataCadastro;
        private System.Windows.Forms.Label label20;
        private TablessControl tabFornecedor;
        private System.Windows.Forms.TabPage tabFisica;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.PictureBox pictureEditar;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.PictureBox pictureSalvar;
        private System.Windows.Forms.PictureBox picturePesquisar;
        private System.Windows.Forms.PictureBox pictureNovo;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeOpcao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeSecao;

    }
}