namespace MemoryDumper
{
    partial class Form1
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
            this.btnLer = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExtensao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProcesso = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArquivoTexto = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Texto = new System.Windows.Forms.TabPage();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.Tabela = new System.Windows.Forms.TabPage();
            this.dgvMemoria = new System.Windows.Forms.DataGridView();
            this.chkTranspor = new System.Windows.Forms.CheckBox();
            this.chkMatriz = new System.Windows.Forms.CheckBox();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.numLinhas = new System.Windows.Forms.NumericUpDown();
            this.numColunas = new System.Windows.Forms.NumericUpDown();
            this.lblColunas = new System.Windows.Forms.Label();
            this.numExtensao = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Texto.SuspendLayout();
            this.Tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtensao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(948, 14);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 72);
            this.btnLer.TabIndex = 7;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEndereco.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.Location = new System.Drawing.Point(118, 40);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(619, 22);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.Text = "0x14df9260";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Endereço:";
            // 
            // lblExtensao
            // 
            this.lblExtensao.AutoSize = true;
            this.lblExtensao.Location = new System.Drawing.Point(347, 68);
            this.lblExtensao.Name = "lblExtensao";
            this.lblExtensao.Size = new System.Drawing.Size(54, 13);
            this.lblExtensao.TabIndex = 4;
            this.lblExtensao.Text = "Extensão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do processo:";
            // 
            // txtNomeProcesso
            // 
            this.txtNomeProcesso.Location = new System.Drawing.Point(118, 14);
            this.txtNomeProcesso.Name = "txtNomeProcesso";
            this.txtNomeProcesso.Size = new System.Drawing.Size(824, 20);
            this.txtNomeProcesso.TabIndex = 0;
            this.txtNomeProcesso.Text = "MLP-armadillo-openblas";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(948, 453);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arquivo de texto:";
            // 
            // txtArquivoTexto
            // 
            this.txtArquivoTexto.Location = new System.Drawing.Point(106, 454);
            this.txtArquivoTexto.Name = "txtArquivoTexto";
            this.txtArquivoTexto.Size = new System.Drawing.Size(836, 20);
            this.txtArquivoTexto.TabIndex = 8;
            this.txtArquivoTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArquivoTexto_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Texto);
            this.tabControl1.Controls.Add(this.Tabela);
            this.tabControl1.Location = new System.Drawing.Point(16, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 356);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Texto
            // 
            this.Texto.Controls.Add(this.txtMemoria);
            this.Texto.Location = new System.Drawing.Point(4, 22);
            this.Texto.Name = "Texto";
            this.Texto.Padding = new System.Windows.Forms.Padding(3);
            this.Texto.Size = new System.Drawing.Size(999, 330);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "Texto";
            this.Texto.UseVisualStyleBackColor = true;
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(0, 0);
            this.txtMemoria.Multiline = true;
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemoria.Size = new System.Drawing.Size(999, 330);
            this.txtMemoria.TabIndex = 9;
            this.txtMemoria.TabStop = false;
            this.txtMemoria.TextChanged += new System.EventHandler(this.txtMemoria_TextChanged);
            // 
            // Tabela
            // 
            this.Tabela.Controls.Add(this.dgvMemoria);
            this.Tabela.Location = new System.Drawing.Point(4, 22);
            this.Tabela.Name = "Tabela";
            this.Tabela.Padding = new System.Windows.Forms.Padding(3);
            this.Tabela.Size = new System.Drawing.Size(999, 330);
            this.Tabela.TabIndex = 1;
            this.Tabela.Text = "Tabela";
            this.Tabela.UseVisualStyleBackColor = true;
            // 
            // dgvMemoria
            // 
            this.dgvMemoria.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvMemoria.AllowUserToAddRows = false;
            this.dgvMemoria.AllowUserToDeleteRows = false;
            this.dgvMemoria.AllowUserToResizeColumns = false;
            this.dgvMemoria.AllowUserToResizeRows = false;
            this.dgvMemoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemoria.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMemoria.Location = new System.Drawing.Point(3, 3);
            this.dgvMemoria.Name = "dgvMemoria";
            this.dgvMemoria.ReadOnly = true;
            this.dgvMemoria.RowHeadersWidth = 90;
            this.dgvMemoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMemoria.Size = new System.Drawing.Size(993, 324);
            this.dgvMemoria.TabIndex = 0;
            this.dgvMemoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMemoria_CellFormatting);
            this.dgvMemoria.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvMemoria_ColumnAdded);
            this.dgvMemoria.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMemoria_RowsAdded);
            // 
            // chkTranspor
            // 
            this.chkTranspor.AutoSize = true;
            this.chkTranspor.Location = new System.Drawing.Point(110, 94);
            this.chkTranspor.Name = "chkTranspor";
            this.chkTranspor.Size = new System.Drawing.Size(74, 17);
            this.chkTranspor.TabIndex = 10;
            this.chkTranspor.Text = "Tranposto";
            this.chkTranspor.UseVisualStyleBackColor = true;
            this.chkTranspor.Visible = false;
            this.chkTranspor.CheckedChanged += new System.EventHandler(this.chkTranspor_CheckedChanged);
            // 
            // chkMatriz
            // 
            this.chkMatriz.AutoSize = true;
            this.chkMatriz.Location = new System.Drawing.Point(795, 42);
            this.chkMatriz.Name = "chkMatriz";
            this.chkMatriz.Size = new System.Drawing.Size(64, 17);
            this.chkMatriz.TabIndex = 2;
            this.chkMatriz.Text = "É Matriz";
            this.chkMatriz.UseVisualStyleBackColor = true;
            this.chkMatriz.CheckedChanged += new System.EventHandler(this.chkMatriz_CheckedChanged);
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Enabled = false;
            this.lblLinhas.Location = new System.Drawing.Point(619, 69);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(41, 13);
            this.lblLinhas.TabIndex = 14;
            this.lblLinhas.Text = "Linhas:";
            // 
            // numLinhas
            // 
            this.numLinhas.Enabled = false;
            this.numLinhas.Location = new System.Drawing.Point(666, 67);
            this.numLinhas.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numLinhas.Name = "numLinhas";
            this.numLinhas.Size = new System.Drawing.Size(108, 20);
            this.numLinhas.TabIndex = 5;
            this.numLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLinhas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numColunas
            // 
            this.numColunas.Enabled = false;
            this.numColunas.Location = new System.Drawing.Point(834, 67);
            this.numColunas.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numColunas.Name = "numColunas";
            this.numColunas.Size = new System.Drawing.Size(108, 20);
            this.numColunas.TabIndex = 6;
            this.numColunas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numColunas.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Enabled = false;
            this.lblColunas.Location = new System.Drawing.Point(780, 69);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(48, 13);
            this.lblColunas.TabIndex = 16;
            this.lblColunas.Text = "Colunas:";
            // 
            // numExtensao
            // 
            this.numExtensao.Location = new System.Drawing.Point(407, 66);
            this.numExtensao.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numExtensao.Name = "numExtensao";
            this.numExtensao.Size = new System.Drawing.Size(179, 20);
            this.numExtensao.TabIndex = 4;
            this.numExtensao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tamanho de cada elemento:";
            // 
            // cboTamanho
            // 
            this.cboTamanho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTamanho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Items.AddRange(new object[] {
            "1 byte",
            "2 bytes",
            "4 bytes",
            "8 bytes"});
            this.cboTamanho.Location = new System.Drawing.Point(164, 65);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(137, 21);
            this.cboTamanho.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 487);
            this.Controls.Add(this.cboTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numExtensao);
            this.Controls.Add(this.numColunas);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.numLinhas);
            this.Controls.Add(this.lblLinhas);
            this.Controls.Add(this.chkMatriz);
            this.Controls.Add(this.chkTranspor);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArquivoTexto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeProcesso);
            this.Controls.Add(this.lblExtensao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnLer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Texto.ResumeLayout(false);
            this.Texto.PerformLayout();
            this.Tabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtensao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExtensao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProcesso;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArquivoTexto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Texto;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.TabPage Tabela;
        private System.Windows.Forms.DataGridView dgvMemoria;
        private System.Windows.Forms.CheckBox chkTranspor;
        private System.Windows.Forms.CheckBox chkMatriz;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.NumericUpDown numLinhas;
        private System.Windows.Forms.NumericUpDown numColunas;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.NumericUpDown numExtensao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTamanho;
    }
}

