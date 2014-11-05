namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroTipo : formCadastro
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
            System.Windows.Forms.Label tIPO_CODIGOLabel;
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsTipo = new System.Windows.Forms.BindingSource(this.components);
            this.taTipo = new FROGI_OS.dsFROGIOSTableAdapters.TIPOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.tIPO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.tIPO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            tIPO_CODIGOLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(371, 72);
            this.labelCadastro.Text = "Tipo de serviço";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(tIPO_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.tIPO_CODIGOLabel1);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // tIPO_CODIGOLabel
            // 
            tIPO_CODIGOLabel.AutoSize = true;
            tIPO_CODIGOLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tIPO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tIPO_CODIGOLabel.Location = new System.Drawing.Point(12, 8);
            tIPO_CODIGOLabel.Name = "tIPO_CODIGOLabel";
            tIPO_CODIGOLabel.Size = new System.Drawing.Size(87, 32);
            tIPO_CODIGOLabel.TabIndex = 0;
            tIPO_CODIGOLabel.Text = "Código";
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsTipo
            // 
            this.bsTipo.DataMember = "TIPO";
            this.bsTipo.DataSource = this.dsFROGIOS;
            // 
            // taTipo
            // 
            this.taTipo.ClearBeforeFill = true;
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
            this.tableAdapterManager.SECAOTableAdapter = null;
            this.tableAdapterManager.SERVICO_TIPOTableAdapter = null;
            this.tableAdapterManager.SERVICOTableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = this.taTipo;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // tIPO_CODIGOLabel1
            // 
            this.tIPO_CODIGOLabel1.AutoSize = true;
            this.tIPO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTipo, "TIPO_CODIGO", true));
            this.tIPO_CODIGOLabel1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIPO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tIPO_CODIGOLabel1.Location = new System.Drawing.Point(105, 8);
            this.tIPO_CODIGOLabel1.Name = "tIPO_CODIGOLabel1";
            this.tIPO_CODIGOLabel1.Size = new System.Drawing.Size(87, 32);
            this.tIPO_CODIGOLabel1.TabIndex = 1;
            this.tIPO_CODIGOLabel1.Text = "Código";
            // 
            // tIPO_DESCRICAOTextBox
            // 
            this.tIPO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTipo, "TIPO_DESCRICAO", true));
            this.tIPO_DESCRICAOTextBox.Location = new System.Drawing.Point(24, 43);
            this.tIPO_DESCRICAOTextBox.Name = "tIPO_DESCRICAOTextBox";
            this.tIPO_DESCRICAOTextBox.Size = new System.Drawing.Size(413, 33);
            this.tIPO_DESCRICAOTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tIPO_DESCRICAOTextBox);
            this.groupBox1.Location = new System.Drawing.Point(30, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // formCadastroTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Name = "formCadastroTipo";
            this.Text = "formTipoCadastro";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsTipo;
        private dsFROGIOSTableAdapters.TIPOTableAdapter taTipo;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label tIPO_CODIGOLabel1;
        private System.Windows.Forms.TextBox tIPO_DESCRICAOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}