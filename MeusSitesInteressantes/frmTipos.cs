using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusSitesInteressantes
{
    public partial class frmTipos : Form
    {
        int idtipos;
        public frmTipos()
        {
            InitializeComponent();
        }
        clsDados Dados = new clsDados();
        private void btnincluir_Click(object sender, EventArgs e)
        {
            Dados.IncluirDadosTipos(txttipos.Text);
            carregaDados();
            Limpar();
            txttipos.Focus();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Dados.AlterarDadosTipos(txttipos.Text, idtipos);
            carregaDados();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            clsDados dados = new clsDados();
            dados.DeletarDadosTipo(idtipos);

            carregaDados();
        }

        public void Limpar()
        {
            txttipos.Clear();
        }
        public void carregaDados()
        {
            //gdvImagens.DataSource = DS.Tables["Imagens"];
            clsDados Dados = new clsDados();
            DataTable tabela = new DataTable();
            tabela = Dados.carregaDadosTipos();
            dgwtipos.DataSource = tabela;

            //dgwsitesint.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dgwsitesint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgwtipos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsDados Dados = new clsDados();
            if (dgwtipos.SelectedCells.Count > 0)
            {
                int selectrowindex = dgwtipos.SelectedCells[0].RowIndex;
                DataGridViewRow selectdrow = dgwtipos.Rows[selectrowindex];
             
                txttipos.Text = Convert.ToString(selectdrow.Cells["tipo"].Value);

                idtipos = Convert.ToInt32(selectdrow.Cells["id"].Value);
            

            }
        }

        private void frmTipos_Load(object sender, EventArgs e)
        {
            carregaDados();
        }
    }
}
