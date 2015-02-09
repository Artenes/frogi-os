namespace FROGI_OS.InterfaceGrafica
{
    partial class formCadastroGrupo
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
            System.Windows.Forms.Label gRUPO_CODIGOLabel;
            System.Windows.Forms.Label gRUPO_DESCRICAOLabel;
            System.Windows.Forms.Label gRUPO_DESCONTOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroGrupo));
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsGrupo = new System.Windows.Forms.BindingSource(this.components);
            this.taGrupo = new FROGI_OS.dsFROGIOSTableAdapters.GRUPOTableAdapter();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.gRUPO_CODIGOLabel1 = new System.Windows.Forms.Label();
            this.gRUPO_DESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.gRUPO_DESCONTOTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            gRUPO_CODIGOLabel = new System.Windows.Forms.Label();
            gRUPO_DESCRICAOLabel = new System.Windows.Forms.Label();
            gRUPO_DESCONTOLabel = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelCodigo.SuspendLayout();
            this.panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrupo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.Size = new System.Drawing.Size(173, 72);
            this.labelCadastro.Text = "Grupo";
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(gRUPO_CODIGOLabel);
            this.panelCodigo.Controls.Add(this.gRUPO_CODIGOLabel1);
            // 
            // panelCentro
            // 
            this.panelCentro.Controls.Add(this.groupBox1);
            // 
            // gRUPO_CODIGOLabel
            // 
            gRUPO_CODIGOLabel.AutoSize = true;
            gRUPO_CODIGOLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            gRUPO_CODIGOLabel.Location = new System.Drawing.Point(12, 8);
            gRUPO_CODIGOLabel.Name = "gRUPO_CODIGOLabel";
            gRUPO_CODIGOLabel.Size = new System.Drawing.Size(72, 25);
            gRUPO_CODIGOLabel.TabIndex = 0;
            gRUPO_CODIGOLabel.Text = "Código";
            // 
            // gRUPO_DESCRICAOLabel
            // 
            gRUPO_DESCRICAOLabel.AutoSize = true;
            gRUPO_DESCRICAOLabel.Location = new System.Drawing.Point(15, 42);
            gRUPO_DESCRICAOLabel.Name = "gRUPO_DESCRICAOLabel";
            gRUPO_DESCRICAOLabel.Size = new System.Drawing.Size(88, 25);
            gRUPO_DESCRICAOLabel.TabIndex = 2;
            gRUPO_DESCRICAOLabel.Text = "Descrição";
            // 
            // gRUPO_DESCONTOLabel
            // 
            gRUPO_DESCONTOLabel.AutoSize = true;
            gRUPO_DESCONTOLabel.Location = new System.Drawing.Point(6, 115);
            gRUPO_DESCONTOLabel.Name = "gRUPO_DESCONTOLabel";
            gRUPO_DESCONTOLabel.Size = new System.Drawing.Size(88, 25);
            gRUPO_DESCONTOLabel.TabIndex = 4;
            gRUPO_DESCONTOLabel.Text = "Desconto";
            gRUPO_DESCONTOLabel.Visible = false;
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsGrupo
            // 
            this.bsGrupo.DataMember = "GRUPO";
            this.bsGrupo.DataSource = this.dsFROGIOS;
            // 
            // taGrupo
            // 
            this.taGrupo.ClearBeforeFill = true;
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
            this.tableAdapterManager.GRUPOTableAdapter = this.taGrupo;
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
            // gRUPO_CODIGOLabel1
            // 
            this.gRUPO_CODIGOLabel1.AutoSize = true;
            this.gRUPO_CODIGOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGrupo, "GRUPO_CODIGO", true));
            this.gRUPO_CODIGOLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gRUPO_CODIGOLabel1.Location = new System.Drawing.Point(90, 8);
            this.gRUPO_CODIGOLabel1.Name = "gRUPO_CODIGOLabel1";
            this.gRUPO_CODIGOLabel1.Size = new System.Drawing.Size(68, 25);
            this.gRUPO_CODIGOLabel1.TabIndex = 1;
            this.gRUPO_CODIGOLabel1.Text = "código";
            // 
            // gRUPO_DESCRICAOTextBox
            // 
            this.gRUPO_DESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGrupo, "GRUPO_DESCRICAO", true));
            this.gRUPO_DESCRICAOTextBox.Location = new System.Drawing.Point(109, 39);
            this.gRUPO_DESCRICAOTextBox.MaxLength = 60;
            this.gRUPO_DESCRICAOTextBox.Name = "gRUPO_DESCRICAOTextBox";
            this.gRUPO_DESCRICAOTextBox.Size = new System.Drawing.Size(421, 33);
            this.gRUPO_DESCRICAOTextBox.TabIndex = 0;
            // 
            // gRUPO_DESCONTOTextBox
            // 
            this.gRUPO_DESCONTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGrupo, "GRUPO_DESCONTO", true));
            this.gRUPO_DESCONTOTextBox.Location = new System.Drawing.Point(109, 115);
            this.gRUPO_DESCONTOTextBox.MaxLength = 18;
            this.gRUPO_DESCONTOTextBox.Name = "gRUPO_DESCONTOTextBox";
            this.gRUPO_DESCONTOTextBox.Size = new System.Drawing.Size(214, 33);
            this.gRUPO_DESCONTOTextBox.TabIndex = 1;
            this.gRUPO_DESCONTOTextBox.Text = "0,00";
            this.gRUPO_DESCONTOTextBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gRUPO_DESCRICAOTextBox);
            this.groupBox1.Controls.Add(gRUPO_DESCONTOLabel);
            this.groupBox1.Controls.Add(this.gRUPO_DESCONTOTextBox);
            this.groupBox1.Controls.Add(gRUPO_DESCRICAOLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // formCadastroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastroGrupo";
            this.ShowInTaskbar = false;
            this.Text = "Grupos";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrupo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsGrupo;
        private dsFROGIOSTableAdapters.GRUPOTableAdapter taGrupo;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label gRUPO_CODIGOLabel1;
        private System.Windows.Forms.TextBox gRUPO_DESCRICAOTextBox;
        private System.Windows.Forms.TextBox gRUPO_DESCONTOTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}