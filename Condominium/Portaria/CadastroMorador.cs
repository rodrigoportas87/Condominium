using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;

namespace Portaria
{
    public partial class CadastroMorador : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\PortariaDB.mdf;Integrated Security=True");
        //SqlCommand comando2 = new SqlCommand();
       // SqlDataReader dr;

        OleDbConnection conexao;
        OleDbCommand comando;
        banco Banco = new banco();
        public int cont;
        public CadastroMorador()
        {
            InitializeComponent();
            btnLimpar.PerformClick();
            
            
        }

        private void CadastroMorador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PortariaDBDataSet.LogVisita' table. You can move, or remove it, as needed.
            this.logVisitaTableAdapter.Fill(this.PortariaDBDataSet.LogVisita);
            // TODO: This line of code loads data into the 'portariaDBDataSet.Morador' table. You can move, or remove it, as needed.
            this.moradorTableAdapter.Fill(this.PortariaDBDataSet.Morador);
            //comando2.Connection = conn;
            btnLimpar.PerformClick();

        }
        private void moradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.PortariaDBDataSet);

        }

//

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtApMorador.Text == "") || (txtBlocoMorador.Text == "") || (txtNomeMorador.Text == ""))
            {
                MessageBox.Show("Os campos 'Nome' e 'Bloco' e 'Apartamento' não podem estar vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa("SELECT * FROM Morador WHERE NomeMorador ='" + txtNomeMorador.Text + "'and Bloco = '" + txtBlocoMorador.Text + "'and Apartamento = '" + txtApMorador.Text + "' ");
                if (DtRetorno.Rows.Count == 0)
                {

                    //conn.Open();
                    //comando2.CommandText = "insert into Morador(NomeMorador,Bloco,Apartamento,ObservacaoMorador) values ('" + txtNomeMorador.Text + "','" + txtBlocoMorador.Text + "','" + txtApMorador.Text + "','" + rtxtObs.Text + "')";
                    //comando2.ExecuteNonQuery();
                    //conn.Close();

                    try
                    {

                        SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexao;
                        comando.CommandText = "insert into Morador(NomeMorador,Bloco,Apartamento,ObservacaoMorador) values ('" + txtNomeMorador.Text + "','" + txtBlocoMorador.Text + "','" + txtApMorador.Text + "','" + rtxtObs.Text + "')";



                        conexao.Open();
                        comando.ExecuteNonQuery();
                        conexao.Close();


                        MessageBox.Show("Morador Cadastrado com sucesso");
                        bindingNavigatorCountItem1.Text = Convert.ToString(DtRetorno.Rows.Count);
                        btnLimpar.PerformClick();
                        txtNomeMorador.Focus();
                    }

                    catch
                    {

                    }


                }
                else if (DtRetorno.Rows.Count >= 1)
                {
                    MessageBox.Show("Esse Morador já existe nos registros");
                }


            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeMorador.Clear();
            txtBlocoMorador.Clear();
            txtApMorador.Clear();
            rtxtObs.Clear();
            btnSalvar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNomeMorador.Text.Length > 1)
            {
                string sql = ("SELECT * FROM Morador WHERE NomeMorador like '%" + txtNomeMorador.Text + "%'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);
                if (DtRetorno.Rows.Count > 0)
                {

                    moradorBindingNavigator.Text = Convert.ToString(DtRetorno.Rows.Count);
                    //txtId.Text = DtRetorno.Rows[0].ItemArray[0].ToString();
                    txtNomeMorador.Text = DtRetorno.Rows[0].ItemArray[1].ToString();
                    txtBlocoMorador.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    txtApMorador.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    rtxtObs.Text = DtRetorno.Rows[0].ItemArray[4].ToString();
                    btnSalvar.Enabled = false;
                    btnPesquisar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Não existem registros deste morador no Banco de Dados");
                }
            }
            else if ((txtBlocoMorador.Text.Length >= 1) || (txtApMorador.Text.Length >= 1))
            {
               //SELECT * FROM LogVisita L WHERE L.ApartamentoVisita ='" + txtApVisitaRel.Text + " and L.BlocoVisita ='" + txtBlocoVisitaRel.Text + "'"
                string sql = ("SELECT * FROM Morador m WHERE m.Bloco = '" + txtBlocoMorador.Text + "' and m.Apartamento = '" + txtApMorador.Text + "'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);
                
                if (DtRetorno.Rows.Count > 0)
                {

                    moradorBindingNavigator.Text = Convert.ToString(DtRetorno.Rows.Count);
                    txtNomeMorador.Text = DtRetorno.Rows[0].ItemArray[1].ToString();
                    txtBlocoMorador.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    txtApMorador.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    rtxtObs.Text = DtRetorno.Rows[0].ItemArray[4].ToString();
                    btnSalvar.Enabled = false;
                    btnPesquisar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Não existem registros deste morador no Banco de Dados");
                }
            }
            /*else if ()
            {
                string sql = ("SELECT * FROM Morador  WHERE Apartamento = '" + txtApMorador.Text + "'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);
                if (DtRetorno.Rows.Count > 0)
                {

                    moradorBindingNavigator.Text = Convert.ToString(DtRetorno.Rows.Count);
                    txtNomeMorador.Text = DtRetorno.Rows[0].ItemArray[1].ToString();
                    txtBlocoMorador.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    txtApMorador.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    rtxtObs.Text = DtRetorno.Rows[0].ItemArray[4].ToString();
                    btnSalvar.Enabled = false;
                    btnPesquisar.Enabled = false;
                   

                }
                else
                {
                    MessageBox.Show("Não existem registros deste morador no Banco de Dados");
                }
            }*/
            
           
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);

                    //    + mstxtRg.Text +"','" + rtxtObsVisita.Text + "' )";
                    String SQL = ("delete Morador from Morador WHERE NomeMorador = '" + txtNomeMorador.Text + "'");

                    SqlCommand comando3 = new SqlCommand(SQL, conexao);
                    conexao.Open();
                    comando3.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Morador deletado com sucesso");
                    btnLimpar.PerformClick();

                }
                catch
                {
                }
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

            btnPesquisar.Enabled=true;
            rtxtObs.Clear();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            btnPesquisar.Enabled = true;
            rtxtObs.Clear();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            
        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {
            btnPesquisar.Enabled = true;
            rtxtObs.Clear();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            
        }

        private void bindingNavigatorMovePreviousItem_Click_1(object sender, EventArgs e)
        {
            btnPesquisar.Enabled = true;
            rtxtObs.Clear();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                conexao.Open();
                comando.CommandText = ("update Morador set NomeMorador ='" + txtNomeMorador.Text + "',Bloco = '" + txtBlocoMorador.Text + "',Apartamento ='" + txtApMorador.Text + "',ObservacaoMorador ='" + rtxtObs.Text + "' WHERE Bloco ='" + txtBlocoMorador.Text + "'and Apartamento = '" + txtApMorador.Text + "'");
               
                //conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();


                MessageBox.Show("Morador Alterado com sucesso");
                btnLimpar.PerformClick();
            }

            catch
            {

            }
        }

        private void lblNomeMorador_Click(object sender, EventArgs e)
        {

        }

        private void moradorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
