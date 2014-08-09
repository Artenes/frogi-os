namespace FROGI_OS.InterfaceGrafica
{
    partial class formNotaFiscal
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelecionarDiretorio = new System.Windows.Forms.Button();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.treePastas = new System.Windows.Forms.TreeView();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Black;
            this.panelCabecalho.Controls.Add(this.pictureFechar);
            this.panelCabecalho.Controls.Add(this.buttonSelecionarDiretorio);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 107);
            this.panelCabecalho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas fiscais";
            // 
            // buttonSelecionarDiretorio
            // 
            this.buttonSelecionarDiretorio.AutoSize = true;
            this.buttonSelecionarDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarDiretorio.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarDiretorio.Location = new System.Drawing.Point(394, 45);
            this.buttonSelecionarDiretorio.Name = "buttonSelecionarDiretorio";
            this.buttonSelecionarDiretorio.Size = new System.Drawing.Size(179, 37);
            this.buttonSelecionarDiretorio.TabIndex = 1;
            this.buttonSelecionarDiretorio.Text = "Selecionar diretório";
            this.buttonSelecionarDiretorio.UseVisualStyleBackColor = true;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(740, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(48, 48);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureFechar.TabIndex = 2;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // treePastas
            // 
            this.treePastas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePastas.Location = new System.Drawing.Point(0, 107);
            this.treePastas.Name = "treePastas";
            this.treePastas.Size = new System.Drawing.Size(800, 493);
            this.treePastas.TabIndex = 1;
            // 
            // formNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.treePastas);
            this.Controls.Add(this.panelCabecalho);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "formNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formNotaFiscal";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Button buttonSelecionarDiretorio;
        private System.Windows.Forms.TreeView treePastas;
    }
}