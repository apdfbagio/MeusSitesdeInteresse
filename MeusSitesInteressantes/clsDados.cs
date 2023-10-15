using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.IO;
using MySqlConnector;

namespace MeusSitesInteressantes
{
    public class clsDados
    {
        MySqlDataAdapter Da = new MySqlDataAdapter();
        DataTable Dt = new DataTable();
        MySqlCommand Cmd = new MySqlCommand();

        string StringConexao = "";
        string strNomeArquivo = "";
        public MySqlConnection conn = new MySqlConnection(MySqlClientString);
        DataSet DS = new DataSet();
        bool existe = false;
        string erro = "";
        int iresultado;
        int u = 0;
        MySqlCommand cmdMySQL = new MySqlCommand();
        MySqlDataReader reader;
        public static string MySqlClientString = "server=localhost;database=SCA;uid=root;pwd=sca#1931";
        public void getConexaoBd()
        {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            if (conn.State.Equals(ConnectionState.Closed))
            {
                conn.Open();
            }
        }
        public void closeConexaoBd()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void IncluirDadosSiteInteressante(string http, string titulo,string tipo, string descricao,  DateTime data,string  estudado)
           // public void IncluirDadosSiteInteressante(string http, string titulo,string tipo, string descricao, DateTime data,string  estudado)
        {

            try
            {
                cmdMySQL.ExecuteNonQuery();
                cmdMySQL.Dispose();

                // cn = getConexaoBd();

                Cmd.Connection = conn;
                if (Cmd.Parameters.Count == 0)
                {
                    this.cmdMySQL.CommandText = "INSERT INTO Sitesinteressantes(http,titulo,tipo,descricao,data,estudado) values(@http,@titulo,@tipo,@descricao,@data,@estudado)";
                    this.cmdMySQL.Parameters.Add("@http", System.Data.SqlDbType.VarChar, 200);
                    this.cmdMySQL.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar, 200);
                    this.cmdMySQL.Parameters.Add("@titulo", System.Data.SqlDbType.VarChar, 200);
                    this.cmdMySQL.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar, 400);
                   // this.Cmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    this.cmdMySQL.Parameters.Add("@data", System.Data.SqlDbType.Date, 200);
                    this.cmdMySQL.Parameters.Add("@estudado", System.Data.SqlDbType.VarChar, 1); 
                }
                this.Cmd.Parameters["@http"].Value = http;
                this.Cmd.Parameters["@titulo"].Value = titulo;
                this.Cmd.Parameters["@tipo"].Value = tipo;
                this.Cmd.Parameters["@descricao"].Value = descricao;
              //  this.Cmd.Parameters["@imagem"].Value = vetorImagens;
                this.Cmd.Parameters["@data"].Value = data;
                this.Cmd.Parameters["@estudado"].Value = estudado;

                int iresultado = this.Cmd.ExecuteNonQuery();
                closeConexaoBd();

           
               // if (iresultado <= 0)
                   // MessageBox.Show("Falha ao incluir imagem no banco de dados.");

             //   getImagensSQLServer(cn);
                //string query = "Insert into Tbg_Senhas(Empresa,Login,Senha) Values('" + empresa + "' ,'" + login + "','" + senha + "')";
                //Cmd.CommandType = CommandType.Text;
                //Cmd.CommandText = query;
                //Cmd.Connection = cn;
                //Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public DataTable getImagensSQLServer()
            {
                try
                {
                    //cn = getConexaoBd();
                    ////Inicializar o SQL adapter.
                    //// SqlDataAdapter ADAP = new SqlDataAdapter("Select http,titulo,tipo,descricao,imagem,data,estudado,Id from Sitesinteressantes", cn);
                    //SqlDataAdapter ADAP = new SqlDataAdapter("Select http,titulo,tipo,descricao,data,estudado,Id from Sitesinteressantes", cn);

                    ////Inicializa o  Dataset.


                    ////Preenche o dataset com a tabela Imagens
                    //  ADAP.Fill(DS, "Imagens");

                    //preenche o datagridviewe com o dataset.


                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());
                }
                  return DS.Tables["Imagens"];
            }


