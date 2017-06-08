using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;

namespace WindowsFormsMenu
{
    public partial class ViewProjetos : Form
    {
        public ViewProjetos()
        {
            InitializeComponent();
        }

        private void ViewProjetos_Load(object sender, EventArgs e)
        {
            ProjetoController pc = new ProjetoController();
            if (pc.Projetos != null)
            {
                foreach (var pro in pc.Projetos)
                {
                    dataGridView1.Rows.Add(pro.Datainicio, pro.Nome,pro.Tarefa.Tipo.ToString(), pro.User.Username);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Projetos pro = new Projetos(e);
            pro.MdiParent = ActiveForm;
            pro.Show();
        }
    }
}
