namespace MeusSitesInteressantes
{
    partial class frmSites
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
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthttp = new System.Windows.Forms.TextBox();
            this.dgwsitesint = new System.Windows.Forms.DataGridView();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.picSite = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnimagem = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasteMenuHereStrip = new System.Windows.Forms.MenuStrip();
            this.btntipo = new System.Windows.Forms.Button();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.cboestudado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbofiltro = new System.Windows.Forms.ComboBox();
            this.btnteste = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.http = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwsitesint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(629, 353);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 0;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(710, 353);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 1;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(791, 353);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(873, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Http";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1134, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // txthttp
            // 
            this.txthttp.AllowDrop = true;
            this.txthttp.Location = new System.Drawing.Point(875, 123);
            this.txthttp.Name = "txthttp";
            this.txthttp.Size = new System.Drawing.Size(208, 20);
            this.txthttp.TabIndex = 6;
            this.txthttp.TextChanged += new System.EventHandler(this.txthttp_TextChanged);
            this.txthttp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txthttp_KeyUp);
            // 
            // dgwsitesint
            // 
            this.dgwsitesint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwsitesint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.http});
            this.dgwsitesint.Location = new System.Drawing.Point(12, 116);
            this.dgwsitesint.Name = "dgwsitesint";
            this.dgwsitesint.RowHeadersVisible = false;
            this.dgwsitesint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwsitesint.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwsitesint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwsitesint.Size = new System.Drawing.Size(854, 231);
            this.dgwsitesint.TabIndex = 9;
            this.dgwsitesint.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwsenhas_CellContentDoubleClick);
            this.dgwsitesint.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwsitesint_DataBindingComplete);
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(1137, 162);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(160, 21);
            this.cbotipo.TabIndex = 10;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(872, 162);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(259, 138);
            this.txtdesc.TabIndex = 11;
            // 
            // picSite
            // 
            this.picSite.Location = new System.Drawing.Point(12, 19);
            this.picSite.Name = "picSite";
            this.picSite.Size = new System.Drawing.Size(1512, 75);
            this.picSite.TabIndex = 12;
            this.picSite.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Lime;
            this.txtid.Location = new System.Drawing.Point(1176, 277);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(32, 21);
            this.txtid.TabIndex = 13;
            // 
            // btnimagem
            // 
            this.btnimagem.Location = new System.Drawing.Point(1449, 380);
            this.btnimagem.Name = "btnimagem";
            this.btnimagem.Size = new System.Drawing.Size(75, 23);
            this.btnimagem.TabIndex = 14;
            this.btnimagem.Text = "Imagem";
            this.btnimagem.UseVisualStyleBackColor = true;
            this.btnimagem.Click += new System.EventHandler(this.btnimagem_Click);
            // 
            // txtdata
            // 
            this.txtdata.Enabled = false;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.ForeColor = System.Drawing.Color.Lime;
            this.txtdata.Location = new System.Drawing.Point(1137, 239);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(71, 21);
            this.txtdata.TabIndex = 15;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(1089, 123);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(208, 20);
            this.txttitulo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1087, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Título";
            // 
            // PasteMenuHereStrip
            // 
            this.PasteMenuHereStrip.Location = new System.Drawing.Point(0, 0);
            this.PasteMenuHereStrip.Name = "PasteMenuHereStrip";
            this.PasteMenuHereStrip.Size = new System.Drawing.Size(1536, 24);
            this.PasteMenuHereStrip.TabIndex = 18;
            this.PasteMenuHereStrip.Text = "menuStrip1";
            this.PasteMenuHereStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PasteMenuHereStrip_ItemClicked);
            // 
            // btntipo
            // 
            this.btntipo.Location = new System.Drawing.Point(1303, 162);
            this.btntipo.Name = "btntipo";
            this.btntipo.Size = new System.Drawing.Size(31, 23);
            this.btntipo.TabIndex = 19;
            this.btntipo.Text = "***";
            this.btntipo.UseVisualStyleBackColor = true;
            this.btntipo.Click += new System.EventHandler(this.btntipo_Click);
            // 
            // btnfiltro
            // 
            this.btnfiltro.Location = new System.Drawing.Point(1446, 333);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(75, 23);
            this.btnfiltro.TabIndex = 20;
            this.btnfiltro.Text = "Filtrar";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // cboestudado
            // 
            this.cboestudado.FormattingEnabled = true;
            this.cboestudado.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cboestudado.Location = new System.Drawing.Point(1137, 202);
            this.cboestudado.Name = "cboestudado";
            this.cboestudado.Size = new System.Drawing.Size(52, 21);
            this.cboestudado.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1137, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Estudado";
            // 
            // cbofiltro
            // 
            this.cbofiltro.FormattingEnabled = true;
            this.cbofiltro.Items.AddRange(new object[] {
            "Http",
            "Titulo",
            "Tipo",
            "Descrição",
            "Data",
            "Limpar"});
            this.cbofiltro.Location = new System.Drawing.Point(1319, 333);
            this.cbofiltro.Name = "cbofiltro";
            this.cbofiltro.Size = new System.Drawing.Size(121, 21);
            this.cbofiltro.TabIndex = 26;
            // 
            // btnteste
            // 
            this.btnteste.Location = new System.Drawing.Point(1359, 146);
            this.btnteste.Name = "btnteste";
            this.btnteste.Size = new System.Drawing.Size(57, 37);
            this.btnteste.TabIndex = 27;
            this.btnteste.Text = "button2";
            this.btnteste.UseVisualStyleBackColor = true;
            this.btnteste.Click += new System.EventHandler(this.btnteste_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1279, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // http
            // 
            this.http.HeaderText = "Link";
            this.http.Name = "http";
            // 
            // frmSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 398);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnteste);
            this.Controls.Add(this.cbofiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboestudado);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.btntipo);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.btnimagem);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.picSite);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.dgwsitesint);
            this.Controls.Add(this.txthttp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.PasteMenuHereStrip);
            this.MainMenuStrip = this.PasteMenuHereStrip;
            this.Name = "frmSites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus sites Interessantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSites_FormClosing);
            this.Load += new System.EventHandler(this.frmSenhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwsitesint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthttp;
        private System.Windows.Forms.DataGridView dgwsitesint;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.PictureBox picSite;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnimagem;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip PasteMenuHereStrip;
        private System.Windows.Forms.Button btntipo;
        private System.Windows.Forms.Button btnfiltro;
        private System.Windows.Forms.ComboBox cboestudado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbofiltro;
        private System.Windows.Forms.Button btnteste;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewLinkColumn http;
    }
}