        public bool getImagensSQLServerporhttp(string http)
        {
            try
            {
              //  //DataTable Dt = new DataTable();
              // /// cn = getConexaoBd();
              //  //Inicializar o SQL adapter.
              //  SqlDataAdapter ADAP = new SqlDataAdapter("Select Id from Sitesinteressantes where http=" + "'" + http + "'", cn);

              //  //Inicializa o  Dataset.


              //  //Preenche o dataset com a tabela Imagens
              // // ADAP.Fill(Dt);
              ////  u = Dt.Rows.Count;
              // // existe = false;
              //  cn = getConexaoBd();
              //  //Inicializar o SQL adapter.
              // // DataTable Dt = new DataTable();
              ////  string query = "";

              //  Cmd.Connection = cn;
              //  Cmd.CommandType = CommandType.Text;
              //  Cmd.CommandText = "Select Id from Sitesinteressantes where http=" + "'" + http + "'";
              //   int iresultado = this.Cmd.ExecuteNonQuery();
              // // SqlDataAdapter ADAP = new SqlDataAdapter();

              // // sresultado = Convert.ToString(iresultado);
              //  //Inicializa o  Dataset.
              //  Da.SelectCommand = Cmd;
              //  //ADAP.Fill(Dt);
              //  //int y = Dt.Rows.Count;
              //  if (iresultado ==1)
              //  {
              //      existe = true;
              //  }
              //  else
              //  { existe = false; }
              //  closeConexaoBd();
              //  //Preenche o dataset com a tabela Imagens
              //  ADAP.Fill(DS, "Imagens");
                  //DS(
                //preenche o datagridviewe com o dataset.


            }
            catch (Exception ex)
            {
                erro= ex.Source.ToString()+ " " + ex.Message.ToString();
            }
            return existe;
        }

