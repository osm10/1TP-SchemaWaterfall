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
    public partial class ViewUtilizadores : Form
    {
        public ViewUtilizadores()
        {
            InitializeComponent();           
        }

        private void ViewUtilizadores_Load(object sender, EventArgs e)
        {
            UtilizadorController uc = new UtilizadorController();
            if (uc.ListarUtilizadores() != null)
            {
                foreach (var userdados in uc.ListarUtilizadores())
                {
                    dataGridView1.Rows.Add(userdados.Nome, userdados.Bident, userdados.Utilizador.Username);
                }
            }
        }
    }
}
