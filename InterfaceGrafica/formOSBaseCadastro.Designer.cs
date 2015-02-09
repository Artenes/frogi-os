namespace FROGI_OS.InterfaceGrafica
{
    partial class formOSBaseCadastro
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
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.labelBase = new System.Windows.Forms.Label();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.tabPai = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.panelGeral = new System.Windows.Forms.Panel();
            this.tabInfoItem = new System.Windows.Forms.TabPage();
            this.panelInfoItem = new System.Windows.Forms.Panel();
            this.tabPecas = new System.Windows.Forms.TabPage();
            this.panelPecas = new System.Windows.Forms.Panel();
            this.tabServicos = new System.Windows.Forms.TabPage();
            this.panelServicos = new System.Windows.Forms.Panel();
            this.tabDiagnostico = new System.Windows.Forms.TabPage();
            this.panelDiagnostico = new System.Windows.Forms.Panel();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEditar = new System.Windows.Forms.PictureBox();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.tabPai.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.tabInfoItem.SuspendLayout();
            this.tabPecas.SuspendLayout();
            this.tabServicos.SuspendLayout();
            this.tabDiagnostico.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.panelCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.labelBase);
            this.panelCabecalho.Controls.Add(this.pictureFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 100);
            this.panelCabecalho.TabIndex = 0;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Font = new System.Drawing.Font("Segoe UI Light", 35F);
            this.labelBase.ForeColor = System.Drawing.Color.White;
            this.labelBase.Location = new System.Drawing.Point(12, 12);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(118, 62);
            this.labelBase.TabIndex = 1;
            this.labelBase.Text = "Base";
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(730, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(58, 50);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFechar.TabIndex = 0;
            this.pictureFechar.TabStop = false;
            this.toolTip.SetToolTip(this.pictureFechar, "Fechar janela [Alt+F4]");
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // tabPai
            // 
            this.tabPai.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPai.Controls.Add(this.tabGeral);
            this.tabPai.Controls.Add(this.tabInfoItem);
            this.tabPai.Controls.Add(this.tabPecas);
            this.tabPai.Controls.Add(this.tabServicos);
            this.tabPai.Controls.Add(this.tabDiagnostico);
            this.tabPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPai.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPai.Location = new System.Drawing.Point(0, 100);
            this.tabPai.Name = "tabPai";
            this.tabPai.SelectedIndex = 0;
            this.tabPai.Size = new System.Drawing.Size(800, 421);
            this.tabPai.TabIndex = 1;
            // 
            // tabGeral
            // 
            this.tabGeral.BackColor = System.Drawing.Color.LightBlue;
            this.tabGeral.Controls.Add(this.panelGeral);
            this.tabGeral.Location = new System.Drawing.Point(4, 37);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(792, 380);
            this.tabGeral.TabIndex = 4;
            this.tabGeral.Text = "Geral";
            // 
            // panelGeral
            // 
            this.panelGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeral.Location = new System.Drawing.Point(3, 3);
            this.panelGeral.Margin = new System.Windows.Forms.Padding(0);
            this.panelGeral.Name = "panelGeral";
            this.panelGeral.Size = new System.Drawing.Size(786, 374);
            this.panelGeral.TabIndex = 0;
            // 
            // tabInfoItem
            // 
            this.tabInfoItem.BackColor = System.Drawing.Color.LightBlue;
            this.tabInfoItem.Controls.Add(this.panelInfoItem);
            this.tabInfoItem.Location = new System.Drawing.Point(4, 37);
            this.tabInfoItem.Name = "tabInfoItem";
            this.tabInfoItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoItem.Size = new System.Drawing.Size(792, 380);
            this.tabInfoItem.TabIndex = 0;
            this.tabInfoItem.Text = "Informações do item";
            // 
            // panelInfoItem
            // 
            this.panelInfoItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoItem.Location = new System.Drawing.Point(3, 3);
            this.panelInfoItem.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfoItem.Name = "panelInfoItem";
            this.panelInfoItem.Size = new System.Drawing.Size(786, 374);
            this.panelInfoItem.TabIndex = 0;
            // 
            // tabPecas
            // 
            this.tabPecas.BackColor = System.Drawing.Color.LightBlue;
            this.tabPecas.Controls.Add(this.panelPecas);
            this.tabPecas.Location = new System.Drawing.Point(4, 37);
            this.tabPecas.Name = "tabPecas";
            this.tabPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPecas.Size = new System.Drawing.Size(792, 380);
            this.tabPecas.TabIndex = 1;
            this.tabPecas.Text = "Peças";
            // 
            // panelPecas
            // 
            this.panelPecas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPecas.Location = new System.Drawing.Point(3, 3);
            this.panelPecas.Margin = new System.Windows.Forms.Padding(0);
            this.panelPecas.Name = "panelPecas";
            this.panelPecas.Size = new System.Drawing.Size(786, 374);
            this.panelPecas.TabIndex = 0;
            // 
            // tabServicos
            // 
            this.tabServicos.BackColor = System.Drawing.Color.LightBlue;
            this.tabServicos.Controls.Add(this.panelServicos);
            this.tabServicos.Location = new System.Drawing.Point(4, 37);
            this.tabServicos.Name = "tabServicos";
            this.tabServicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicos.Size = new System.Drawing.Size(792, 380);
            this.tabServicos.TabIndex = 2;
            this.tabServicos.Text = "Serviços";
            // 
            // panelServicos
            // 
            this.panelServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServicos.Location = new System.Drawing.Point(3, 3);
            this.panelServicos.Margin = new System.Windows.Forms.Padding(0);
            this.panelServicos.Name = "panelServicos";
            this.panelServicos.Size = new System.Drawing.Size(786, 374);
            this.panelServicos.TabIndex = 0;
            // 
            // tabDiagnostico
            // 
            this.tabDiagnostico.BackColor = System.Drawing.Color.LightBlue;
            this.tabDiagnostico.Controls.Add(this.panelDiagnostico);
            this.tabDiagnostico.Location = new System.Drawing.Point(4, 37);
            this.tabDiagnostico.Name = "tabDiagnostico";
            this.tabDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnostico.Size = new System.Drawing.Size(792, 380);
            this.tabDiagnostico.TabIndex = 3;
            this.tabDiagnostico.Text = "Diagnóstico";
            // 
            // panelDiagnostico
            // 
            this.panelDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiagnostico.Location = new System.Drawing.Point(3, 3);
            this.panelDiagnostico.Margin = new System.Windows.Forms.Padding(0);
            this.panelDiagnostico.Name = "panelDiagnostico";
            this.panelDiagnostico.Size = new System.Drawing.Size(786, 374);
            this.panelDiagnostico.TabIndex = 0;
            // 
            // panelRodape
            // 
            this.panelRodape.BackColor = System.Drawing.Color.Black;
            this.panelRodape.Controls.Add(this.panelCodigo);
            this.panelRodape.Controls.Add(this.pictureEditar);
            this.panelRodape.Controls.Add(this.pictureExcluir);
            this.panelRodape.Controls.Add(this.pictureSalvar);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRodape.Location = new System.Drawing.Point(0, 521);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(800, 79);
            this.panelRodape.TabIndex = 2;
            // 
            // panelCodigo
            // 
            this.panelCodigo.Controls.Add(this.labelCodigo);
            this.panelCodigo.Controls.Add(this.label1);
            this.panelCodigo.Location = new System.Drawing.Point(23, 6);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(408, 64);
            this.panelCodigo.TabIndex = 14;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCodigo.Location = new System.Drawing.Point(102, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(72, 25);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // pictureEditar
            // 
            this.pictureEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEditar.Image = global::FROGI_OS.Properties.Resources.icone_editar;
            this.pictureEditar.Location = new System.Drawing.Point(584, 6);
            this.pictureEditar.Name = "pictureEditar";
            this.pictureEditar.Size = new System.Drawing.Size(64, 64);
            this.pictureEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEditar.TabIndex = 13;
            this.pictureEditar.TabStop = false;
            this.toolTip.SetToolTip(this.pictureEditar, "Editar registro [Ctrl+E]");
            this.pictureEditar.Click += new System.EventHandler(this.pictureEditar_Click);
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureExcluir.Image = global::FROGI_OS.Properties.Resources.icone_excluir;
            this.pictureExcluir.Location = new System.Drawing.Point(654, 6);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(64, 64);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 12;
            this.pictureExcluir.TabStop = false;
            this.toolTip.SetToolTip(this.pictureExcluir, "Excluir registro [Ctrl+D]");
            this.pictureExcluir.Click += new System.EventHandler(this.pictureExcluir_Click);
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(724, 6);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSalvar.TabIndex = 11;
            this.pictureSalvar.TabStop = false;
            this.toolTip.SetToolTip(this.pictureSalvar, "Salvar registro [Ctrl+S]");
            this.pictureSalvar.Click += new System.EventHandler(this.pictureSalvar_Click);
            // 
            // formOSBaseCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabPai);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.panelRodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOSBaseCadastro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCadastroOrcamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formOSBase_FormClosing);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.tabPai.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabInfoItem.ResumeLayout(false);
            this.tabPecas.ResumeLayout(false);
            this.tabServicos.ResumeLayout(false);
            this.tabDiagnostico.ResumeLayout(false);
            this.panelRodape.ResumeLayout(false);
            this.panelCodigo.ResumeLayout(false);
            this.panelCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelCabecalho;
        protected System.Windows.Forms.PictureBox pictureFechar;
        protected System.Windows.Forms.TabControl tabPai;
        protected System.Windows.Forms.TabPage tabInfoItem;
        protected System.Windows.Forms.TabPage tabPecas;
        protected System.Windows.Forms.TabPage tabServicos;
        protected System.Windows.Forms.TabPage tabDiagnostico;
        protected System.Windows.Forms.TabPage tabGeral;
        protected System.Windows.Forms.Label labelBase;
        protected System.Windows.Forms.Panel panelGeral;
        protected System.Windows.Forms.Panel panelInfoItem;
        protected System.Windows.Forms.Panel panelPecas;
        protected System.Windows.Forms.Panel panelServicos;
        protected System.Windows.Forms.Panel panelDiagnostico;
        protected System.Windows.Forms.Panel panelRodape;
        protected System.Windows.Forms.PictureBox pictureEditar;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.PictureBox pictureSalvar;
        protected System.Windows.Forms.Panel panelCodigo;
        protected System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}