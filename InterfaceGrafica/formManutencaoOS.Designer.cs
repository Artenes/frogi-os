namespace FROGI_OS
{
    partial class formManutencaoOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLancarOS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textNomeTecnico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCodigoTecnico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNomeCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCodigoCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEmAndamento = new System.Windows.Forms.RadioButton();
            this.radioConcluidos = new System.Windows.Forms.RadioButton();
            this.radioAbertos = new System.Windows.Forms.RadioButton();
            this.radioLancados = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.picturePesquisar = new System.Windows.Forms.PictureBox();
            this.dataOS = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureNovoCliente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefonePesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomePesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigoPesquisa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 128);
            this.panel1.TabIndex = 0;
            // 
            // pictureFechar
            // 
            this.pictureFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFechar.Image = global::FROGI_OS.Properties.Resources.icone_fechar;
            this.pictureFechar.Location = new System.Drawing.Point(1274, 12);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(64, 61);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFechar.TabIndex = 2;
            this.pictureFechar.TabStop = false;
            this.pictureFechar.Click += new System.EventHandler(this.pictureFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 40F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manutenção OS";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.picturePesquisar);
            this.panel3.Controls.Add(this.dataOS);
            this.panel3.Controls.Add(this.pictureNovoCliente);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textTelefonePesquisa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textNomePesquisa);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textCodigoPesquisa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 128);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 602);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLancarOS);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textNomeTecnico);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textCodigoTecnico);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textNomeCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textCodigoCliente);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(961, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 347);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lançar OS";
            // 
            // buttonLancarOS
            // 
            this.buttonLancarOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarOS.Location = new System.Drawing.Point(11, 291);
            this.buttonLancarOS.Name = "buttonLancarOS";
            this.buttonLancarOS.Size = new System.Drawing.Size(354, 50);
            this.buttonLancarOS.TabIndex = 12;
            this.buttonLancarOS.Text = "Lançar OS";
            this.buttonLancarOS.UseVisualStyleBackColor = true;
            this.buttonLancarOS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Técnico responsável";
            // 
            // textNomeTecnico
            // 
            this.textNomeTecnico.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeTecnico.Location = new System.Drawing.Point(11, 251);
            this.textNomeTecnico.Name = "textNomeTecnico";
            this.textNomeTecnico.Size = new System.Drawing.Size(354, 33);
            this.textNomeTecnico.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Código";
            // 
            // textCodigoTecnico
            // 
            this.textCodigoTecnico.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoTecnico.Location = new System.Drawing.Point(11, 187);
            this.textCodigoTecnico.Name = "textCodigoTecnico";
            this.textCodigoTecnico.Size = new System.Drawing.Size(100, 33);
            this.textCodigoTecnico.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cliente";
            // 
            // textNomeCliente
            // 
            this.textNomeCliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCliente.Location = new System.Drawing.Point(11, 121);
            this.textNomeCliente.Name = "textNomeCliente";
            this.textNomeCliente.Size = new System.Drawing.Size(354, 33);
            this.textNomeCliente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código";
            // 
            // textCodigoCliente
            // 
            this.textCodigoCliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoCliente.Location = new System.Drawing.Point(11, 57);
            this.textCodigoCliente.Name = "textCodigoCliente";
            this.textCodigoCliente.Size = new System.Drawing.Size(100, 33);
            this.textCodigoCliente.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEmAndamento);
            this.groupBox1.Controls.Add(this.radioConcluidos);
            this.groupBox1.Controls.Add(this.radioAbertos);
            this.groupBox1.Controls.Add(this.radioLancados);
            this.groupBox1.Controls.Add(this.radioTodos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.groupBox1.Location = new System.Drawing.Point(961, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 93);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioEmAndamento
            // 
            this.radioEmAndamento.AutoSize = true;
            this.radioEmAndamento.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmAndamento.Location = new System.Drawing.Point(219, 20);
            this.radioEmAndamento.Name = "radioEmAndamento";
            this.radioEmAndamento.Size = new System.Drawing.Size(153, 29);
            this.radioEmAndamento.TabIndex = 4;
            this.radioEmAndamento.TabStop = true;
            this.radioEmAndamento.Text = "Em andamento";
            this.radioEmAndamento.UseVisualStyleBackColor = true;
            // 
            // radioConcluidos
            // 
            this.radioConcluidos.AutoSize = true;
            this.radioConcluidos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConcluidos.Location = new System.Drawing.Point(117, 55);
            this.radioConcluidos.Name = "radioConcluidos";
            this.radioConcluidos.Size = new System.Drawing.Size(118, 29);
            this.radioConcluidos.TabIndex = 3;
            this.radioConcluidos.TabStop = true;
            this.radioConcluidos.Text = "Concluidos";
            this.radioConcluidos.UseVisualStyleBackColor = true;
            // 
            // radioAbertos
            // 
            this.radioAbertos.AutoSize = true;
            this.radioAbertos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAbertos.Location = new System.Drawing.Point(117, 20);
            this.radioAbertos.Name = "radioAbertos";
            this.radioAbertos.Size = new System.Drawing.Size(93, 29);
            this.radioAbertos.TabIndex = 2;
            this.radioAbertos.TabStop = true;
            this.radioAbertos.Text = "Abertos";
            this.radioAbertos.UseVisualStyleBackColor = true;
            // 
            // radioLancados
            // 
            this.radioLancados.AutoSize = true;
            this.radioLancados.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLancados.Location = new System.Drawing.Point(7, 55);
            this.radioLancados.Name = "radioLancados";
            this.radioLancados.Size = new System.Drawing.Size(104, 29);
            this.radioLancados.TabIndex = 1;
            this.radioLancados.TabStop = true;
            this.radioLancados.Text = "Lançados";
            this.radioLancados.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodos.Location = new System.Drawing.Point(7, 20);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(80, 29);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // picturePesquisar
            // 
            this.picturePesquisar.Image = global::FROGI_OS.Properties.Resources.procurar;
            this.picturePesquisar.Location = new System.Drawing.Point(912, 39);
            this.picturePesquisar.Name = "picturePesquisar";
            this.picturePesquisar.Size = new System.Drawing.Size(38, 36);
            this.picturePesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePesquisar.TabIndex = 18;
            this.picturePesquisar.TabStop = false;
            // 
            // dataOS
            // 
            this.dataOS.AllowUserToAddRows = false;
            this.dataOS.AllowUserToDeleteRows = false;
            this.dataOS.AllowUserToResizeColumns = false;
            this.dataOS.AllowUserToResizeRows = false;
            this.dataOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOS.BackgroundColor = System.Drawing.Color.White;
            this.dataOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Telefone,
            this.Tecnico,
            this.Data,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataOS.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataOS.Location = new System.Drawing.Point(15, 81);
            this.dataOS.Name = "dataOS";
            this.dataOS.ReadOnly = true;
            this.dataOS.Size = new System.Drawing.Size(939, 509);
            this.dataOS.TabIndex = 17;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Tecnico
            // 
            this.Tecnico.HeaderText = "Técnico";
            this.Tecnico.Name = "Tecnico";
            this.Tecnico.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data de lançamento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // pictureNovoCliente
            // 
            this.pictureNovoCliente.Image = global::FROGI_OS.Properties.Resources.adicionar;
            this.pictureNovoCliente.Location = new System.Drawing.Point(868, 39);
            this.pictureNovoCliente.Name = "pictureNovoCliente";
            this.pictureNovoCliente.Size = new System.Drawing.Size(38, 36);
            this.pictureNovoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNovoCliente.TabIndex = 6;
            this.pictureNovoCliente.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone";
            // 
            // textTelefonePesquisa
            // 
            this.textTelefonePesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefonePesquisa.Location = new System.Drawing.Point(626, 42);
            this.textTelefonePesquisa.Name = "textTelefonePesquisa";
            this.textTelefonePesquisa.Size = new System.Drawing.Size(236, 33);
            this.textTelefonePesquisa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // textNomePesquisa
            // 
            this.textNomePesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomePesquisa.Location = new System.Drawing.Point(121, 42);
            this.textNomePesquisa.Name = "textNomePesquisa";
            this.textNomePesquisa.Size = new System.Drawing.Size(499, 33);
            this.textNomePesquisa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // textCodigoPesquisa
            // 
            this.textCodigoPesquisa.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoPesquisa.Location = new System.Drawing.Point(15, 42);
            this.textCodigoPesquisa.Name = "textCodigoPesquisa";
            this.textCodigoPesquisa.Size = new System.Drawing.Size(100, 33);
            this.textCodigoPesquisa.TabIndex = 0;
            // 
            // formManutencaoOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManutencaoOS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formClienteCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNovoCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataOS;
        private System.Windows.Forms.PictureBox pictureNovoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelefonePesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomePesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigoPesquisa;
        private System.Windows.Forms.PictureBox picturePesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEmAndamento;
        private System.Windows.Forms.RadioButton radioConcluidos;
        private System.Windows.Forms.RadioButton radioAbertos;
        private System.Windows.Forms.RadioButton radioLancados;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLancarOS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNomeTecnico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCodigoTecnico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNomeCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCodigoCliente;

    }
}