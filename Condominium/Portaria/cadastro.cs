using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Properties;



namespace Portaria
{
    public partial class cadastro : Form
    {

        banco Banco = new banco();
        public string Blocos;
        public int numApartamento;
        
        
             
        public cadastro()
        {
            InitializeComponent();
            btnLimpar.PerformClick();
            mstxtRg.Focus();
            
            //txtApartamento.Text = Blocos;
            //txtApartamento.Text = numApartamento.ToString();
           
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbBloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void txtBloco_TextChanged(object sender, EventArgs e)
        {
            if (txtApartamento.Text.Length == 2)
            {
                string sql = ("SELECT * FROM Morador WHERE Bloco  like '%" + txtBloco.Text + "%'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);

                if (DtRetorno.Rows.Count > 0)
                {
                    txtBloco.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    txtApartamento.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    txtNomeMorador2.Text = DtRetorno.Rows[0].ItemArray[1].ToString();

                    mstxtRg.Focus();
                }
            }
                       
        }

        public void moradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.portariaDBDataSet);

        }

        public void cadastro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'portariaDBDataSet.Morador' table. You can move, or remove it, as needed.
            //this.moradorTableAdapter.Fill(this.portariaDBDataSet.Morador);
            btnLimpar.PerformClick();
            txtBloco.Text = Blocos;
            txtApartamento.Text = numApartamento.ToString();
            dtVisita.Text = DateTime.Now.ToString();
            


        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
           /* banco bnc = new banco();
            //string data = dtVisita.Value.Date.ToShortDateString();
            //String[] Dt = data.Split('/');
           // data = Dt[1] + "/" + Dt[0] + "/" + Dt[2];

            /*String SQL = "insert into LogVisita(DtVisita,NomeVisita,DocVisita,Observacao) values ('" /*+ data + "" + DateTime.Now.ToShortTimeString() + "','" + txtNomeVisita.Text  + "','" + mstxtRg.Text +"','" + rtxtObsVisita.Text + "' )";
            
           /* SqlCommand comando = new SqlCommand(SQL,)
         
            if (bnc.executar(SQL))
            {
                MessageBox.Show("Entrada de Visitante registrada com sucesso");
                btnLimpar.PerformClick();

            }*/
            try
            {


                //DateTime dia = DateTime.Now;
              // SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
               
                //string data = dtVisita.Value.Date.ToString();
               // string data = dtVisita.Value.ToString();
                //SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Rodrigo\Desktop\Portaria v\Portaria\Portaria\PortariaDB.mdf;Integrated Security=True;");
               // conexao.Open();
                //SqlCommand comando = new SqlCommand();
               // comando.Connection = conexao;
               // string data = dtVisita.Value.ToString();
               
                //    + mstxtRg.Text +"','" + rtxtObsVisita.Text + "' )";
               // String SQL = "insert into LogVisita(NomeVisita,DtVisita ,BlocoVisita,Responsavel,ApartamentoVisita,DocVisita,Telefone) values ('" + txtNomeVisita.Text + "','" + dtVisita.Value.ToString() +"','" + txtBloco.Text + "','" + txtNomeMorador2.Text + "','" + txtApartamento.Text + "','" + mstxtRg.Text + "','" + mstxtFone.Text + "')";


              // SqlCommand comando3 = new SqlCommand(SQL, conexao);
               
              // comando3.ExecuteNonQuery();
              // conexao.Close();
                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                string data = dtVisita.Value.ToString();
                String[] Dt = data.Split('/');
                data = Dt[1] + "/" + Dt[0] + "/" + Dt[2];
                //    + mstxtRg.Text +"','" + rtxtObsVisita.Text + "' )";
                String SQL = "insert into LogVisita(NomeVisita,DtVisita,BlocoVisita,Responsavel,ApartamentoVisita,DocVisita,Telefone) values ('" + txtNomeVisita.Text + "','" + data + "','" + txtBloco.Text + "','" + txtNomeMorador2.Text + "','" + txtApartamento.Text + "' ,'" + mstxtRg.Text + "','" + mstxtFone.Text + "')";


                SqlCommand comando3 = new SqlCommand(SQL, conexao);
                conexao.Open();
                comando3.ExecuteNonQuery();
                conexao.Close();
               MessageBox.Show("Entrada de visitante registrada com sucesso");
               btnLimpar.PerformClick();
                if(chkFechar.Checked == true)
                {
                    this.Close();
                    
                }
              

            }
           catch
           {
            }
        }

        
        public void txtApartamento_TextChanged(object sender, EventArgs e)
        {
            if (txtApartamento.Text.Length == 3)
            {
                string sql = ("SELECT * FROM Morador WHERE Apartamento like '%" + txtApartamento.Text + "%'and Bloco like '%" +txtBloco.Text+"%'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);

                if (DtRetorno.Rows.Count > 0)
                {
                    txtBloco.Text = DtRetorno.Rows[0].ItemArray[2].ToString();
                    txtApartamento.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    txtNomeMorador2.Text = DtRetorno.Rows[0].ItemArray[1].ToString();

                    mstxtRg.Focus();

                }
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeMorador2.Clear();
            txtNomeVisita.Clear();
            mstxtFone.Clear();
            txtBloco.Clear();
            txtApartamento.Clear();
            rtxtObsVisita.Clear();
            mstxtRg.Clear();
            
        }

        private void mstxtRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        public void chkFechar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mstxtRg_TextChanged(object sender, EventArgs e)
        {
            if (mstxtRg.Text.Length == 12)
            {
                string sql = ("SELECT * FROM VISITA WHERE doc_Visita = '" + mstxtRg.Text + "'");
                DataTable DtRetorno = new DataTable();
                DtRetorno = Banco.Pesquisa(sql);

                if (DtRetorno.Rows.Count > 0)
                {
                    txtNomeVisita.Text = DtRetorno.Rows[0].ItemArray[1].ToString();
                    mstxtRg.Text = DtRetorno.Rows[0].ItemArray[3].ToString();
                    mstxtFone.Text = DtRetorno.Rows[0].ItemArray[4].ToString();
                    rtxtObsVisita.Text = DtRetorno.Rows[0].ItemArray[9].ToString();


                }
            }
        }

        private void txtNomeMorador2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
