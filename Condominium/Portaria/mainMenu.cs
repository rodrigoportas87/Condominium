using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
{
    public partial class mainMenu : Form
    {
        public string Blocos = null;
        public mainMenu()
        {
            InitializeComponent();
        
        }

       
        private void moradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVisita cadastro = new CadVisita();
            cadastro.Show();

        }

        

        public void button1_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco ="1A";
            ap.Show();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "1B" ;
            ap.Show();
        }
        public void button3_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "2A";
            ap.Show();
        }
        public void button4_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "2B";
            ap.Show();
        }
        public void button5_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "3A";
            ap.Show();
        }
        public void button10_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "3B";
            ap.Show();
        }
        public void button9_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "4A";
            ap.Show();
        }
        public void button8_Click(object sender, EventArgs e)
        {
           
            apartamento ap = new apartamento();
            ap.Bloco = "4B";
            ap.Show();
        }
        public void button7_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "5A";
            ap.Show();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            
            apartamento ap = new apartamento();
            ap.Bloco = "5B";
            ap.Show();
        }
       
       

        private void poVisitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            cadastro cadastro = new cadastro();
            cadastro.Show();
        }

        private void moradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void moradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroMorador morador = new CadastroMorador();
            morador.Show();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'portariaDBDataSet.Morador' table. You can move, or remove it, as needed.
            this.moradorTableAdapter.Fill(this.portariaDBDataSet.Morador);

        }

        private void moradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.portariaDBDataSet);

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
        }



        
    }
}
