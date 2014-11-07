namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroSecao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
            System.Windows.Forms.Label sECAO_CODIGOLabel;
            System.Windows.Forms.Label sECAO_DESCRICAOLabel;
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsSecao = new System.Windows.Forms.BindingSource(this.components);
            this.taSecao = new FROGI_OS.dsFROGIOSTableAdapters.SECAOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.sECAO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.sECAO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            sECAO_CODIGOLabel = new System.Windows.Forms.Label();
            sECAO_DESCRICAOLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(165, 72);
            this.labelCadastro.Text = "Seção";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(sECAO_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.sECAO_CODIGOLabel1);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // sECAO_CODIGOLabel
            // 
            sECAO_CODIGOLabel.AutoSize = true;
            sECAO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            sECAO_CODIGOLabel.Location = new System.Drawing.Point(24, 8);
            sECAO_CODIGOLabel.Name = "sECAO_CODIGOLabel";
            sECAO_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            sECAO_CODIGOLabel.TabIndex = 0;
            sECAO_CODIGOLabel.Text = "Código";
            // 
            // sECAO_DESCRICAOLabel
            // 
            sECAO_DESCRICAOLabel.AutoSize = true;
            sECAO_DESCRICAOLabel.Location = new System.Drawing.Point(19, 29);
            sECAO_DESCRICAOLabel.Name = "sECAO_DESCRICAOLabel";
            sECAO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            sECAO_DESCRICAOLabel.TabIndex = 2;
            sECAO_DESCRICAOLabel.Text = "Descrição";
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsSecao
            // 
            this.bsSecao.DataMember = "SECAO";
            this.bsSecao.DataSource = this.dsFROGIOS;
            // 
            // taSecao
            // 
            this.taSecao.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AGENDAMENTOTableAdapter = null;
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
            this.tableAdapterManager.SECAOTableAdapter = this.taSecao;
            this.tableAdapterManager.SERVICO_TIPOTableAdapter = null;
            this.tableAdapterManager.SERVICOTableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // sECAO_CODIGOLabel1
            // 
            this.sECAO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSecao, "SECAO_CODIGO", true));
            this.sECAO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sECAO_CODIGOLabel1.Location = new System.Drawing.Point(102, 8);
            this.sECAO_CODIGOLabel1.Name = "sECAO_CODIGOLabel1";
            this.sECAO_CODIGOLabel1.Size = new System.Drawing.Size(100, 23);
            this.sECAO_CODIGOLabel1.TabIndex = 1;
            this.sECAO_CODIGOLabel1.Text = "código";
            // 
            // sECAO_DESCRICAOTextBox
            // 
            this.sECAO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSecao, "SECAO_DESCRICAO", true));
            this.sECAO_DESCRICAOTextBox.Location = new System.Drawing.Point(113, 26);
            this.sECAO_DESCRICAOTextBox.MaxLength = 60;
            this.sECAO_DESCRICAOTextBox.Name = "sECAO_DESCRICAOTextBox";
            this.sECAO_DESCRICAOTextBox.Size = new System.Drawing.Size(532, 33);
            this.sECAO_DESCRICAOTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sECAO_DESCRICAOLabel);
            this.groupBox1.Controls.Add(this.sECAO_DESCRICAOTextBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // formCadastroSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Name = "formCadastroSecao";
            this.Text = "formSecaoCadastro";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsSecao;
        private dsFROGIOSTableAdapters.SECAOTableAdapter taSecao;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label sECAO_CODIGOLabel1;
        private System.Windows.Forms.TextBox sECAO_DESCRICAOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}