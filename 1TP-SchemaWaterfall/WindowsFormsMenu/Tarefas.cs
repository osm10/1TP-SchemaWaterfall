using System;
using System.Windows.Forms;

namespace WindowsFormsMenu
{
    public partial class Tarefas : Form
    {
        public Tarefas()
        {
            InitializeComponent();
            if (!NProjeto.Open) return;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
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

     
    }
}
