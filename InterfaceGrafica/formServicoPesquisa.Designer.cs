namespace FROGI_OS
{
    partial class formServicoPesquisa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEditar = new System.Windows.Forms.PictureBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.bsServico = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.picturePesquisar = new System.Windows.Forms.PictureBox();
            this.pictureNovo = new System.Windows.Forms.PictureBox();
            this.labelCodigoLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPai = new FROGI_OS.TablessControl();
            this.tabServ = new System.Windows.Forms.TabPage();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTipo = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonNovoTipo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.comboCampoPesquisa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCampoPesquisa = new System.Windows.Forms.TextBox();
            this.gvServico = new System.Windows.Forms.DataGridView();
            this.SERVICO_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICO_DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICO_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.tabTipoServico = new System.Windows.Forms.TabPage();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.dgvTipoPesquisa = new System.Windows.Forms.DataGridView();
            this.tIPOCODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTipoPesquisa = new System.Windows.Forms.BindingSource(this.components);
            this.dsTipoPesquisa = new FROGI_OS.dsFROGIOS();
            this.label5 = new System.Windows.Forms.Label();
            this.textTipoDescricao = new System.Windows.Forms.TextBox();
            this.buttonPesquisarTipo = new System.Windows.Forms.Button();
            this.taServico = new FROGI_OS.dsFROGIOSTableAdapters.SERVICOTableAdapter();
            this.taManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taTipo = new FROGI_OS.dsFROGIOSTableAdapters.TIPOTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPai.SuspendLayout();
            this.tabServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).BeginInit();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).BeginInit();
            this.tabTipoServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPesquisa)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 537);
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
            this.panel1.Size = new System.Drawing.Size(1036, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(966, 12);
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
            this.label1.Size = new System.Drawing.Size(212, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviços";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureEditar);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Controls.Add(this.pictureExcluir);
            this.panel2.Controls.Add(this.pictureSalvar);
            this.panel2.Controls.Add(this.picturePesquisar);
            this.panel2.Controls.Add(this.pictureNovo);
            this.panel2.Controls.Add(this.labelCodigoLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 82);
            this.panel2.TabIndex = 1;
            // 
            // pictureEditar
            // 
            this.pictureEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureEditar.Image = global::FROGI_OS.Properties.Resources.icone_editar;
            this.pictureEditar.Location = new System.Drawing.Point(756, 8);
            this.pictureEditar.Name = "pictureEditar";
            this.pictureEditar.Size = new System.Drawing.Size(64, 64);
            this.pictureEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEditar.TabIndex = 10;
            this.pictureEditar.TabStop = false;
            this.pictureEditar.Click += new System.EventHandler(this.pictureEditar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_CODIGO", true));
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(118, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(118, 37);
            this.labelCodigo.TabIndex = 11;
            this.labelCodigo.Text = "CODIGO";
            // 
            // bsServico
            // 
            this.bsServico.DataMember = "SERVICO";
            this.bsServico.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureExcluir.Image = global::FROGI_OS.Properties.Resources.icone_excluir;
            this.pictureExcluir.Location = new System.Drawing.Point(826, 8);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(64, 64);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 9;
            this.pictureExcluir.TabStop = false;
            this.pictureExcluir.Click += new System.EventHandler(this.pictureExcluir_Click);
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(896, 8);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalvar.TabIndex = 8;
            this.pictureSalvar.TabStop = false;
            this.pictureSalvar.Click += new System.EventHandler(this.pictureSalvar_Click);
            // 
            // picturePesquisar
            // 
            this.picturePesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePesquisar.Image = global::FROGI_OS.Properties.Resources.icone_pesquisar;
            this.picturePesquisar.Location = new System.Drawing.Point(966, 8);
            this.picturePesquisar.Name = "picturePesquisar";
            this.picturePesquisar.Size = new System.Drawing.Size(64, 64);
            this.picturePesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePesquisar.TabIndex = 7;
            this.picturePesquisar.TabStop = false;
            this.picturePesquisar.Click += new System.EventHandler(this.picturePesquisar_Click);
            // 
            // pictureNovo
            // 
            this.pictureNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureNovo.Image = global::FROGI_OS.Properties.Resources.icone_novo;
            this.pictureNovo.Location = new System.Drawing.Point(686, 8);
            this.pictureNovo.Name = "pictureNovo";
            this.pictureNovo.Size = new System.Drawing.Size(64, 64);
            this.pictureNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovo.TabIndex = 6;
            this.pictureNovo.TabStop = false;
            this.pictureNovo.Click += new System.EventHandler(this.pictureNovo_Click);
            // 
            // labelCodigoLabel
            // 
            this.labelCodigoLabel.AutoSize = true;
            this.labelCodigoLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelCodigoLabel.ForeColor = System.Drawing.Color.White;
            this.labelCodigoLabel.Location = new System.Drawing.Point(6, 0);
            this.labelCodigoLabel.Name = "labelCodigoLabel";
            this.labelCodigoLabel.Size = new System.Drawing.Size(106, 37);
            this.labelCodigoLabel.TabIndex = 2;
            this.labelCodigoLabel.Text = "Código:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.tabPai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 375);
            this.panel3.TabIndex = 2;
            // 
            // tabPai
            // 
            this.tabPai.Controls.Add(this.tabServ);
            this.tabPai.Controls.Add(this.tabPesquisa);
            this.tabPai.Controls.Add(this.tabTipoServico);
            this.tabPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPai.Location = new System.Drawing.Point(0, 0);
            this.tabPai.Margin = new System.Windows.Forms.Padding(0);
            this.tabPai.Name = "tabPai";
            this.tabPai.SelectedIndex = 0;
            this.tabPai.Size = new System.Drawing.Size(1036, 375);
            this.tabPai.TabIndex = 0;
            this.tabPai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabPai_KeyDown);
            // 
            // tabServ
            // 
            this.tabServ.AutoScroll = true;
            this.tabServ.BackColor = System.Drawing.Color.LightBlue;
            this.tabServ.Controls.Add(this.textValor);
            this.tabServ.Controls.Add(this.textDesc);
            this.tabServ.Controls.Add(this.dgvTipo);
            this.tabServ.Controls.Add(this.buttonAdicionar);
            this.tabServ.Controls.Add(this.buttonNovoTipo);
            this.tabServ.Controls.Add(this.label9);
            this.tabServ.Controls.Add(this.label7);
            this.tabServ.Controls.Add(this.label4);
            this.tabServ.Location = new System.Drawing.Point(4, 22);
            this.tabServ.Margin = new System.Windows.Forms.Padding(0);
            this.tabServ.Name = "tabServ";
            this.tabServ.Padding = new System.Windows.Forms.Padding(3);
            this.tabServ.Size = new System.Drawing.Size(1028, 349);
            this.tabServ.TabIndex = 0;
            this.tabServ.Text = "tabPage1";
            // 
            // textValor
            // 
            this.textValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_VALOR", true));
            this.textValor.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.textValor.Location = new System.Drawing.Point(519, 42);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(491, 33);
            this.textValor.TabIndex = 5;
            // 
            // textDesc
            // 
            this.textDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsServico, "SERVICO_DESCRICAO", true));
            this.textDesc.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.textDesc.Location = new System.Drawing.Point(11, 42);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(486, 33);
            this.textDesc.TabIndex = 4;
            // 
            // dgvTipo
            // 
            this.dgvTipo.AllowUserToAddRows = false;
            this.dgvTipo.AutoGenerateColumns = false;
            this.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao});
            this.dgvTipo.DataSource = this.bsTipo;
            this.dgvTipo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTipo.Location = new System.Drawing.Point(3, 127);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            this.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipo.Size = new System.Drawing.Size(1022, 219);
            this.dgvTipo.TabIndex = 7;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "TIPO_DESCRICAO";
            this.descricao.HeaderText = "DESCRICAO";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // bsTipo
            // 
            this.bsTipo.DataMember = "TIPO";
            this.bsTipo.DataSource = this.dsFROGIOS;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Location = new System.Drawing.Point(173, 102);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonNovoTipo
            // 
            this.buttonNovoTipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNovoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoTipo.Location = new System.Drawing.Point(935, 102);
            this.buttonNovoTipo.Name = "buttonNovoTipo";
            this.buttonNovoTipo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoTipo.TabIndex = 8;
            this.buttonNovoTipo.Text = "Novo";
            this.buttonNovoTipo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 30);
            this.label9.TabIndex = 68;
            this.label9.Text = "Tipo de serviço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(514, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 61;
            this.label7.Text = "Valor do serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 53;
            this.label4.Text = "Descrição";
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.AutoScroll = true;
            this.tabPesquisa.BackColor = System.Drawing.Color.LightBlue;
            this.tabPesquisa.Controls.Add(this.label40);
            this.tabPesquisa.Controls.Add(this.comboCampoPesquisa);
            this.tabPesquisa.Controls.Add(this.label3);
            this.tabPesquisa.Controls.Add(this.textCampoPesquisa);
            this.tabPesquisa.Controls.Add(this.gvServico);
            this.tabPesquisa.Controls.Add(this.buttonPesquisar);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Size = new System.Drawing.Size(1028, 349);
            this.tabPesquisa.TabIndex = 2;
            this.tabPesquisa.Text = "tabPage3";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(412, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 25);
            this.label40.TabIndex = 68;
            this.label40.Text = "=";
            // 
            // comboCampoPesquisa
            // 
            this.comboCampoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCampoPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCampoPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCampoPesquisa.FormattingEnabled = true;
            this.comboCampoPesquisa.Items.AddRange(new object[] {
            "CODIGO",
            "DESCRICAO"});
            this.comboCampoPesquisa.Location = new System.Drawing.Point(149, 15);
            this.comboCampoPesquisa.MaxLength = 1;
            this.comboCampoPesquisa.Name = "comboCampoPesquisa";
            this.comboCampoPesquisa.Size = new System.Drawing.Size(257, 33);
            this.comboCampoPesquisa.TabIndex = 0;
            this.comboCampoPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboCampoPesquisa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Pesquisar por";
            // 
            // textCampoPesquisa
            // 
            this.textCampoPesquisa.Enabled = false;
            this.textCampoPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.textCampoPesquisa.Location = new System.Drawing.Point(442, 16);
            this.textCampoPesquisa.MaxLength = 60;
            this.textCampoPesquisa.Name = "textCampoPesquisa";
            this.textCampoPesquisa.Size = new System.Drawing.Size(410, 32);
            this.textCampoPesquisa.TabIndex = 1;
            // 
            // gvServico
            // 
            this.gvServico.AllowUserToAddRows = false;
            this.gvServico.AllowUserToDeleteRows = false;
            this.gvServico.AutoGenerateColumns = false;
            this.gvServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SERVICO_CODIGO,
            this.SERVICO_DESCRICAO,
            this.SERVICO_VALOR});
            this.gvServico.DataSource = this.bsServico;
            this.gvServico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvServico.Location = new System.Drawing.Point(0, 56);
            this.gvServico.Name = "gvServico";
            this.gvServico.ReadOnly = true;
            this.gvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvServico.Size = new System.Drawing.Size(1028, 293);
            this.gvServico.TabIndex = 3;
            this.gvServico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvServico_CellDoubleClick);
            this.gvServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvServico_KeyDown);
            // 
            // SERVICO_CODIGO
            // 
            this.SERVICO_CODIGO.DataPropertyName = "SERVICO_CODIGO";
            this.SERVICO_CODIGO.HeaderText = "CODIGO";
            this.SERVICO_CODIGO.Name = "SERVICO_CODIGO";
            this.SERVICO_CODIGO.ReadOnly = true;
            // 
            // SERVICO_DESCRICAO
            // 
            this.SERVICO_DESCRICAO.DataPropertyName = "SERVICO_DESCRICAO";
            this.SERVICO_DESCRICAO.HeaderText = "DESCRICAO";
            this.SERVICO_DESCRICAO.Name = "SERVICO_DESCRICAO";
            this.SERVICO_DESCRICAO.ReadOnly = true;
            // 
            // SERVICO_VALOR
            // 
            this.SERVICO_VALOR.DataPropertyName = "SERVICO_VALOR";
            this.SERVICO_VALOR.HeaderText = "VALOR";
            this.SERVICO_VALOR.Name = "SERVICO_VALOR";
            this.SERVICO_VALOR.ReadOnly = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.AutoSize = true;
            this.buttonPesquisar.Enabled = false;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(875, 13);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(98, 37);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // tabTipoServico
            // 
            this.tabTipoServico.AutoScroll = true;
            this.tabTipoServico.BackColor = System.Drawing.Color.LightBlue;
            this.tabTipoServico.Controls.Add(this.buttonVoltar);
            this.tabTipoServico.Controls.Add(this.dgvTipoPesquisa);
            this.tabTipoServico.Controls.Add(this.label5);
            this.tabTipoServico.Controls.Add(this.textTipoDescricao);
            this.tabTipoServico.Controls.Add(this.buttonPesquisarTipo);
            this.tabTipoServico.Location = new System.Drawing.Point(4, 22);
            this.tabTipoServico.Name = "tabTipoServico";
            this.tabTipoServico.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoServico.Size = new System.Drawing.Size(1028, 349);
            this.tabTipoServico.TabIndex = 3;
            this.tabTipoServico.Text = "tabPage1";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.AutoSize = true;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(8, 9);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(80, 33);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // dgvTipoPesquisa
            // 
            this.dgvTipoPesquisa.AllowUserToAddRows = false;
            this.dgvTipoPesquisa.AllowUserToDeleteRows = false;
            this.dgvTipoPesquisa.AutoGenerateColumns = false;
            this.dgvTipoPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIPOCODIGODataGridViewTextBoxColumn,
            this.tIPODESCRICAODataGridViewTextBoxColumn});
            this.dgvTipoPesquisa.DataSource = this.bsTipoPesquisa;
            this.dgvTipoPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTipoPesquisa.Location = new System.Drawing.Point(3, 49);
            this.dgvTipoPesquisa.Name = "dgvTipoPesquisa";
            this.dgvTipoPesquisa.ReadOnly = true;
            this.dgvTipoPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoPesquisa.Size = new System.Drawing.Size(1022, 297);
            this.dgvTipoPesquisa.TabIndex = 67;
            this.dgvTipoPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPesquisa_CellDoubleClick);
            this.dgvTipoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTipoPesquisa_KeyDown);
            // 
            // tIPOCODIGODataGridViewTextBoxColumn
            // 
            this.tIPOCODIGODataGridViewTextBoxColumn.DataPropertyName = "TIPO_CODIGO";
            this.tIPOCODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.tIPOCODIGODataGridViewTextBoxColumn.Name = "tIPOCODIGODataGridViewTextBoxColumn";
            this.tIPOCODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODESCRICAODataGridViewTextBoxColumn
            // 
            this.tIPODESCRICAODataGridViewTextBoxColumn.DataPropertyName = "TIPO_DESCRICAO";
            this.tIPODESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.tIPODESCRICAODataGridViewTextBoxColumn.Name = "tIPODESCRICAODataGridViewTextBoxColumn";
            this.tIPODESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTipoPesquisa
            // 
            this.bsTipoPesquisa.DataMember = "TIPO";
            this.bsTipoPesquisa.DataSource = this.dsTipoPesquisa;
            // 
            // dsTipoPesquisa
            // 
            this.dsTipoPesquisa.DataSetName = "dsFROGIOS";
            this.dsTipoPesquisa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(94, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Tipo de serviço =";
            // 
            // textTipoDescricao
            // 
            this.textTipoDescricao.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.textTipoDescricao.Location = new System.Drawing.Point(251, 9);
            this.textTipoDescricao.MaxLength = 60;
            this.textTipoDescricao.Name = "textTipoDescricao";
            this.textTipoDescricao.Size = new System.Drawing.Size(658, 32);
            this.textTipoDescricao.TabIndex = 10;
            // 
            // buttonPesquisarTipo
            // 
            this.buttonPesquisarTipo.AutoSize = true;
            this.buttonPesquisarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarTipo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarTipo.Location = new System.Drawing.Point(922, 6);
            this.buttonPesquisarTipo.Name = "buttonPesquisarTipo";
            this.buttonPesquisarTipo.Size = new System.Drawing.Size(98, 37);
            this.buttonPesquisarTipo.TabIndex = 11;
            this.buttonPesquisarTipo.Text = "Pesquisar";
            this.buttonPesquisarTipo.UseVisualStyleBackColor = true;
            this.buttonPesquisarTipo.Click += new System.EventHandler(this.buttonPesquisarTipo_Click);
            // 
            // taServico
            // 
            this.taServico.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.CATEGORIATableAdapter = null;
            this.taManager.CLIENTE_FISICOTableAdapter = null;
            this.taManager.CLIENTE_JURIDICOTableAdapter = null;
            this.taManager.CLIENTETableAdapter = null;
            this.taManager.COMPRATableAdapter = null;
            this.taManager.EMPRESATableAdapter = null;
            this.taManager.FORNECEDOR_FISICOTableAdapter = null;
            this.taManager.FORNECEDOR_JURIDICOTableAdapter = null;
            this.taManager.FORNECEDORTableAdapter = null;
            this.taManager.FUNCIONARIOTableAdapter = null;
            this.taManager.GRUPOTableAdapter = null;
            this.taManager.ITEM_COMPRATableAdapter = null;
            this.taManager.MARCATableAdapter = null;
            this.taManager.ORCAMENTO_ITEMTableAdapter = null;
            this.taManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.taManager.ORCAMENTOTableAdapter = null;
            this.taManager.OS_ITEMTableAdapter = null;
            this.taManager.OS_SERVICOTableAdapter = null;
            this.taManager.OSTableAdapter = null;
            this.taManager.PERMISSAOTableAdapter = null;
            this.taManager.PRODUTOTableAdapter = null;
            this.taManager.SECAOTableAdapter = null;
            this.taManager.SERVICO_TIPOTableAdapter = null;
            this.taManager.SERVICOTableAdapter = this.taServico;
            this.taManager.TIPOTableAdapter = null;
            this.taManager.UFTableAdapter = null;
            this.taManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.USUARIOTableAdapter = null;
            // 
            // taTipo
            // 
            this.taTipo.ClearBeforeFill = true;
            // 
            // formServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1036, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formServico";
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
            ((System.ComponentModel.ISupportInitialize)(this.bsServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPai.ResumeLayout(false);
            this.tabServ.ResumeLayout(false);
            this.tabServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).EndInit();
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).EndInit();
            this.tabTipoServico.ResumeLayout(false);
            this.tabTipoServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigoLabel;
        private System.Windows.Forms.Panel panel3;
        private TablessControl tabPai;
        private System.Windows.Forms.TabPage tabServ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.PictureBox pictureEditar;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.PictureBox pictureSalvar;
        private System.Windows.Forms.PictureBox picturePesquisar;
        private System.Windows.Forms.PictureBox pictureNovo;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Button buttonNovoTipo;
        private System.Windows.Forms.Button buttonPesquisar;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsServico;
        private dsFROGIOSTableAdapters.SERVICOTableAdapter taServico;
        private dsFROGIOSTableAdapters.TableAdapterManager taManager;
        private System.Windows.Forms.DataGridView gvServico;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox comboCampoPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCampoPesquisa;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICO_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICO_DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICO_VALOR;
        private System.Windows.Forms.BindingSource bsTipo;
        private dsFROGIOSTableAdapters.TIPOTableAdapter taTipo;
        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TabPage tabTipoServico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTipoDescricao;
        private System.Windows.Forms.Button buttonPesquisarTipo;
        private System.Windows.Forms.DataGridView dgvTipoPesquisa;
        private dsFROGIOS dsTipoPesquisa;
        private System.Windows.Forms.BindingSource bsTipoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOCODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;

    }
}