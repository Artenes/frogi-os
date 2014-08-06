namespace FROGI_OS.InterfaceGrafica
{
    partial class formPerfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.buttonEscolherFoto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureSalvar = new System.Windows.Forms.PictureBox();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // pictureFoto
            // 
            this.pictureFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureFoto.Image = global::FROGI_OS.Properties.Resources.icone_usuario;
            this.pictureFoto.Location = new System.Drawing.Point(141, 70);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(280, 252);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 1;
            this.pictureFoto.TabStop = false;
            // 
            // buttonEscolherFoto
            // 
            this.buttonEscolherFoto.AutoSize = true;
            this.buttonEscolherFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEscolherFoto.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEscolherFoto.Location = new System.Drawing.Point(459, 182);
            this.buttonEscolherFoto.Name = "buttonEscolherFoto";
            this.buttonEscolherFoto.Size = new System.Drawing.Size(199, 44);
            this.buttonEscolherFoto.TabIndex = 2;
            this.buttonEscolherFoto.Text = "Escolher foto";
            this.buttonEscolherFoto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureSalvar);
            this.panel2.Location = new System.Drawing.Point(-22, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 74);
            this.panel2.TabIndex = 3;
            // 
            // pictureSalvar
            // 
            this.pictureSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureSalvar.Image = global::FROGI_OS.Properties.Resources.icone_salvar;
            this.pictureSalvar.Location = new System.Drawing.Point(750, 3);
            this.pictureSalvar.Name = "pictureSalvar";
            this.pictureSalvar.Size = new System.Drawing.Size(64, 64);
            this.pictureSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSalvar.TabIndex = 0;
            this.pictureSalvar.TabStop = false;
            this.pictureSalvar.Click += new System.EventHandler(this.pictureSalvar_Click);
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(742, 9);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(50, 51);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFechar.TabIndex = 1;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // formPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(804, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonEscolherFoto);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPerfil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button buttonEscolherFoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureSalvar;
        private System.Windows.Forms.PictureBox pictureFechar;
    }
}