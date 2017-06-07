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
    }
}
