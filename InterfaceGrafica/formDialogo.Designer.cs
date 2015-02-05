namespace FROGI_OS {
    partial class formDialogo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDialogo));
            this.tablePai = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSim = new System.Windows.Forms.Button();
            this.labelExpressao = new System.Windows.Forms.Label();
            this.buttonNao = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tablePai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePai
            // 
            this.tablePai.ColumnCount = 2;
            this.tablePai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablePai.Controls.Add(this.buttonSim, 1, 1);
            this.tablePai.Controls.Add(this.labelExpressao, 0, 0);
            this.tablePai.Controls.Add(this.buttonNao, 0, 1);
            this.tablePai.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tablePai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePai.Location = new System.Drawing.Point(0, 0);
            this.tablePai.Name = "tablePai";
            this.tablePai.RowCount = 2;
            this.tablePai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tablePai.Size = new System.Drawing.Size(584, 262);
            this.tablePai.TabIndex = 0;
            // 
            // buttonSim
            // 
            this.buttonSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSim.AutoSize = true;
            this.buttonSim.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSim.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSim.ForeColor = System.Drawing.Color.Black;
            this.buttonSim.Location = new System.Drawing.Point(236, 200);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(345, 44);
            this.buttonSim.TabIndex = 0;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = false;
            // 
            // labelExpressao
            // 
            this.labelExpressao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExpressao.AutoSize = true;
            this.labelExpressao.Font = new System.Drawing.Font("Segoe UI Light", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpressao.Location = new System.Drawing.Point(3, 0);
            this.labelExpressao.Name = "labelExpressao";
            this.labelExpressao.Size = new System.Drawing.Size(227, 183);
            this.labelExpressao.TabIndex = 40;
            this.labelExpressao.Text = ":|";
            this.labelExpressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNao
            // 
            this.buttonNao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNao.AutoSize = true;
            this.buttonNao.BackColor = System.Drawing.Color.LightCoral;
            this.buttonNao.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNao.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNao.Location = new System.Drawing.Point(3, 200);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(227, 44);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelDescricao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(233, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 183);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescricao.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(3, 91);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(345, 92);
            this.labelDescricao.TabIndex = 22;
            this.labelDescricao.Text = "Informações";
            this.labelDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(345, 91);
            this.labelTitulo.TabIndex = 21;
            this.labelTitulo.Text = "Informações";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.tablePai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDialogo";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção";
            this.TransparencyKey = System.Drawing.Color.White;
            this.tablePai.ResumeLayout(false);
            this.tablePai.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePai;
        private System.Windows.Forms.Label labelExpressao;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelTitulo;
    }
}