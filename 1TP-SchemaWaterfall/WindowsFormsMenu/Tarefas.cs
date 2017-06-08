using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Models;

namespace WindowsFormsMenu
{
    public partial class Tarefas : Form
    {
        Projeto nProjeto = new Projeto();
        public Tarefas(Projeto np)
        {
            InitializeComponent();
            if (!NProjeto.Open) return;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            nProjeto = np;
            textBox1.Text = np.Nome;
            textBox2.Text = np.User.Username;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form stfs = new SubTarefas();
            stfs.MdiParent = MDIWaterfall.ActiveForm;
            stfs.Show();
            //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nProjeto.Nome = textBox1.Text;
            nProjeto.User.Username = textBox2.Text;
        }
    }
}
