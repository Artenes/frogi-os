namespace FROGI_OS.InterfaceGrafica
{
    partial class formMenuPopUp
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
            this.linkLogOff = new System.Windows.Forms.LinkLabel();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.linkSair = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLogOff
            // 
            this.linkLogOff.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.linkLogOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLogOff.AutoSize = true;
            this.linkLogOff.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogOff.LinkColor = System.Drawing.Color.LavenderBlush;
            this.linkLogOff.Location = new System.Drawing.Point(52, 37);
            this.linkLogOff.Name = "linkLogOff";
            this.linkLogOff.Size = new System.Drawing.Size(67, 25);
            this.linkLogOff.TabIndex = 0;
            this.linkLogOff.TabStop = true;
            this.linkLogOff.Text = "LogOff";
            this.linkLogOff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOff_LinkClicked);
            // 
            // linkPerfil
            // 
            this.linkPerfil.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.linkPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPerfil.LinkColor = System.Drawing.Color.LavenderBlush;
            this.linkPerfil.Location = new System.Drawing.Point(59, 103);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(51, 25);
            this.linkPerfil.TabIndex = 1;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // linkSair
            // 
            this.linkSair.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.linkSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSair.AutoSize = true;
            this.linkSair.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSair.LinkColor = System.Drawing.Color.LavenderBlush;
            this.linkSair.Location = new System.Drawing.Point(65, 160);
            this.linkSair.Name = "linkSair";
            this.linkSair.Size = new System.Drawing.Size(40, 25);
            this.linkSair.TabIndex = 2;
            this.linkSair.TabStop = true;
            this.linkSair.Text = "Sair";
            this.linkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSair_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-10, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 10);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-10, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureFechar);
            this.panel3.Location = new System.Drawing.Point(-10, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 43);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(-10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 23);
            this.panel4.TabIndex = 5;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(13, 3);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(30, 30);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFechar.TabIndex = 0;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // formMenuPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(2)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(172, 235);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkSair);
            this.Controls.Add(this.linkPerfil);
            this.Controls.Add(this.linkLogOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMenuPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formMenuPopUp";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogOff;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.LinkLabel linkSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureFechar;
    }
}