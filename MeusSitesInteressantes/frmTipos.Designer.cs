namespace MeusSitesInteressantes
{
    partial class frmTipos
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
            this.txttipos = new System.Windows.Forms.TextBox();
            this.dgwtipos = new System.Windows.Forms.DataGridView();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwtipos)).BeginInit();
            this.SuspendLayout();
            // 
            // txttipos
            // 
            this.txttipos.Location = new System.Drawing.Point(22, 27);
            this.txttipos.Name = "txttipos";
            this.txttipos.Size = new System.Drawing.Size(240, 20);
            this.txttipos.TabIndex = 0;
            // 
            // dgwtipos
            // 
            this.dgwtipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwtipos.Location = new System.Drawing.Point(22, 55);
            this.dgwtipos.Name = "dgwtipos";
            this.dgwtipos.RowHeadersVisible = false;
            this.dgwtipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwtipos.Size = new System.Drawing.Size(240, 69);
            this.dgwtipos.TabIndex = 1;
            this.dgwtipos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwtipos_CellContentDoubleClick);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(187, 130);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(106, 130);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 2;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(25, 130);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 1;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // frmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 161);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.dgwtipos);
            this.Controls.Add(this.txttipos);
            this.Name = "frmTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipos";
            this.Load += new System.EventHandler(this.frmTipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwtipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttipos;
        private System.Windows.Forms.DataGridView dgwtipos;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnincluir;
    }
}