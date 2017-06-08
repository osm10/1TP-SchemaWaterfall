using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Models;

namespace WindowsFormsMenu
{
    public partial class Tarefas : Form
    {
        ProjetoController pc = new ProjetoController();
        Projeto nProjeto = new Projeto();
        private int indice;
        public Tarefas(Projeto np, int ind)
        {
            InitializeComponent();
            //if (!NProjeto.Open) return;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            nProjeto = np;
            indice = ind;
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
            Form stfs = new SubTarefas();
            stfs.MdiParent = MDIWaterfall.ActiveForm;
            stfs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form stfs = new SubTarefas();
            stfs.MdiParent = MDIWaterfall.ActiveForm;
            stfs.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form stfs = new SubTarefas();
            stfs.MdiParent = MDIWaterfall.ActiveForm;
            stfs.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form stfs = new SubTarefas();
            stfs.MdiParent = MDIWaterfall.ActiveForm;
            stfs.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form stfs = new SubTarefas();
            stfs.MdiParent = MDIWaterfall.ActiveForm;
            stfs.Show();
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
            if (pc.EditarProjetos(indice, nProjeto))
            {
                MessageBox.Show("Alterações feitas com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro!!!");
            }
            
        }

        private void Tarefas_Load(object sender, EventArgs e)
        {
            switch (nProjeto.Tarefa.Tipo)
            {
                case TarefaTipo.Analysis:
                    button1.Enabled = true;
                    break;
                case TarefaTipo.Designing:
                    button2.Enabled = true;                   
                    break;
                case TarefaTipo.Coding:
                    button3.Enabled = true;
                    break;
                case TarefaTipo.Testing:
                    button4.Enabled = true; 
                    break;
                case TarefaTipo.Implementation:
                    button5.Enabled = true;
                    break;               
                case TarefaTipo.Maintenance:
                    button6.Enabled = true;
                    break;

            }
        }
    }
}
