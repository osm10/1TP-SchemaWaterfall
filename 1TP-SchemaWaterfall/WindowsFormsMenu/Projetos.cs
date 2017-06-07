using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;

namespace WindowsFormsMenu
{
    public partial class Projetos : Form
    {
        public Projetos()
        {
            InitializeComponent();
        }

        private void Projeto_Load(object sender, EventArgs e)
        {
            ProjetoController pc = new ProjetoController();
            label5.Text = pc.Projetos[0].Nome;
            label6.Text = pc.Projetos[0].Datainicio.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tarefas = new Tarefas();
            tarefas.MdiParent = this;
            tarefas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
