using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;

namespace WindowsFormsMenu
{
    public partial class Projetos : Form
    {
        private DataGridViewCellEventArgs ev;
        ProjetoController pc = new ProjetoController();
        public Projetos(DataGridViewCellEventArgs e)
        {
            InitializeComponent();
            ev = e;
        }

        private void Projeto_Load(object sender, EventArgs e)
        {        
            label5.Text = pc.Projetos[ev.RowIndex].Nome;
            label6.Text = pc.Projetos[ev.RowIndex].Datainicio.ToString();
            textBox2.Text = pc.Projetos[ev.RowIndex].User.Username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tarefas = new Tarefas(pc.Projetos[ev.RowIndex],ev.RowIndex);
            tarefas.MdiParent = ActiveForm;
            tarefas.Show();
            //Form subtarefas = new SubTarefas();
            //subtarefas.MdiParent = ActiveForm;
            //subtarefas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pc.RemoverProjeto(pc.Projetos[ev.RowIndex]) ? "Projeto Apagado com sucesso!" : "Erro!");
        }
    }
}
