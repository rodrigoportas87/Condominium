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
    public partial class CadVisita : Form
    {

        banco Banco = new banco();
        public string prestador;
        
        public CadVisita()
        {
            InitializeComponent();
        }

        private void vISITABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vISITABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.portariaDBDataSet);

        }

        private void CadVisita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'portariaDBDataSet.VISITA' table. You can move, or remove it, as needed.
            this.vISITATableAdapter.Fill(this.portariaDBDataSet.VISITA);
            gpboxPrestador.Enabled = false;
            btnLimpar.PerformClick();
            btnAlterar.Enabled = false;
           
        }

        private void mstxtRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void carro_VisitaLabel_Click(object sender, EventArgs e)
        {

        }

        private void chkPrestador_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkPrestador_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPrestador.Checked == true)
            {
                gpboxPrestador.Enabled = true;
                prestador = "Sim";
            }
            else if (chkPrestador.Checked == false)
            {
                gpboxPrestador.Enabled = false;
                prestador = "Não";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((mstxtRgVisita.Text == "  .   .   -")||(txtNomeVisita.Text == ""))
            {
                MessageBox.Show("Os campos 'Nome' e 'RG' não podem estar vazios", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                try
                {

                    SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);

                    String SQL = "insert into VISITA(nm_Visita,doc_Visita,tel_Visita,carro_Visita,placaCarro_Visita,Empresa,Segmento,Prestador_servico,ObservacaoVisita) values ('" + txtNomeVisita.Text + "','" + mstxtRgVisita.Text + "','" + mstxtFoneVisita.Text + "','" + txtVeiculo.Text + "','" + mstxtPlacaVisita.Text + "' ,'" + txtEmpresa.Text + "','" + cmbSegmento.Text + "','" + prestador + "','" + rchtxtObs.Text + "')";

                    SqlCommand comando3 = new SqlCommand(SQL, conexao);
                    conexao.Open();
                    comando3.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Cadastro de visitante efetuada com sucesso");
                    btnLimpar.PerformClick();
                    if (chkFechar.Checked == true)
                    {
                        this.Close();

                    }

                }
                catch
                {
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                comando.CommandText = ("update VISITA set nm_Visita ='" + txtNomeVisita.Text + "',doc_Visita = '" + mstxtRgVisita.Text + "',tel_Visita ='" + mstxtFoneVisita.Text + "',carro_Visita ='" + txtVeiculo.Text + "',placaCarro_Visita ='" + mstxtPlacaVisita.Text + "',Empresa ='" + txtEmpresa.Text + "',Segmento ='" + cmbSegmento.Text + "',Prestador_servico ='" + prestador + "',ObservacaoVisita ='" + rchtxtObs.Text + "' WHERE doc_Visita ='" + mstxtRgVisita.Text + "'");

                //conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();


                MessageBox.Show("Visitante Alterado com sucesso");
                btnLimpar.PerformClick();
                if (chkFechar.Checked == true)
                {
                    this.Close();

                }
            }

            catch
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmpresa.Clear();
            txtNomeVisita.Clear();
            txtVeiculo.Clear();
            mstxtFoneVisita.Clear();
            mstxtPlacaVisita.Clear();
            mstxtRgVisita.Clear();
            rchtxtObs.Clear();
            btnSalvar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (mstxtRgVisita.Text.Length == 12)
            {
                string sql = ("SELECT * FROM VISITA WHERE doc_Visita = '" + mstxtRgVisita.Text + "'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);
                if (DtRetorno.Rows.Count > 0)
                {

                    // bindingNavigatorCountItem.Text = Convert.ToString(DtRetorno.Rows.Count);
                    //txtId.Text = DtRetorno.Rows[0].ItemArray[0].ToString();
                    txtNomeVisita.Text = DtRetorno.Rows[0].ItemArray[1].ToString();
                    mstxtRgVisita.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    mstxtFoneVisita.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    txtVeiculo.Text = DtRetorno.Rows[0].ItemArray[4].ToString();
                    mstxtPlacaVisita.Text = DtRetorno.Rows[0].ItemArray[5].ToString();
                    txtEmpresa.Text = DtRetorno.Rows[0].ItemArray[6].ToString();
                    cmbSegmento.Text = DtRetorno.Rows[0].ItemArray[7].ToString();
                    rchtxtObs.Text = DtRetorno.Rows[0].ItemArray[9].ToString();
                    btnSalvar.Enabled = false;
                    btnPesquisar.Enabled = false;
                    btnAlterar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Não existem registros deste visitante no Banco de Dados");
                }
            }
        }

        private void mstxtRgVisita_TextChanged(object sender, EventArgs e)
        {
           
            if (mstxtRgVisita.Text.Length == 12)
            {
                mstxtRgVisita.Text.ToUpper();
                string sql = ("SELECT * FROM VISITA WHERE doc_Visita = '" + mstxtRgVisita.Text + "'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);
                if (DtRetorno.Rows.Count > 0)
                {

                    // bindingNavigatorCountItem.Text = Convert.ToString(DtRetorno.Rows.Count);
                    //txtId.Text = DtRetorno.Rows[0].ItemArray[0].ToString();
                    txtNomeVisita.Text = DtRetorno.Rows[0].ItemArray[1].ToString();
                    mstxtRgVisita.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    mstxtFoneVisita.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    txtVeiculo.Text = DtRetorno.Rows[0].ItemArray[4].ToString();
                    mstxtPlacaVisita.Text = DtRetorno.Rows[0].ItemArray[5].ToString();
                    txtEmpresa.Text = DtRetorno.Rows[0].ItemArray[6].ToString();
                    cmbSegmento.Text = DtRetorno.Rows[0].ItemArray[7].ToString();
                    rchtxtObs.Text = DtRetorno.Rows[0].ItemArray[9].ToString();
                    btnSalvar.Enabled = false;
                    btnPesquisar.Enabled = false;
                    btnAlterar.Enabled = true;
                }
            }
        }

        private void chkFechar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
