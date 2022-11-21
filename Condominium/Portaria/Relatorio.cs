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
    public partial class Relatorio : Form
    {

        banco Banco = new banco();
        public Relatorio()
        {
            InitializeComponent();
        }

        private void moradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.portariaDBDataSet);

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'portariaDBDataSet.LogVisita' table. You can move, or remove it, as needed.
            this.logVisitaTableAdapter.Fill(this.portariaDBDataSet.LogVisita);
            // TODO: This line of code loads data into the 'portariaDBDataSet.Morador' table. You can move, or remove it, as needed.
            this.moradorTableAdapter.Fill(this.portariaDBDataSet.Morador);
            btnLimpaRel.PerformClick();
            dataGridView1.DataSource = null;
            dateTimePicker1.Enabled = false;
            btnImprimir.Enabled = false;

        }

        private void ckData_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckData_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void btnPesquisaRel_Click(object sender, EventArgs e)
        {
           
            if (txtNomeVisitaRel.Text.Length >0)
            {
                DataTable DtRetorno1 = new DataTable();
                DtRetorno1 = Banco.Pesquisa("SELECT * FROM LogVisita WHERE NomeVisita like '%" + txtNomeVisitaRel.Text + "%'");
                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                string SQL = ("SELECT * FROM LogVisita WHERE NomeVisita like '%" + txtNomeVisitaRel.Text + "%'");
                SqlCommand comando3 = new SqlCommand(SQL, conexao);
                DataTable DtRetorno = new DataTable();
              

                if (DtRetorno1.Rows.Count > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter(comando3);
                    DataTable logVisita = new DataTable();
                    da.Fill(logVisita);
                    dataGridView1.DataSource = logVisita;
                }
                else
                {
                    MessageBox.Show("Não existem registros desta visita no Banco de Dados");
                }
            }
            else if (txtRespVisitaRel.Text.Length >0)
            {
                DataTable DtRetorno1 = new DataTable();
                DtRetorno1 = Banco.Pesquisa("SELECT * FROM LogVisita WHERE Responsavel like'%" + txtRespVisitaRel.Text + "%'");
                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                string SQL = ("SELECT * FROM LogVisita WHERE Responsavel like '%" + txtRespVisitaRel.Text + "%'");
                SqlCommand comando3 = new SqlCommand(SQL, conexao);
                DataTable DtRetorno = new DataTable();

                if (DtRetorno1.Rows.Count > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter(comando3);
                    DataTable logVisita = new DataTable();
                    da.Fill(logVisita);
                    dataGridView1.DataSource = logVisita;
                }
                else
                {
                    MessageBox.Show("Não existem registros desta visita no Banco de Dados");
                }
            }
            else if (txtBlocoVisitaRel.Text.Length > 0 )
            {
                DataTable DtRetorno1 = new DataTable();
                DtRetorno1 = Banco.Pesquisa("SELECT * FROM LogVisita L WHERE L.BlocoVisita ='" + txtBlocoVisitaRel.Text + "'and L.ApartamentoVisita ='" + txtApVisitaRel.Text + "' ");
                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                string SQL = ("SELECT * FROM LogVisita L WHERE L.BlocoVisita ='" + txtBlocoVisitaRel.Text + "'and L.ApartamentoVisita ='" + txtApVisitaRel.Text + "' ");
                SqlCommand comando3 = new SqlCommand(SQL, conexao);
                DataTable DtRetorno = new DataTable();

                if (DtRetorno1.Rows.Count > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter(comando3);
                    DataTable logVisita = new DataTable();
                    da.Fill(logVisita);
                    dataGridView1.DataSource = logVisita;
                }
                else
                {
                    MessageBox.Show("Não existem registros desta visita no Banco de Dados");
                }
            }
            else if (txtApVisitaRel.Text.Length > 0 )
            {
                DataTable DtRetorno1 = new DataTable();
                DtRetorno1 = Banco.Pesquisa("SELECT * FROM LogVisita L WHERE L.ApartamentoVisita ='" + txtApVisitaRel.Text + " and L.BlocoVisita ='" + txtBlocoVisitaRel.Text + "'");
                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                string SQL = ("SELECT * FROM LogVisita L WHERE L.ApartamentoVisita ='" + txtApVisitaRel.Text + " and L.BlocoVisita ='" + txtBlocoVisitaRel.Text + "'");
                SqlCommand comando3 = new SqlCommand(SQL, conexao);
                DataTable DtRetorno = new DataTable();

                if (DtRetorno1.Rows.Count > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter(comando3);
                    DataTable logVisita = new DataTable();
                    da.Fill(logVisita);
                    dataGridView1.DataSource = logVisita;
                }
                else
                {
                    MessageBox.Show("Não existem registros desta visita no Banco de Dados");
                }
            }
            /*else if ( dateTimePicker1.Text.Length>=9)
            {
                
                DataTable DtRetorno1 = new DataTable();
                //String data2 = dateTimePicker1.Value.ToString("ddMMyyyy");

                DtRetorno1 = Banco.Pesquisa("SELECT * FROM LogVisita WHERE DtVisita = '" + dateTimePicker1.Text + "'");
               // DtRetorno1 = Banco.Pesquisa("SELECT DATE_FORMAT(DtVisita, '%d/%m/%Y') AS 'DtVisita' FROM LogVisita WHERE DtVisita=  '" + dateTimePicker1.Value.ToShortDateString() + "'");
                SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
                //    + mstxtRg.Text +"','" + rtxtObsVisita.Text + "' )";
               String SQL = ("SELECT * FROM LogVisita WHERE DtVisita  ='" + dateTimePicker1.Text + "'");
                //string SQL = (" SELECT DATE_FORMAT(DtVisita, '%d/%m/%Y') AS 'DtVisita' FROM LogVisita WHERE DtVisita= '" + dateTimePicker1.Value.ToShortDateString() + "'"); 
                SqlCommand comando3 = new SqlCommand(SQL, conexao);
                DataTable DtRetorno = new DataTable();

                if (DtRetorno1.Rows.Count > 0)
                {

                    SqlDataAdapter da = new SqlDataAdapter(comando3);
                    DataTable logVisita = new DataTable();
                    da.Fill(logVisita);
                    dataGridView1.DataSource = logVisita;

                }
                else
                {
                    MessageBox.Show("Não existem registros desta visita no Banco de Dados");
                }
            }*/
        }

        private void btnLimpaRel_Click(object sender, EventArgs e)
        {
            
            txtRespVisitaRel.Clear();
            txtNomeVisitaRel.Clear();
            txtBlocoVisitaRel.Clear();
            txtApVisitaRel.Clear();
            dataGridView1.DataSource = null;
            
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

       private void dateTimePicker1_ValueChanged(object sender, EventArgs e)           
       {

          // string dia = dateTimePicker1.Value.Date.ToString();
          int ano = dateTimePicker1.Value.Year;
          int mes = dateTimePicker1.Value.Month;
          int dia = dateTimePicker1.Value.Day;

           SqlConnection conexao = new SqlConnection(Properties.Settings.Default.PortariaDBConnectionString);
           conexao.Open();

           string SQL = ("select * from LogVisita WHERE DtVisita = '" + dia.ToString() + "'");
           SqlCommand comando3 = new SqlCommand(SQL, conexao);

           

           SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando3);
           DataTable DtRetorno1 = new DataTable();
           sqlDataAdapter.Fill(DtRetorno1);
           comando3.ExecuteNonQuery();
           dataGridView1.DataSource = DtRetorno1;


           conexao.Close();

          

           
       }

        
    }

    
}
