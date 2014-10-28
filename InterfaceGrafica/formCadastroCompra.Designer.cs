namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroCompra
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
            System.Windows.Forms.Label cOMPRA_NOTA_FISCALLabel;
            System.Windows.Forms.Label cOMPRA_FUNCIONARIOLabel;
            System.Windows.Forms.Label cOMPRA_FORNECEDORLabel;
            System.Windows.Forms.Label cOMPRA_DESCONTOLabel;
            System.Windows.Forms.Label cOMPRA_ACRESCIMOLabel;
            System.Windows.Forms.Label cOMPRA_TOTALLabel;
            System.Windows.Forms.Label cOMPRA_CODIGOLabel;
            System.Windows.Forms.Label pRODUTO_DESCRICAOLabel;
            System.Windows.Forms.Label pRODUTO_PRECO_COMPRALabel;
            System.Windows.Forms.Label iTEM_COMPRA_DESCONTOLabel;
            System.Windows.Forms.Label iTEM_COMPRA_QUANTIDADELabel;
            System.Windows.Forms.Label cOMPRA_DATALabel;
            System.Windows.Forms.Label label1;
            this.tabPai = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cOMPRA_NOTA_FISCALTextBox = new System.Windows.Forms.TextBox();
            this.cOMPRA_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.cOMPRA_FUNCIONARIOTextBox = new System.Windows.Forms.TextBox();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLancarProduto = new System.Windows.Forms.Button();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textProdutoDescricao = new System.Windows.Forms.TextBox();
            this.textProdutoPreco = new System.Windows.Forms.TextBox();
            this.textProdutoQuantidade = new System.Windows.Forms.TextBox();
            this.textProdutoDesconto = new System.Windows.Forms.TextBox();
            this.pESQUISA_PRODUTO_ITEMDataGridView = new System.Windows.Forms.DataGridView();
            this.tabConclusao = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTotalBruto = new System.Windows.Forms.TextBox();
            this.cOMPRA_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOMPRA_DESCONTOTextBox = new System.Windows.Forms.TextBox();
            this.cOMPRA_TOTALTextBox = new System.Windows.Forms.TextBox();
            this.cOMPRA_ACRESCIMOTextBox = new System.Windows.Forms.TextBox();
            this.cOMPRA_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.bsCompra = new System.Windows.Forms.BindingSource(this.components);
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsProduto = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProdutoItem = new System.Windows.Forms.BindingSource(this.components);
            this.bsItemCompra = new System.Windows.Forms.BindingSource(this.components);
            this.taCompra = new FROGI_OS.dsFROGIOSTableAdapters.COMPRATableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.taProduto = new FROGI_OS.dsFROGIOSTableAdapters.PRODUTOTableAdapter();
            this.taItemCompra = new FROGI_OS.dsFROGIOSTableAdapters.ITEM_COMPRATableAdapter();
            this.taPesquisaProdutoItem = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaProdutoItem();
            cOMPRA_NOTA_FISCALLabel = new System.Windows.Forms.Label();
            cOMPRA_FUNCIONARIOLabel = new System.Windows.Forms.Label();
            cOMPRA_FORNECEDORLabel = new System.Windows.Forms.Label();
            cOMPRA_DESCONTOLabel = new System.Windows.Forms.Label();
            cOMPRA_ACRESCIMOLabel = new System.Windows.Forms.Label();
            cOMPRA_TOTALLabel = new System.Windows.Forms.Label();
            cOMPRA_CODIGOLabel = new System.Windows.Forms.Label();
            pRODUTO_DESCRICAOLabel = new System.Windows.Forms.Label();
            pRODUTO_PRECO_COMPRALabel = new System.Windows.Forms.Label();
            iTEM_COMPRA_DESCONTOLabel = new System.Windows.Forms.Label();
            iTEM_COMPRA_QUANTIDADELabel = new System.Windows.Forms.Label();
            cOMPRA_DATALabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.tabPai.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabProduto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_PRODUTO_ITEMDataGridView)).BeginInit();
            this.tabConclusao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(504, 72);
            this.labelCadastro.Text = "Compra de produtos";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(cOMPRA_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.cOMPRA_CODIGOLabel1);
            this.panelCodigo.Size = new System.Drawing.Size(329, 96);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.tabPai);
            // 
            // cOMPRA_NOTA_FISCALLabel
            // 
            cOMPRA_NOTA_FISCALLabel.AutoSize = true;
            cOMPRA_NOTA_FISCALLabel.Location = new System.Drawing.Point(13, 145);
            cOMPRA_NOTA_FISCALLabel.Name = "cOMPRA_NOTA_FISCALLabel";
            cOMPRA_NOTA_FISCALLabel.Size = new System.Drawing.Size(186, 25);
            cOMPRA_NOTA_FISCALLabel.TabIndex = 0;
            cOMPRA_NOTA_FISCALLabel.Text = "Número da nota fiscal";
            // 
            // cOMPRA_FUNCIONARIOLabel
            // 
            cOMPRA_FUNCIONARIOLabel.AutoSize = true;
            cOMPRA_FUNCIONARIOLabel.Location = new System.Drawing.Point(95, 29);
            cOMPRA_FUNCIONARIOLabel.Name = "cOMPRA_FUNCIONARIOLabel";
            cOMPRA_FUNCIONARIOLabel.Size = new System.Drawing.Size(104, 25);
            cOMPRA_FUNCIONARIOLabel.TabIndex = 2;
            cOMPRA_FUNCIONARIOLabel.Text = "Funcionário";
            // 
            // cOMPRA_FORNECEDORLabel
            // 
            cOMPRA_FORNECEDORLabel.AutoSize = true;
            cOMPRA_FORNECEDORLabel.Location = new System.Drawing.Point(97, 86);
            cOMPRA_FORNECEDORLabel.Name = "cOMPRA_FORNECEDORLabel";
            cOMPRA_FORNECEDORLabel.Size = new System.Drawing.Size(104, 25);
            cOMPRA_FORNECEDORLabel.TabIndex = 4;
            cOMPRA_FORNECEDORLabel.Text = "Fornecedor";
            // 
            // cOMPRA_DESCONTOLabel
            // 
            cOMPRA_DESCONTOLabel.AutoSize = true;
            cOMPRA_DESCONTOLabel.Location = new System.Drawing.Point(22, 34);
            cOMPRA_DESCONTOLabel.Name = "cOMPRA_DESCONTOLabel";
            cOMPRA_DESCONTOLabel.Size = new System.Drawing.Size(133, 25);
            cOMPRA_DESCONTOLabel.TabIndex = 0;
            cOMPRA_DESCONTOLabel.Text = "Desconto geral";
            // 
            // cOMPRA_ACRESCIMOLabel
            // 
            cOMPRA_ACRESCIMOLabel.AutoSize = true;
            cOMPRA_ACRESCIMOLabel.Location = new System.Drawing.Point(16, 77);
            cOMPRA_ACRESCIMOLabel.Name = "cOMPRA_ACRESCIMOLabel";
            cOMPRA_ACRESCIMOLabel.Size = new System.Drawing.Size(139, 25);
            cOMPRA_ACRESCIMOLabel.TabIndex = 2;
            cOMPRA_ACRESCIMOLabel.Text = "Acréscimo geral";
            // 
            // cOMPRA_TOTALLabel
            // 
            cOMPRA_TOTALLabel.AutoSize = true;
            cOMPRA_TOTALLabel.Location = new System.Drawing.Point(43, 160);
            cOMPRA_TOTALLabel.Name = "cOMPRA_TOTALLabel";
            cOMPRA_TOTALLabel.Size = new System.Drawing.Size(112, 25);
            cOMPRA_TOTALLabel.TabIndex = 4;
            cOMPRA_TOTALLabel.Text = "Total líquido";
            // 
            // cOMPRA_CODIGOLabel
            // 
            cOMPRA_CODIGOLabel.AutoSize = true;
            cOMPRA_CODIGOLabel.ForeColor = System.Drawing.Color.White;
            cOMPRA_CODIGOLabel.Location = new System.Drawing.Point(25, 18);
            cOMPRA_CODIGOLabel.Name = "cOMPRA_CODIGOLabel";
            cOMPRA_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            cOMPRA_CODIGOLabel.TabIndex = 0;
            cOMPRA_CODIGOLabel.Text = "Código";
            // 
            // pRODUTO_DESCRICAOLabel
            // 
            pRODUTO_DESCRICAOLabel.AutoSize = true;
            pRODUTO_DESCRICAOLabel.Location = new System.Drawing.Point(20, 29);
            pRODUTO_DESCRICAOLabel.Name = "pRODUTO_DESCRICAOLabel";
            pRODUTO_DESCRICAOLabel.Size = new System.Drawing.Size(77, 25);
            pRODUTO_DESCRICAOLabel.TabIndex = 0;
            pRODUTO_DESCRICAOLabel.Text = "Produto";
            // 
            // pRODUTO_PRECO_COMPRALabel
            // 
            pRODUTO_PRECO_COMPRALabel.AutoSize = true;
            pRODUTO_PRECO_COMPRALabel.Location = new System.Drawing.Point(328, 89);
            pRODUTO_PRECO_COMPRALabel.Name = "pRODUTO_PRECO_COMPRALabel";
            pRODUTO_PRECO_COMPRALabel.Size = new System.Drawing.Size(57, 25);
            pRODUTO_PRECO_COMPRALabel.TabIndex = 2;
            pRODUTO_PRECO_COMPRALabel.Text = "Preço";
            // 
            // iTEM_COMPRA_DESCONTOLabel
            // 
            iTEM_COMPRA_DESCONTOLabel.AutoSize = true;
            iTEM_COMPRA_DESCONTOLabel.Location = new System.Drawing.Point(22, 89);
            iTEM_COMPRA_DESCONTOLabel.Name = "iTEM_COMPRA_DESCONTOLabel";
            iTEM_COMPRA_DESCONTOLabel.Size = new System.Drawing.Size(88, 25);
            iTEM_COMPRA_DESCONTOLabel.TabIndex = 4;
            iTEM_COMPRA_DESCONTOLabel.Text = "Desconto";
            // 
            // iTEM_COMPRA_QUANTIDADELabel
            // 
            iTEM_COMPRA_QUANTIDADELabel.AutoSize = true;
            iTEM_COMPRA_QUANTIDADELabel.Location = new System.Drawing.Point(665, 94);
            iTEM_COMPRA_QUANTIDADELabel.Name = "iTEM_COMPRA_QUANTIDADELabel";
            iTEM_COMPRA_QUANTIDADELabel.Size = new System.Drawing.Size(106, 25);
            iTEM_COMPRA_QUANTIDADELabel.TabIndex = 6;
            iTEM_COMPRA_QUANTIDADELabel.Text = "Quantidade";
            // 
            // cOMPRA_DATALabel
            // 
            cOMPRA_DATALabel.AutoSize = true;
            cOMPRA_DATALabel.Location = new System.Drawing.Point(12, 213);
            cOMPRA_DATALabel.Name = "cOMPRA_DATALabel";
            cOMPRA_DATALabel.Size = new System.Drawing.Size(140, 25);
            cOMPRA_DATALabel.TabIndex = 6;
            cOMPRA_DATALabel.Text = "Data da compra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 118);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 25);
            label1.TabIndex = 14;
            label1.Text = "Total bruto";
            // 
            // tabPai
            // 
            this.tabPai.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPai.Controls.Add(this.tabGeral);
            this.tabPai.Controls.Add(this.tabProduto);
            this.tabPai.Controls.Add(this.tabConclusao);
            this.tabPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPai.Location = new System.Drawing.Point(0, 0);
            this.tabPai.Name = "tabPai";
            this.tabPai.SelectedIndex = 0;
            this.tabPai.Size = new System.Drawing.Size(966, 343);
            this.tabPai.TabIndex = 0;
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.Color.LightBlue;
            this.tabGeral.Controls.Add(this.groupBox3);
            this.tabGeral.Location = new System.Drawing.Point(4, 37);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(958, 302);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Geral";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(cOMPRA_FUNCIONARIOLabel);
            this.groupBox3.Controls.Add(cOMPRA_FORNECEDORLabel);
            this.groupBox3.Controls.Add(this.cOMPRA_NOTA_FISCALTextBox);
            this.groupBox3.Controls.Add(this.cOMPRA_FORNECEDORTextBox);
            this.groupBox3.Controls.Add(cOMPRA_NOTA_FISCALLabel);
            this.groupBox3.Controls.Add(this.cOMPRA_FUNCIONARIOTextBox);
            this.groupBox3.Location = new System.Drawing.Point(174, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 200);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // cOMPRA_NOTA_FISCALTextBox
            // 
            this.cOMPRA_NOTA_FISCALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_NOTA_FISCAL", true));
            this.cOMPRA_NOTA_FISCALTextBox.Location = new System.Drawing.Point(224, 142);
            this.cOMPRA_NOTA_FISCALTextBox.MaxLength = 60;
            this.cOMPRA_NOTA_FISCALTextBox.Name = "cOMPRA_NOTA_FISCALTextBox";
            this.cOMPRA_NOTA_FISCALTextBox.Size = new System.Drawing.Size(264, 33);
            this.cOMPRA_NOTA_FISCALTextBox.TabIndex = 2;
            // 
            // cOMPRA_FORNECEDORTextBox
            // 
            this.cOMPRA_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_FORNECEDOR", true));
            this.cOMPRA_FORNECEDORTextBox.Location = new System.Drawing.Point(224, 83);
            this.cOMPRA_FORNECEDORTextBox.MaxLength = 60;
            this.cOMPRA_FORNECEDORTextBox.Name = "cOMPRA_FORNECEDORTextBox";
            this.cOMPRA_FORNECEDORTextBox.Size = new System.Drawing.Size(381, 33);
            this.cOMPRA_FORNECEDORTextBox.TabIndex = 1;
            this.cOMPRA_FORNECEDORTextBox.DoubleClick += new System.EventHandler(this.cOMPRA_FORNECEDORTextBox_DoubleClick);
            // 
            // cOMPRA_FUNCIONARIOTextBox
            // 
            this.cOMPRA_FUNCIONARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_FUNCIONARIO", true));
            this.cOMPRA_FUNCIONARIOTextBox.Location = new System.Drawing.Point(224, 26);
            this.cOMPRA_FUNCIONARIOTextBox.MaxLength = 60;
            this.cOMPRA_FUNCIONARIOTextBox.Name = "cOMPRA_FUNCIONARIOTextBox";
            this.cOMPRA_FUNCIONARIOTextBox.Size = new System.Drawing.Size(381, 33);
            this.cOMPRA_FUNCIONARIOTextBox.TabIndex = 0;
            this.cOMPRA_FUNCIONARIOTextBox.DoubleClick += new System.EventHandler(this.cOMPRA_FUNCIONARIOTextBox_DoubleClick);
            // 
            // tabProduto
            // 
            this.tabProduto.AutoScroll = true;
            this.tabProduto.BackColor = System.Drawing.Color.LightBlue;
            this.tabProduto.Controls.Add(this.panel1);
            this.tabProduto.Controls.Add(this.buttonLancarProduto);
            this.tabProduto.Controls.Add(this.buttonPesquisarProduto);
            this.tabProduto.Controls.Add(this.groupBox1);
            this.tabProduto.Controls.Add(this.pESQUISA_PRODUTO_ITEMDataGridView);
            this.tabProduto.Location = new System.Drawing.Point(4, 37);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(958, 302);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produtos";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1939, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 100);
            this.panel1.TabIndex = 10;
            // 
            // buttonLancarProduto
            // 
            this.buttonLancarProduto.AutoSize = true;
            this.buttonLancarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarProduto.Location = new System.Drawing.Point(11, 225);
            this.buttonLancarProduto.Name = "buttonLancarProduto";
            this.buttonLancarProduto.Size = new System.Drawing.Size(898, 37);
            this.buttonLancarProduto.TabIndex = 8;
            this.buttonLancarProduto.Text = "Lançar Produto";
            this.buttonLancarProduto.UseVisualStyleBackColor = true;
            this.buttonLancarProduto.Click += new System.EventHandler(this.buttonLancarProduto_Click);
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.AutoSize = true;
            this.buttonPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(11, 23);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(898, 37);
            this.buttonPesquisarProduto.TabIndex = 3;
            this.buttonPesquisarProduto.Text = "Pesquisar produto";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(pRODUTO_DESCRICAOLabel);
            this.groupBox1.Controls.Add(this.textProdutoDescricao);
            this.groupBox1.Controls.Add(iTEM_COMPRA_QUANTIDADELabel);
            this.groupBox1.Controls.Add(this.textProdutoPreco);
            this.groupBox1.Controls.Add(this.textProdutoQuantidade);
            this.groupBox1.Controls.Add(pRODUTO_PRECO_COMPRALabel);
            this.groupBox1.Controls.Add(iTEM_COMPRA_DESCONTOLabel);
            this.groupBox1.Controls.Add(this.textProdutoDesconto);
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // textProdutoDescricao
            // 
            this.textProdutoDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_DESCRICAO", true));
            this.textProdutoDescricao.Location = new System.Drawing.Point(103, 29);
            this.textProdutoDescricao.Name = "textProdutoDescricao";
            this.textProdutoDescricao.Size = new System.Drawing.Size(774, 33);
            this.textProdutoDescricao.TabIndex = 4;
            // 
            // textProdutoPreco
            // 
            this.textProdutoPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduto, "PRODUTO_PRECO_COMPRA", true));
            this.textProdutoPreco.Location = new System.Drawing.Point(391, 86);
            this.textProdutoPreco.Name = "textProdutoPreco";
            this.textProdutoPreco.Size = new System.Drawing.Size(186, 33);
            this.textProdutoPreco.TabIndex = 6;
            // 
            // textProdutoQuantidade
            // 
            this.textProdutoQuantidade.Location = new System.Drawing.Point(777, 89);
            this.textProdutoQuantidade.Name = "textProdutoQuantidade";
            this.textProdutoQuantidade.Size = new System.Drawing.Size(100, 33);
            this.textProdutoQuantidade.TabIndex = 7;
            // 
            // textProdutoDesconto
            // 
            this.textProdutoDesconto.Location = new System.Drawing.Point(116, 86);
            this.textProdutoDesconto.Name = "textProdutoDesconto";
            this.textProdutoDesconto.Size = new System.Drawing.Size(100, 33);
            this.textProdutoDesconto.TabIndex = 5;
            // 
            // pESQUISA_PRODUTO_ITEMDataGridView
            // 
            this.pESQUISA_PRODUTO_ITEMDataGridView.AllowUserToAddRows = false;
            this.pESQUISA_PRODUTO_ITEMDataGridView.AutoGenerateColumns = false;
            this.pESQUISA_PRODUTO_ITEMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_PRODUTO_ITEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_PRODUTO_ITEMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pESQUISA_PRODUTO_ITEMDataGridView.DataSource = this.bsProdutoItem;
            this.pESQUISA_PRODUTO_ITEMDataGridView.Location = new System.Drawing.Point(963, 23);
            this.pESQUISA_PRODUTO_ITEMDataGridView.Name = "pESQUISA_PRODUTO_ITEMDataGridView";
            this.pESQUISA_PRODUTO_ITEMDataGridView.ReadOnly = true;
            this.pESQUISA_PRODUTO_ITEMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_PRODUTO_ITEMDataGridView.Size = new System.Drawing.Size(952, 239);
            this.pESQUISA_PRODUTO_ITEMDataGridView.TabIndex = 9;
            // 
            // tabConclusao
            // 
            this.tabConclusao.BackColor = System.Drawing.Color.LightBlue;
            this.tabConclusao.Controls.Add(this.groupBox2);
            this.tabConclusao.Location = new System.Drawing.Point(4, 37);
            this.tabConclusao.Name = "tabConclusao";
            this.tabConclusao.Padding = new System.Windows.Forms.Padding(3);
            this.tabConclusao.Size = new System.Drawing.Size(958, 302);
            this.tabConclusao.TabIndex = 2;
            this.tabConclusao.Text = "Conclusão";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.textTotalBruto);
            this.groupBox2.Controls.Add(cOMPRA_DATALabel);
            this.groupBox2.Controls.Add(this.cOMPRA_DATADateTimePicker);
            this.groupBox2.Controls.Add(cOMPRA_DESCONTOLabel);
            this.groupBox2.Controls.Add(cOMPRA_TOTALLabel);
            this.groupBox2.Controls.Add(this.cOMPRA_DESCONTOTextBox);
            this.groupBox2.Controls.Add(this.cOMPRA_TOTALTextBox);
            this.groupBox2.Controls.Add(this.cOMPRA_ACRESCIMOTextBox);
            this.groupBox2.Controls.Add(cOMPRA_ACRESCIMOLabel);
            this.groupBox2.Location = new System.Drawing.Point(221, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 263);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // textTotalBruto
            // 
            this.textTotalBruto.Location = new System.Drawing.Point(161, 118);
            this.textTotalBruto.Name = "textTotalBruto";
            this.textTotalBruto.Size = new System.Drawing.Size(150, 33);
            this.textTotalBruto.TabIndex = 15;
            // 
            // cOMPRA_DATADateTimePicker
            // 
            this.cOMPRA_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCompra, "COMPRA_DATA", true));
            this.cOMPRA_DATADateTimePicker.Location = new System.Drawing.Point(161, 209);
            this.cOMPRA_DATADateTimePicker.Name = "cOMPRA_DATADateTimePicker";
            this.cOMPRA_DATADateTimePicker.Size = new System.Drawing.Size(372, 33);
            this.cOMPRA_DATADateTimePicker.TabIndex = 13;
            // 
            // cOMPRA_DESCONTOTextBox
            // 
            this.cOMPRA_DESCONTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_DESCONTO", true));
            this.cOMPRA_DESCONTOTextBox.Location = new System.Drawing.Point(161, 31);
            this.cOMPRA_DESCONTOTextBox.Name = "cOMPRA_DESCONTOTextBox";
            this.cOMPRA_DESCONTOTextBox.Size = new System.Drawing.Size(150, 33);
            this.cOMPRA_DESCONTOTextBox.TabIndex = 10;
            // 
            // cOMPRA_TOTALTextBox
            // 
            this.cOMPRA_TOTALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_TOTAL", true));
            this.cOMPRA_TOTALTextBox.Location = new System.Drawing.Point(161, 160);
            this.cOMPRA_TOTALTextBox.Name = "cOMPRA_TOTALTextBox";
            this.cOMPRA_TOTALTextBox.Size = new System.Drawing.Size(150, 33);
            this.cOMPRA_TOTALTextBox.TabIndex = 12;
            // 
            // cOMPRA_ACRESCIMOTextBox
            // 
            this.cOMPRA_ACRESCIMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_ACRESCIMO", true));
            this.cOMPRA_ACRESCIMOTextBox.Location = new System.Drawing.Point(161, 74);
            this.cOMPRA_ACRESCIMOTextBox.Name = "cOMPRA_ACRESCIMOTextBox";
            this.cOMPRA_ACRESCIMOTextBox.Size = new System.Drawing.Size(150, 33);
            this.cOMPRA_ACRESCIMOTextBox.TabIndex = 11;
            // 
            // cOMPRA_CODIGOLabel1
            // 
            this.cOMPRA_CODIGOLabel1.AutoSize = true;
            this.cOMPRA_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCompra, "COMPRA_CODIGO", true));
            this.cOMPRA_CODIGOLabel1.ForeColor = System.Drawing.Color.White;
            this.cOMPRA_CODIGOLabel1.Location = new System.Drawing.Point(103, 18);
            this.cOMPRA_CODIGOLabel1.Name = "cOMPRA_CODIGOLabel1";
            this.cOMPRA_CODIGOLabel1.Size = new System.Drawing.Size(68, 25);
            this.cOMPRA_CODIGOLabel1.TabIndex = 1;
            this.cOMPRA_CODIGOLabel1.Text = "código";
            // 
            // bsCompra
            // 
            this.bsCompra.DataMember = "COMPRA";
            this.bsCompra.DataSource = this.dsFROGIOS;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsProduto
            // 
            this.bsProduto.DataMember = "PRODUTO";
            this.bsProduto.DataSource = this.dsFROGIOS;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRODUTO_DESCRICAO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRODUTO_PRECO_COMPRA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ITEM_COMPRA_DESCONTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Desconto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ITEM_COMPRA_QUANTIDADE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ITEM_COMPRA_PRECO_TOTAL";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // bsProdutoItem
            // 
            this.bsProdutoItem.DataMember = "PESQUISA_PRODUTO_ITEM";
            this.bsProdutoItem.DataSource = this.dsFROGIOS;
            // 
            // bsItemCompra
            // 
            this.bsItemCompra.DataMember = "ITEM_COMPRA";
            this.bsItemCompra.DataSource = this.dsFROGIOS;
            // 
            // taCompra
            // 
            this.taCompra.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AGENDAMENTOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTE_FISICOTableAdapter = null;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = this.taCompra;
            this.tableAdapterManager.EMPRESATableAdapter = null;
            this.tableAdapterManager.FORNECEDOR_FISICOTableAdapter = null;
            this.tableAdapterManager.FORNECEDOR_JURIDICOTableAdapter = null;
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.GRUPOTableAdapter = null;
            this.tableAdapterManager.ITEM_COMPRATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_ITEMTableAdapter = null;
            this.tableAdapterManager.ORCAMENTO_SERVICOTableAdapter = null;
            this.tableAdapterManager.ORCAMENTOTableAdapter = null;
            this.tableAdapterManager.OS_ITEMTableAdapter = null;
            this.tableAdapterManager.OS_SERVICOTableAdapter = null;
            this.tableAdapterManager.OSTableAdapter = null;
            this.tableAdapterManager.PERMISSAOTableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.SECAOTableAdapter = null;
            this.tableAdapterManager.SERVICO_TIPOTableAdapter = null;
            this.tableAdapterManager.SERVICOTableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // taProduto
            // 
            this.taProduto.ClearBeforeFill = true;
            // 
            // taItemCompra
            // 
            this.taItemCompra.ClearBeforeFill = true;
            // 
            // taPesquisaProdutoItem
            // 
            this.taPesquisaProdutoItem.ClearBeforeFill = true;
            // 
            // formCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Name = "formCadastroCompra";
            this.Text = "formCadastroCompra";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.tabPai.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_PRODUTO_ITEMDataGridView)).EndInit();
            this.tabConclusao.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPai;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.TabPage tabConclusao;
        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsCompra;
        private dsFROGIOSTableAdapters.COMPRATableAdapter taCompra;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cOMPRA_NOTA_FISCALTextBox;
        private System.Windows.Forms.Label cOMPRA_CODIGOLabel1;
        private System.Windows.Forms.TextBox cOMPRA_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox cOMPRA_FUNCIONARIOTextBox;
        private System.Windows.Forms.TextBox cOMPRA_TOTALTextBox;
        private System.Windows.Forms.TextBox cOMPRA_ACRESCIMOTextBox;
        private System.Windows.Forms.TextBox cOMPRA_DESCONTOTextBox;
        private System.Windows.Forms.BindingSource bsProduto;
        private dsFROGIOSTableAdapters.PRODUTOTableAdapter taProduto;
        private System.Windows.Forms.TextBox textProdutoPreco;
        private System.Windows.Forms.TextBox textProdutoDescricao;
        private System.Windows.Forms.BindingSource bsItemCompra;
        private dsFROGIOSTableAdapters.ITEM_COMPRATableAdapter taItemCompra;
        private System.Windows.Forms.TextBox textProdutoQuantidade;
        private System.Windows.Forms.TextBox textProdutoDesconto;
        private System.Windows.Forms.BindingSource bsProdutoItem;
        private dsFROGIOSTableAdapters.taPesquisaProdutoItem taPesquisaProdutoItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonLancarProduto;
        private System.Windows.Forms.Button buttonPesquisarProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pESQUISA_PRODUTO_ITEMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker cOMPRA_DATADateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textTotalBruto;
    }
}