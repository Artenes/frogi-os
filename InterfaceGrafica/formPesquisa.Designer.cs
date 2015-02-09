namespace FROGI_OS
{
    partial class formPesquisa
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
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textValorPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCampoPesquisa = new System.Windows.Forms.ComboBox();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.pictureNovo = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.buttonPesquisar);
            this.panelCabecalho.Controls.Add(this.textValorPesquisa);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.comboCampoPesquisa);
            this.panelCabecalho.Controls.Add(this.pictureFechar);
            this.panelCabecalho.Controls.Add(this.labelPesquisa);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(966, 73);
            this.panelCabecalho.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.AutoSize = true;
            this.buttonPesquisar.Enabled = false;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPesquisar.Location = new System.Drawing.Point(788, 24);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(99, 37);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.Text = "pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textValorPesquisa
            // 
            this.textValorPesquisa.Enabled = false;
            this.textValorPesquisa.Location = new System.Drawing.Point(547, 27);
            this.textValorPesquisa.MaxLength = 60;
            this.textValorPesquisa.Name = "textValorPesquisa";
            this.textValorPesquisa.Size = new System.Drawing.Size(226, 33);
            this.textValorPesquisa.TabIndex = 2;
            this.textValorPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValorPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(517, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // comboCampoPesquisa
            // 
            this.comboCampoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCampoPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCampoPesquisa.FormattingEnabled = true;
            this.comboCampoPesquisa.Location = new System.Drawing.Point(314, 27);
            this.comboCampoPesquisa.Name = "comboCampoPesquisa";
            this.comboCampoPesquisa.Size = new System.Drawing.Size(197, 33);
            this.comboCampoPesquisa.TabIndex = 1;
            this.comboCampoPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboCampoPesquisa_SelectedIndexChanged);
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
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 40F);
            this.labelPesquisa.ForeColor = System.Drawing.Color.White;
            this.labelPesquisa.Location = new System.Drawing.Point(3, 1);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(225, 72);
            this.labelPesquisa.TabIndex = 0;
            this.labelPesquisa.Text = "Pesquisa";
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.Black;
            this.panelRodape.Controls.Add(this.pictureNovo);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRodape.Location = new System.Drawing.Point(0, 416);
            this.panelRodape.Margin = new System.Windows.Forms.Padding(0);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(966, 75);
            this.panelRodape.TabIndex = 1;
            // 
            // pictureNovo
            // 
            this.pictureNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureNovo.Image = global::FROGI_OS.Properties.Resources.icone_novo;
            this.pictureNovo.Location = new System.Drawing.Point(895, 8);
            this.pictureNovo.Name = "pictureNovo";
            this.pictureNovo.Size = new System.Drawing.Size(64, 64);
            this.pictureNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovo.TabIndex = 6;
            this.pictureNovo.TabStop = false;
            this.pictureNovo.Tag = "&Novo";
            this.pictureNovo.Click += new System.EventHandler(this.pictureNovo_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.AutoScroll = true;
            this.panelCentral.AutoSize = true;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(0, 73);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(966, 343);
            this.panelCentral.TabIndex = 2;
            // 
            // formPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.panelRodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPesquisa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClienteCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPesquisa_FormClosing);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelRodape;
        protected System.Windows.Forms.Label labelPesquisa;
        protected System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pictureNovo;
        private System.Windows.Forms.PictureBox pictureFechar;
        protected System.Windows.Forms.ComboBox comboCampoPesquisa;
        protected System.Windows.Forms.Button buttonPesquisar;
        protected System.Windows.Forms.TextBox textValorPesquisa;
        protected System.Windows.Forms.Label label1;

    }
}