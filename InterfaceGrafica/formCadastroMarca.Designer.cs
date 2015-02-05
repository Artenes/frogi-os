namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroMarca
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
            System.Windows.Forms.Label mARCA_CODIGOLabel;
            System.Windows.Forms.Label mARCA_DESCRICAOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroMarca));
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsMarca = new System.Windows.Forms.BindingSource(this.components);
            this.taMarca = new FROGI_OS.dsFROGIOSTableAdapters.MARCATableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.mARCA_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.mARCA_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            mARCA_CODIGOLabel = new System.Windows.Forms.Label();
            mARCA_DESCRICAOLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(171, 72);
            this.labelCadastro.Text = "Marca";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(mARCA_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.mARCA_CODIGOLabel1);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // mARCA_CODIGOLabel
            // 
            mARCA_CODIGOLabel.AutoSize = true;
            mARCA_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            mARCA_CODIGOLabel.Location = new System.Drawing.Point(18, 8);
            mARCA_CODIGOLabel.Name = "mARCA_CODIGOLabel";
            mARCA_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            mARCA_CODIGOLabel.TabIndex = 0;
            mARCA_CODIGOLabel.Text = "Código";
            // 
            // mARCA_DESCRICAOLabel
            // 
            mARCA_DESCRICAOLabel.AutoSize = true;
            mARCA_DESCRICAOLabel.Location = new System.Drawing.Point(15, 32);
            mARCA_DESCRICAOLabel.Name = "mARCA_DESCRICAOLabel";
            mARCA_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            mARCA_DESCRICAOLabel.TabIndex = 2;
            mARCA_DESCRICAOLabel.Text = "Descrição";
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsMarca
            // 
            this.bsMarca.DataMember = "MARCA";
            this.bsMarca.DataSource = this.dsFROGIOS;
            // 
            // taMarca
            // 
            this.taMarca.ClearBeforeFill = true;
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
            this.tableAdapterManager.MARCATableAdapter = this.taMarca;
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
            // mARCA_CODIGOLabel1
            // 
            this.mARCA_CODIGOLabel1.AutoSize = true;
            this.mARCA_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMarca, "MARCA_CODIGO", true));
            this.mARCA_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mARCA_CODIGOLabel1.Location = new System.Drawing.Point(96, 8);
            this.mARCA_CODIGOLabel1.Name = "mARCA_CODIGOLabel1";
            this.mARCA_CODIGOLabel1.Size = new System.Drawing.Size(68, 25);
            this.mARCA_CODIGOLabel1.TabIndex = 1;
            this.mARCA_CODIGOLabel1.Text = "codigo";
            // 
            // mARCA_DESCRICAOTextBox
            // 
            this.mARCA_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMarca, "MARCA_DESCRICAO", true));
            this.mARCA_DESCRICAOTextBox.Location = new System.Drawing.Point(114, 32);
            this.mARCA_DESCRICAOTextBox.MaxLength = 60;
            this.mARCA_DESCRICAOTextBox.Name = "mARCA_DESCRICAOTextBox";
            this.mARCA_DESCRICAOTextBox.Size = new System.Drawing.Size(351, 33);
            this.mARCA_DESCRICAOTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mARCA_DESCRICAOTextBox);
            this.groupBox1.Controls.Add(mARCA_DESCRICAOLabel);
            this.groupBox1.Location = new System.Drawing.Point(23, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // formCadastroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastroMarca";
            this.Text = "Marcas";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsMarca;
        private dsFROGIOSTableAdapters.MARCATableAdapter taMarca;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label mARCA_CODIGOLabel1;
        private System.Windows.Forms.TextBox mARCA_DESCRICAOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}