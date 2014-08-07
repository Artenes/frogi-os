namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroAgendamento
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
            System.Windows.Forms.Label aGEN_CODIGOLabel;
            System.Windows.Forms.Label aGEN_DATALabel;
            System.Windows.Forms.Label aGEN_DESCRICAOLabel;
            System.Windows.Forms.Label label1;
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsAgendamento = new System.Windows.Forms.BindingSource(this.components);
            this.taAgendamento = new FROGI_OS.dsFROGIOSTableAdapters.AGENDAMENTOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.aGEN_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.aGEN_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aGEN_DESCRICAORichTextBox = new System.Windows.Forms.RichTextBox();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textCelular = new System.Windows.Forms.MaskedTextBox();
            aGEN_CODIGOLabel = new System.Windows.Forms.Label();
            aGEN_DATALabel = new System.Windows.Forms.Label();
            aGEN_DESCRICAOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgendamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(353, 72);
            this.labelCadastro.TabIndex = 100;
            this.labelCadastro.Text = "Agendamento";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(this.aGEN_CODIGOLabel1);
            this.panelCodigo.Controls.Add(aGEN_CODIGOLabel);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox2);
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // aGEN_CODIGOLabel
            // 
            aGEN_CODIGOLabel.AutoSize = true;
            aGEN_CODIGOLabel.ForeColor = System.Drawing.Color.White;
            aGEN_CODIGOLabel.Location = new System.Drawing.Point(29, 19);
            aGEN_CODIGOLabel.Name = "aGEN_CODIGOLabel";
            aGEN_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            aGEN_CODIGOLabel.TabIndex = 102;
            aGEN_CODIGOLabel.Text = "Código";
            // 
            // aGEN_DATALabel
            // 
            aGEN_DATALabel.AutoSize = true;
            aGEN_DATALabel.Location = new System.Drawing.Point(6, 98);
            aGEN_DATALabel.Name = "aGEN_DATALabel";
            aGEN_DATALabel.Size = new System.Drawing.Size(49, 25);
            aGEN_DATALabel.TabIndex = 4;
            aGEN_DATALabel.Text = "Data";
            // 
            // aGEN_DESCRICAOLabel
            // 
            aGEN_DESCRICAOLabel.AutoSize = true;
            aGEN_DESCRICAOLabel.Location = new System.Drawing.Point(6, 150);
            aGEN_DESCRICAOLabel.Name = "aGEN_DESCRICAOLabel";
            aGEN_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            aGEN_DESCRICAOLabel.TabIndex = 6;
            aGEN_DESCRICAOLabel.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 25);
            label1.TabIndex = 9;
            label1.Text = "Cliente";
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAgendamento
            // 
            this.bsAgendamento.DataMember = "AGENDAMENTO";
            this.bsAgendamento.DataSource = this.dsFROGIOS;
            // 
            // taAgendamento
            // 
            this.taAgendamento.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AGENDAMENTOTableAdapter = this.taAgendamento;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTE_FISICOTableAdapter = null;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = null;
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
            // aGEN_CODIGOLabel1
            // 
            this.aGEN_CODIGOLabel1.AutoSize = true;
            this.aGEN_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgendamento, "AGEN_CODIGO", true));
            this.aGEN_CODIGOLabel1.ForeColor = System.Drawing.Color.White;
            this.aGEN_CODIGOLabel1.Location = new System.Drawing.Point(107, 19);
            this.aGEN_CODIGOLabel1.Name = "aGEN_CODIGOLabel1";
            this.aGEN_CODIGOLabel1.Size = new System.Drawing.Size(72, 25);
            this.aGEN_CODIGOLabel1.TabIndex = 101;
            this.aGEN_CODIGOLabel1.Text = "Codigo";
            // 
            // aGEN_DATADateTimePicker
            // 
            this.aGEN_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsAgendamento, "AGEN_DATA", true));
            this.aGEN_DATADateTimePicker.Location = new System.Drawing.Point(109, 92);
            this.aGEN_DATADateTimePicker.Name = "aGEN_DATADateTimePicker";
            this.aGEN_DATADateTimePicker.Size = new System.Drawing.Size(546, 33);
            this.aGEN_DATADateTimePicker.TabIndex = 1;
            // 
            // aGEN_DESCRICAORichTextBox
            // 
            this.aGEN_DESCRICAORichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgendamento, "AGEN_DESCRICAO", true));
            this.aGEN_DESCRICAORichTextBox.Location = new System.Drawing.Point(109, 150);
            this.aGEN_DESCRICAORichTextBox.Name = "aGEN_DESCRICAORichTextBox";
            this.aGEN_DESCRICAORichTextBox.Size = new System.Drawing.Size(546, 149);
            this.aGEN_DESCRICAORichTextBox.TabIndex = 2;
            this.aGEN_DESCRICAORichTextBox.Text = "";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(109, 40);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(546, 33);
            this.textCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.aGEN_DESCRICAORichTextBox);
            this.groupBox1.Controls.Add(this.textCliente);
            this.groupBox1.Controls.Add(aGEN_DESCRICAOLabel);
            this.groupBox1.Controls.Add(aGEN_DATALabel);
            this.groupBox1.Controls.Add(this.aGEN_DATADateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(34, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCelular);
            this.groupBox2.Controls.Add(this.textTelefone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(758, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Celular";
            // 
            // textTelefone
            // 
            this.textTelefone.Enabled = false;
            this.textTelefone.Location = new System.Drawing.Point(11, 65);
            this.textTelefone.Mask = "(##)####-####";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(133, 33);
            this.textTelefone.TabIndex = 2;
            // 
            // textCelular
            // 
            this.textCelular.Enabled = false;
            this.textCelular.Location = new System.Drawing.Point(11, 134);
            this.textCelular.Mask = "(##)####-####";
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(133, 33);
            this.textCelular.TabIndex = 3;
            // 
            // formCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Name = "formCadastroAgendamento";
            this.Text = "formCadastroAgendamento";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgendamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsAgendamento;
        private dsFROGIOSTableAdapters.AGENDAMENTOTableAdapter taAgendamento;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label aGEN_CODIGOLabel1;
        private System.Windows.Forms.DateTimePicker aGEN_DATADateTimePicker;
        private System.Windows.Forms.RichTextBox aGEN_DESCRICAORichTextBox;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textCelular;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}