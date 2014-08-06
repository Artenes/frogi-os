namespace FROGI_OS.InterfaceGrafica
{
    partial class formPesquisaOrcamento
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
            this.dsFROGIOS = new FROGI_OS.dsFROGIOS();
            this.bsPesquisaFisico = new System.Windows.Forms.BindingSource(this.components);
            this.taPesquisaOrcamentoFisico = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaOrcamentoFisico();
            this.tableAdapterManager = new FROGI_OS.dsFROGIOSTableAdapters.TableAdapterManager();
            this.pESQUISA_ORCAMENTO_FISICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPesquisaJuridico = new System.Windows.Forms.BindingSource(this.components);
            this.taPesquisaOrcamentoJuridico = new FROGI_OS.dsFROGIOSTableAdapters.taPesquisaOrcamentoJuridico();
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCabecalho.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.tablessPai.SuspendLayout();
            this.tabFisico.SuspendLayout();
            this.tabJuridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisaFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_ORCAMENTO_FISICODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisaJuridico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_ORCAMENTO_JURIDICODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.labelPesquisa.Location = new System.Drawing.Point(12, 37);
            this.labelPesquisa.Size = new System.Drawing.Size(145, 37);
            this.labelPesquisa.Text = "Orçamento";
            // 
            // buttonNovoRegistro
            // 
            this.buttonNovoRegistro.Text = "Novo orçamento";
            // 
            // tabFisico
            // 
            this.tabFisico.AutoScroll = true;
            this.tabFisico.Controls.Add(this.pESQUISA_ORCAMENTO_FISICODataGridView);
            // 
            // tabJuridico
            // 
            this.tabJuridico.Controls.Add(this.pESQUISA_ORCAMENTO_JURIDICODataGridView);
            // 
            // dsFROGIOS
            // 
            this.dsFROGIOS.DataSetName = "dsFROGIOS";
            this.dsFROGIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsPesquisaFisico
            // 
            this.bsPesquisaFisico.DataMember = "PESQUISA_ORCAMENTO_FISICO";
            this.bsPesquisaFisico.DataSource = this.dsFROGIOS;
            // 
            // taPesquisaOrcamentoFisico
            // 
            this.taPesquisaOrcamentoFisico.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTE_FISICOTableAdapter = null;
            this.tableAdapterManager.CLIENTE_JURIDICOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRATableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // pESQUISA_ORCAMENTO_FISICODataGridView
            // 
            this.pESQUISA_ORCAMENTO_FISICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pESQUISA_ORCAMENTO_FISICODataGridView.DataSource = this.bsPesquisaFisico;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_ORCAMENTO_FISICODataGridView.Name = "pESQUISA_ORCAMENTO_FISICODataGridView";
            this.pESQUISA_ORCAMENTO_FISICODataGridView.ReadOnly = true;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_ORCAMENTO_FISICODataGridView.Size = new System.Drawing.Size(770, 347);
            this.pESQUISA_ORCAMENTO_FISICODataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ORCAMENTO_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENTE_FISICO_NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE_TELEFONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CLIENTE_CELULAR";
            this.dataGridViewTextBoxColumn6.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FUNCIONARIO_NOME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ORCAMENTO_DATA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // bsPesquisaJuridico
            // 
            this.bsPesquisaJuridico.DataMember = "PESQUISA_ORCAMENTO_JURIDICO";
            this.bsPesquisaJuridico.DataSource = this.dsFROGIOS;
            // 
            // taPesquisaOrcamentoJuridico
            // 
            this.taPesquisaOrcamentoJuridico.ClearBeforeFill = true;
            // 
            // pESQUISA_ORCAMENTO_JURIDICODataGridView
            // 
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.AllowUserToAddRows = false;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.AllowUserToDeleteRows = false;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.AutoGenerateColumns = false;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.DataSource = this.bsPesquisaJuridico;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.Location = new System.Drawing.Point(3, 3);
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.Name = "pESQUISA_ORCAMENTO_JURIDICODataGridView";
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.ReadOnly = true;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.Size = new System.Drawing.Size(770, 347);
            this.pESQUISA_ORCAMENTO_JURIDICODataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ORCAMENTO_CODIGO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CLIENTE_JURIDICO_FANTASIA";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CLIENTE_TELEFONE";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CLIENTE_CELULAR";
            this.dataGridViewTextBoxColumn10.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FUNCIONARIO_NOME";
            this.dataGridViewTextBoxColumn11.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ORCAMENTO_DATA";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // formPesquisaOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Name = "formPesquisaOrcamento";
            this.Text = "formPesquisaOrcamento";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelRodape.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.tablessPai.ResumeLayout(false);
            this.tabFisico.ResumeLayout(false);
            this.tabJuridico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFROGIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisaFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_ORCAMENTO_FISICODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPesquisaJuridico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESQUISA_ORCAMENTO_JURIDICODataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsFROGIOS dsFROGIOS;
        private System.Windows.Forms.BindingSource bsPesquisaFisico;
        private dsFROGIOSTableAdapters.taPesquisaOrcamentoFisico taPesquisaOrcamentoFisico;
        private dsFROGIOSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pESQUISA_ORCAMENTO_FISICODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bsPesquisaJuridico;
        private dsFROGIOSTableAdapters.taPesquisaOrcamentoJuridico taPesquisaOrcamentoJuridico;
        private System.Windows.Forms.DataGridView pESQUISA_ORCAMENTO_JURIDICODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}