        public DataTable carregaDados()
        {
            DataTable Dt = new DataTable() ;
            Cmd.Connection = conn;
            try
            {
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "Select * from Tbg_Senhas order by Empresa asc";
                Cmd.Connection = cn;

                Da.SelectCommand = Cmd;
                Da.Fill(Dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Dt;
        }

        public void AlterarDados(string http, string titulo, string tipo, string descricao, byte[] vetorImagens, DateTime data, string estudado, int id)
        {

            try
            {
                cn = getConexaoBd();
                Cmd.Connection = cn;
                string query = "";
                string query1 = "Update Sitesinteressantes set http=" + "'" + http + "'" + "," + "titulo=" + "'" + titulo + "'" + "," + "tipo=" + "'" + tipo + "'" + "," + "descricao=" + "'" + descricao + "'" + "," + "data=" + "'" + data + "'" + "," + "estudado=" + "'" + estudado + "'" + " Where id=" + "'" + id + "'";
             //  string query2 = "Update Sitesinteressantes set http=" + "'" + http + "'" + "," + "titulo=" + "'" + titulo + "'" + "," + "tipo=" + "'" + tipo + "'" + "," + "descricao=" + "'" + descricao + "'" + "," + "imagem=" + "'" + vetorImagens + "'" + "," + "data=" + "'" + data + "'"+ "," + "estudado=" + "'" + estudado + "'" + " Where id=" + "'" + id + "'";

                //string sqlQuery1 = "UPDATE Sitesinteressantes SET http = @http, titulo = @titulo, tipo = @tipo, descricao = @descricao, data = @data,estudado = @estudado, vetorImagens = @vetorImagens WHERE Id = @Id";
                string sqlQuery1 = "UPDATE Sitesinteressantes SET http = @http, titulo = @titulo, tipo = @tipo, descricao = @descricao, data = @data,estudado = @estudado WHERE Id = @Id";
                if (vetorImagens == null){
                  //  query = sqlQuery2;
                    query = query1;
                }
                else
                {
                  //  query = sqlQuery1;
                    query = query1;
                }

                //  SqlCommand command = new SqlCommand(sqlQuery, connection);
                if (Cmd.Parameters.Count == 0)
                {
                    this.Cmd.CommandText = query;
                    this.Cmd.Parameters.Add("@http", System.Data.SqlDbType.VarChar, 200);
                    this.Cmd.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar, 200);
                    this.Cmd.Parameters.Add("@titulo", System.Data.SqlDbType.VarChar, 200);
                    this.Cmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar, 400);
                    this.Cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar, 50);
                    //    if (vetorImagens != null)
                    //{
                    //    this.Cmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    //}
                    //    this.Cmd.Parameters.Add("@data", System.Data.SqlDbType.Date, 50);
                    //    this.Cmd.Parameters.Add("@estudado", System.Data.SqlDbType.VarChar, 1);
                    //}
                    this.Cmd.Parameters["@http"].Value = http;
                    this.Cmd.Parameters["@titulo"].Value = titulo;
                    this.Cmd.Parameters["@tipo"].Value = tipo;
                    this.Cmd.Parameters["@descricao"].Value = descricao;
                    //     if (vetorImagens != null)
                    //{
                    //    this.Cmd.Parameters["@imagem"].Value = vetorImagens;
                    //}
                    this.Cmd.Parameters["@data"].Value = data;
                    this.Cmd.Parameters["@estudado"].Value = estudado;
                    this.Cmd.Parameters["@id"].Value = id;

                    int iresultado = this.Cmd.ExecuteNonQuery();
                }



                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = query;
                Cmd.Connection = cn;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeletarDados(int id)
        {

            try
            {
                cn = getConexaoBd();
                Cmd.Connection = cn;
                string query = "Delete from  Sitesinteressantes " + " Where id=" + "'" + id + "'";
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = query;
                Cmd.Connection = cn;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Image RetornaImagemdoBD(string id)
        {
                             //           if (txtCodigoImagem.Text == string.Empty)
                             //           {
                             //               MessageBox.Show("Informe o código da imagem no Banco de dados", "Código da Imagem",
                             ////MessageBoxButtons.OK, MessageBoxIcon.Information);
                             //               return;
                             //           }

            try
            {
                cn = getConexaoBd();
                SqlCommand cmdSelect = new SqlCommand("select imagem from Sitesinteressantes where id=@ID", cn);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmdSelect.Parameters["@ID"].Value = id;
              //  this.conexaoSQLServer.Open();
                byte[] vetorImagem = (byte[])cmdSelect.ExecuteScalar();
                 strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();

               // picImagem.Image = Image.FromFile(strNomeArquivo);
              
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
             //   this.conexaoSQLServer.Close();
            }
            return Image.FromFile(strNomeArquivo);
        }

        //TIPOS

        public void IncluirDadosTipos(string tipo)
        {

            try
            {
                cn = getConexaoBd();
                Cmd.Connection = cn;
                if (Cmd.Parameters.Count == 0)
                {
                    this.Cmd.CommandText = "INSERT INTO Tipos(tipo) values(@tipo)";
                   
                    this.Cmd.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar, 200);
                   
                }
                
                this.Cmd.Parameters["@tipo"].Value = tipo;
                
                int iresultado = this.Cmd.ExecuteNonQuery();
                closeConexaoBd();
                // if (iresultado <= 0)
                // MessageBox.Show("Falha ao incluir imagem no banco de dados.");

                //   getImagensSQLServer(cn);
                //string query = "Insert into Tbg_Senhas(Empresa,Login,Senha) Values('" + empresa + "' ,'" + login + "','" + senha + "')";
                //Cmd.CommandType = CommandType.Text;
                //Cmd.CommandText = query;
                //Cmd.Connection = cn;
                //Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarDadosTipos( string tipo, int id)
        {

            try
            {
                cn = getConexaoBd();
                Cmd.Connection = cn;
               // string query = "";
                string query = "Update Tipos set tipo=" + "'" + tipo + "'" + " Where id=" + "'" + id + "'";
            
              //  string sqlQuery1 = "UPDATE Sitesinteressantes SET http = @http, titulo = @titulo, tipo = @tipo, descricao = @descricao, data = @data, vetorImagens = @vetorImagens WHERE Id = @Id";
              //  string sqlQuery2 = "UPDATE Sitesinteressantes SET http = @http, titulo = @titulo, tipo = @tipo, descricao = @descricao, data = @data WHERE Id = @Id";
                //

                //  SqlCommand command = new SqlCommand(sqlQuery, connection);
                if (Cmd.Parameters.Count == 0)
                {
                    this.Cmd.CommandText = query;
                   
                    this.Cmd.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar, 200);
                   
                }
              
                this.Cmd.Parameters["@tipo"].Value = tipo;
               

                //   int iresultado = this.Cmd.ExecuteNonQuery();




                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = query;
                Cmd.Connection = cn;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         public void DeletarDadosTipo(int id)
        {

            try
            {
                cn = getConexaoBd();
                Cmd.Connection = cn;
                string query = "Delete from  Tipos " + " Where id=" + "'" + id + "'";
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = query;
                Cmd.Connection = cn;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable carregaDadosTipos()
        {
            DataTable Dt = new DataTable() ;
            cn = getConexaoBd();
            try
            {
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "Select * from Tipos order by Tipo asc";
                Cmd.Connection = cn;

                Da.SelectCommand = Cmd;
                Da.Fill(Dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Dt;
        }
    }
}

