namespace FROGI_OS.InterfaceGrafica
{
    partial class formOSBasePesquisa
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
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.textValorPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCampoPesquisa = new System.Windows.Forms.ComboBox();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.buttonNovoRegistro = new System.Windows.Forms.Button();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.tablessPai = new FROGI_OS.TablessControl();
            this.tabFisico = new System.Windows.Forms.TabPage();
            this.tabJuridico = new System.Windows.Forms.TabPage();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelRodape.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.tablessPai.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.buttonPesquisar);
            this.panelCabecalho.Controls.Add(this.comboTipoCliente);
            this.panelCabecalho.Controls.Add(this.textValorPesquisa);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.comboCampoPesquisa);
            this.panelCabecalho.Controls.Add(this.pictureFechar);
            this.panelCabecalho.Controls.Add(this.labelPesquisa);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCabecalho.ForeColor = System.Drawing.Color.White;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(784, 100);
            this.panelCabecalho.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.AutoSize = true;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Location = new System.Drawing.Point(606, 38);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(98, 37);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Items.AddRange(new object[] {
            "Físico",
            "Jurídico"});
            this.comboTipoCliente.Location = new System.Drawing.Point(197, 41);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(99, 33);
            this.comboTipoCliente.TabIndex = 0;
            this.comboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.comboTipoCliente_SelectedIndexChanged);
            // 
            // textValorPesquisa
            // 
            this.textValorPesquisa.Location = new System.Drawing.Point(474, 41);
            this.textValorPesquisa.Name = "textValorPesquisa";
            this.textValorPesquisa.Size = new System.Drawing.Size(117, 33);
            this.textValorPesquisa.TabIndex = 2;
            this.textValorPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textValorPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 44);
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
            this.comboCampoPesquisa.Location = new System.Drawing.Point(317, 41);
            this.comboCampoPesquisa.Name = "comboCampoPesquisa";
            this.comboCampoPesquisa.Size = new System.Drawing.Size(121, 33);
            this.comboCampoPesquisa.TabIndex = 1;
            this.comboCampoPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboCampoPesquisa_SelectedIndexChanged);
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(710, 25);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(62, 50);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFechar.TabIndex = 1;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.labelPesquisa.Location = new System.Drawing.Point(12, 21);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(168, 54);
            this.labelPesquisa.TabIndex = 0;
            this.labelPesquisa.Text = "Pesquisa";
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.Black;
            this.panelRodape.Controls.Add(this.buttonNovoRegistro);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRodape.Location = new System.Drawing.Point(0, 491);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(784, 71);
            this.panelRodape.TabIndex = 2;
            // 
            // buttonNovoRegistro
            // 
            this.buttonNovoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoRegistro.ForeColor = System.Drawing.Color.White;
            this.buttonNovoRegistro.Location = new System.Drawing.Point(197, 6);
            this.buttonNovoRegistro.Name = "buttonNovoRegistro";
            this.buttonNovoRegistro.Size = new System.Drawing.Size(394, 53);
            this.buttonNovoRegistro.TabIndex = 6;
            this.buttonNovoRegistro.Text = "Novo registro";
            this.buttonNovoRegistro.UseVisualStyleBackColor = true;
            this.buttonNovoRegistro.Click += new System.EventHandler(this.buttonNovoRegistro_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.tablessPai);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentro.Location = new System.Drawing.Point(0, 100);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(784, 391);
            this.panelCentro.TabIndex = 3;
            // 
            // tablessPai
            // 
            this.tablessPai.Controls.Add(this.tabFisico);
            this.tablessPai.Controls.Add(this.tabJuridico);
            this.tablessPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablessPai.Location = new System.Drawing.Point(0, 0);
            this.tablessPai.Name = "tablessPai";
            this.tablessPai.SelectedIndex = 0;
            this.tablessPai.Size = new System.Drawing.Size(784, 391);
            this.tablessPai.TabIndex = 1;
            // 
            // tabFisico
            // 
            this.tabFisico.BackColor = System.Drawing.Color.LightBlue;
            this.tabFisico.Location = new System.Drawing.Point(4, 34);
            this.tabFisico.Name = "tabFisico";
            this.tabFisico.Padding = new System.Windows.Forms.Padding(3);
            this.tabFisico.Size = new System.Drawing.Size(776, 353);
            this.tabFisico.TabIndex = 0;
            this.tabFisico.Text = "fisico";
            // 
            // tabJuridico
            // 
            this.tabJuridico.BackColor = System.Drawing.Color.LightBlue;
            this.tabJuridico.Location = new System.Drawing.Point(4, 34);
            this.tabJuridico.Name = "tabJuridico";
            this.tabJuridico.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuridico.Size = new System.Drawing.Size(776, 353);
            this.tabJuridico.TabIndex = 1;
            this.tabJuridico.Text = "juridico";
            // 
            // formOSBasePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOSBasePesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOSBasePesquisa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formOSBasePesquisa_FormClosing);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelRodape.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.tablessPai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.PictureBox pictureFechar;
        protected System.Windows.Forms.Label labelPesquisa;
        protected System.Windows.Forms.TextBox textValorPesquisa;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox comboCampoPesquisa;
        protected System.Windows.Forms.ComboBox comboTipoCliente;
        protected System.Windows.Forms.Panel panelRodape;
        protected System.Windows.Forms.Panel panelCentro;
        protected System.Windows.Forms.Button buttonPesquisar;
        protected System.Windows.Forms.Button buttonNovoRegistro;
        protected TablessControl tablessPai;
        protected System.Windows.Forms.TabPage tabFisico;
        protected System.Windows.Forms.TabPage tabJuridico;
    }
}