namespace FROGI_OS
{
    partial class formCadastro
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
            this.components = new System.ComponentModel.Container();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.pictureEditar = new System.Windows.Forms.PictureBox();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.picturePesquisar = new System.Windows.Forms.PictureBox();
            this.pictureNovo = new System.Windows.Forms.PictureBox();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.pictureFechar);
            this.panelCabecalho.Controls.Add(this.labelCadastro);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(966, 73);
            this.panelCabecalho.TabIndex = 0;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(906, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(48, 48);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFechar.TabIndex = 2;
            this.pictureFechar.TabStop = false;
            this.toolTip.SetToolTip(this.pictureFechar, "Fechar janela [Alt+F4]");
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Segoe UI Light", 40F);
            this.labelCadastro.ForeColor = System.Drawing.Color.White;
            this.labelCadastro.Location = new System.Drawing.Point(3, 1);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(233, 72);
            this.labelCadastro.TabIndex = 0;
            this.labelCadastro.Text = "Cadastro";
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.Black;
            this.panelRodape.Controls.Add(this.panelCodigo);
            this.panelRodape.Controls.Add(this.pictureEditar);
            this.panelRodape.Controls.Add(this.pictureExcluir);
            this.panelRodape.Controls.Add(this.pictureSalvar);
            this.panelRodape.Controls.Add(this.picturePesquisar);
            this.panelRodape.Controls.Add(this.pictureNovo);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 416);
            this.panelRodape.Margin = new System.Windows.Forms.Padding(0);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(966, 75);
            this.panelRodape.TabIndex = 1;
            // 
            // panelCodigo
            // 
            this.panelCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCodigo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCodigo.Location = new System.Drawing.Point(0, 0);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(329, 72);
            this.panelCodigo.TabIndex = 11;
            // 
            // pictureEditar
            // 
            this.pictureEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEditar.Image = global::FROGI_OS.Properties.Resources.icone_editar;
            this.pictureEditar.Location = new System.Drawing.Point(688, 8);
            this.pictureEditar.Name = "pictureEditar";
            this.pictureEditar.Size = new System.Drawing.Size(64, 64);
            this.pictureEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEditar.TabIndex = 10;
            this.pictureEditar.TabStop = false;
            this.toolTip.SetToolTip(this.pictureEditar, "Editar registro [Ctrl+E]");
            this.pictureEditar.Visible = false;
            this.pictureEditar.Click += new System.EventHandler(this.pictureEditar_Click);
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureExcluir.Image = global::FROGI_OS.Properties.Resources.icone_excluir;
            this.pictureExcluir.Location = new System.Drawing.Point(758, 8);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(64, 64);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 9;
            this.pictureExcluir.TabStop = false;
            this.toolTip.SetToolTip(this.pictureExcluir, "Excluir registro [Ctrl+D]");
            this.pictureExcluir.Visible = false;
            this.pictureExcluir.Click += new System.EventHandler(this.pictureExcluir_Click);
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(828, 8);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalvar.TabIndex = 8;
            this.pictureSalvar.TabStop = false;
            this.toolTip.SetToolTip(this.pictureSalvar, "Salvar registro [Ctrl+S]");
            this.pictureSalvar.Visible = false;
            this.pictureSalvar.Click += new System.EventHandler(this.pictureSalvar_Click);
            // 
            // picturePesquisar
            // 
            this.picturePesquisar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picturePesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePesquisar.Image = global::FROGI_OS.Properties.Resources.icone_pesquisar;
            this.picturePesquisar.Location = new System.Drawing.Point(898, 8);
            this.picturePesquisar.Name = "picturePesquisar";
            this.picturePesquisar.Size = new System.Drawing.Size(64, 64);
            this.picturePesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePesquisar.TabIndex = 7;
            this.picturePesquisar.TabStop = false;
            this.toolTip.SetToolTip(this.picturePesquisar, "Pesquisar registro [Ctrl+P]");
            this.picturePesquisar.Visible = false;
            this.picturePesquisar.Click += new System.EventHandler(this.picturePesquisar_Click);
            // 
            // pictureNovo
            // 
            this.pictureNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureNovo.Image = global::FROGI_OS.Properties.Resources.icone_novo;
            this.pictureNovo.Location = new System.Drawing.Point(618, 8);
            this.pictureNovo.Name = "pictureNovo";
            this.pictureNovo.Size = new System.Drawing.Size(64, 64);
            this.pictureNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovo.TabIndex = 6;
            this.pictureNovo.TabStop = false;
            this.pictureNovo.Tag = "&Novo";
            this.toolTip.SetToolTip(this.pictureNovo, "Novo registro [Ctrl+N]");
            this.pictureNovo.Click += new System.EventHandler(this.pictureNovo_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.AutoScroll = true;
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentro.Location = new System.Drawing.Point(0, 73);
            this.panelCentro.Margin = new System.Windows.Forms.Padding(0);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(966, 343);
            this.panelCentro.TabIndex = 2;
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClienteCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCadastro_FormClosing);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelRodape;
        protected System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.PictureBox pictureEditar;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.PictureBox pictureSalvar;
        private System.Windows.Forms.PictureBox picturePesquisar;
        private System.Windows.Forms.PictureBox pictureNovo;
        private System.Windows.Forms.PictureBox pictureFechar;
        protected System.Windows.Forms.Panel panelCodigo;
        protected System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.ToolTip toolTip;

    }
}