using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
//using System.Speech.Synthesis;
namespace MeusSitesInteressantes
{
    public partial class frmSites : Form
    {
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        public int idsites=0;
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private Process app;


        public frmSites()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)//incluir
        {
             DateTime datadagravacao = DateTime.Now;
            clsDados dados = new clsDados();
            if (!dados.getImagensSQLServerporhttp(txthttp.Text))
            {
                dados.IncluirDadosSiteInteressante(txthttp.Text, txttitulo.Text, cbotipo.Text, txtdesc.Text,  datadagravacao,cboestudado.Text);
                //dados.IncluirDadosSiteInteressante(txthttp.Text, txttitulo.Text, cbotipo.Text, txtdesc.Text,  datadagravacao, cboestudado.Text);
                MessageBox.Show("Site incluído com sucesso! ", "Atenção!");
            }
            else
            {
                MessageBox.Show("O http= " + txthttp.Text + " Já existe no banco!", "Atenção!");
            }

            carregaDados();
        }

        private void btnalterar_Click(object sender, EventArgs e)//Alterar
        {
            DateTime datadagravacao = DateTime.Now;
            clsDados dados = new clsDados();
           
            dados.AlterarDados(txthttp.Text, txttitulo.Text, cbotipo.Text, txtdesc.Text, vetorImagens, datadagravacao,cboestudado.Text,idsites);
            carregaDados();
        }

        private void btnexcluir_Click(object sender, EventArgs e)//excluir
        {
            clsDados dados = new clsDados();
            dados.DeletarDados(idsites);
            carregaDados();
        }

        private void dgwsenhas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
              clsDados Dados = new clsDados();
            if (dgwsitesint.SelectedCells.Count > 0)
            {
                int selectrowindex = dgwsitesint.SelectedCells[0].RowIndex;
                DataGridViewRow selectdrow = dgwsitesint.Rows[selectrowindex];
                txthttp.Text = Convert.ToString(selectdrow.Cells["http"].Value);
               // var uri = new Uri(txthttp.Text);
                txttitulo.Text = Convert.ToString(selectdrow.Cells["titulo"].Value);
                cbotipo.Text = Convert.ToString(selectdrow.Cells["tipo"].Value);
                txtdesc.Text = Convert.ToString(selectdrow.Cells["descricao"].Value);
                txtdata.Text = Convert.ToString(selectdrow.Cells["data"].Value);
                cboestudado.Text = Convert.ToString(selectdrow.Cells["estudado"].Value);
                txtid.Text = Convert.ToString(selectdrow.Cells["id"].Value);
               idsites = Convert.ToInt32(selectdrow.Cells["id"].Value);
              //////////////picSite.Image=  Dados.RetornaImagemdoBD(txtid.Text);
            //  Navegador.Navigate(txttitulo.Text);
              //Navegador.ScriptErrorsSuppressed = true;
              //Navegador.Url = uri;

              //app = Process.Start("Chrome.exe");
              //Thread.Sleep(1000);
             // SetParent(app.MainWindowHandle, panel1.Handle);

              
            }
        }

        private void frmSenhas_Load(object sender, EventArgs e)
        {
            carregaDados();
            CarregaCommboTipo();
        }

        public void CarregaCommboTipo()
        {
            cbotipo.Items.Clear();

            clsDados Dados = new clsDados();
            DataTable tabela = new DataTable();
            tabela = Dados.carregaDadosTipos();
            foreach (DataRow linha in tabela.Rows)
            {
               cbotipo.Items.Add( linha["Tipo"].ToString());
            }
        }
        public void carregaDados()
        {
              //gdvImagens.DataSource = DS.Tables["Imagens"];
            clsDados Dados = new clsDados();
            DataTable tabela = new DataTable();
            tabela= Dados.getImagensSQLServer();
            dgwsitesint.DataSource = tabela;

            //dgwsitesint.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dgwsitesint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

         protected void CarregaImagem()//abre caixa de dialogo e busca imagem para gravar no banco
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.picSite.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open,FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
                fs = null;
                File.SetAttributes(strFn, FileAttributes.Normal);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void btnimagem_Click(object sender, EventArgs e)
         {
             CarregaImagem();
         }

         private void dgwsitesint_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
         {

             //foreach (DataGridViewRow r in dgwsitesint.Rows)
             //{
             //    if (!System.Uri.IsWellFormedUriString(r.Cells["http"].Value.ToString(), UriKind.Absolute))
             //    {
             //        r.Cells["http"] = new DataGridViewTextBoxCell();
             //    }
             //}

         }

         private void txthttp_KeyUp(object sender, KeyEventArgs e)
         {
             if (e.KeyData == Keys.V && e.Modifiers == Keys.Control)
             {
                 MessageBox.Show("deu merda");
                 if (Clipboard.ContainsText())
                 {
                     txthttp.AppendText(Clipboard.GetText());
                 }
             }
         }

         private void PasteMenuHereStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
         {
             // Determine if there is any text in the Clipboard to paste into the                                //               //textbox        
             if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
             {
                 txthttp.Paste();
             }
         }

         private void btntipo_Click(object sender, EventArgs e)
         {
             frmTipos tipos = new frmTipos();
             tipos.ShowDialog();
             CarregaCommboTipo();
         }

         private void btnfiltro_Click(object sender, EventArgs e)
         {
             if (cbofiltro.Text == "Http")
             { dgwsitesint.Sort(dgwsitesint.Columns[0], ListSortDirection.Ascending); }
             if (cbofiltro.Text == "Tipo")
             { dgwsitesint.Sort(dgwsitesint.Columns[1], ListSortDirection.Ascending);}
             if (cbofiltro.Text == "Titulo")
             {dgwsitesint.Sort(dgwsitesint.Columns[2], ListSortDirection.Ascending);}
             if (cbofiltro.Text == "Descrição")
             {dgwsitesint.Sort(dgwsitesint.Columns[3], ListSortDirection.Ascending);}
             if (cbofiltro.Text == "Data")
             {  dgwsitesint.Sort(dgwsitesint.Columns[5], ListSortDirection.Ascending);}
             if (cbofiltro.Text == "Limpar")
             { carregaDados(); }
         }

         private void txthttp_TextChanged(object sender, EventArgs e)
         {
            
         }

         private void btnteste_Click(object sender, EventArgs e)
         {
             try
             {
                 var linha1 = Clipboard.GetText(TextDataFormat.Html);
                 if (linha1.Count() > 0)
                 {
                     // Thread.Sleep(5000);

                     System.Windows.Forms.Clipboard.SetText(linha1);
                     var linha = Clipboard.GetText();
                     txthttp.Text = linha;
                     MessageBox.Show("achou " + linha.Count());
                 }
             }
                   catch (Exception ex)
            {
            
                MessageBox.Show(ex.Message);
            }
             
             //Thread.Sleep(5000); //will sleep for 5 sec
             //string h = "";
             //h = Clipboard.GetText(System.Windows.Forms.TextDataFormat.UnicodeText);
             //this.txthttp.Text="jumento";
             //MessageBox.Show("ahhh" +h );
         }

         private void frmSites_FormClosing(object sender, FormClosingEventArgs e)
         {
             if (app != null && !app.HasExited)
                 app.CloseMainWindow();
         }

         
    }
}
