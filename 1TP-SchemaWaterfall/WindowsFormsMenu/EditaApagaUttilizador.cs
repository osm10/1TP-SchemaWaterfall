using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Models;

namespace WindowsFormsMenu
{
    public partial class EditaApagaUttilizador : Form
    {
        public int Pos;
        UtilizadorRegisto utr = new UtilizadorRegisto();
        UtilizadorController uc = new UtilizadorController();
        public EditaApagaUttilizador()
        {
            InitializeComponent();
            CenterToParent();
            //List<UtilizadorRegisto> lista = DataModelStore.Instance.DataModel.UtilizadorDados;
            //var bindingList = new BindingList<UtilizadorRegisto>(lista);
            ////var source = new BindingSource(bindingList, null);

            //dataGridView1.DataSource = bindingList;
        }
        private void EditaApagaUttilizador_Load(object sender, EventArgs e)
        {
            if (uc.ListarUtilizadores() != null)
            {
                foreach (var userdados in uc.ListarUtilizadores())
                {
                    dataGridView1.Rows.Add(userdados.Nome, userdados.Bident, userdados.Utilizador.Username);
                }
            }

        }

        private void LoadEdAp()
        {
            if (dataGridView1.CurrentRow != null) Pos = dataGridView1.CurrentRow.Index;
            utr.Nome = dataGridView1[0, Pos].ToString();
            utr.Bident = int.Parse(dataGridView1[1, Pos].Value.ToString());
            utr.Utilizador.Username = dataGridView1[2, Pos].ToString();
            utr.Utilizador.Password = uc.ListarUtilizadores()[Pos].Utilizador.Password;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(utr.Nome) || string.IsNullOrWhiteSpace(utr.Utilizador.Username) ||
                string.IsNullOrWhiteSpace(utr.Bident.ToString()))
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!!!",
                  "Preenchimento Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            utr.Nome = "Ximenez";
            utr.Bident = 123456789;
            utr.Utilizador.Username = "xmz";
            utr.Utilizador.Password = "xpto";
            MessageBox.Show(uc.EditarUtilizador(1,utr) ? "Utilizador alterado com sucesso!" : "Erro!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(uc.RemoverUtilizador(utr.Bident) ? "Utilizador removido com sucesso!" : "Erro!");
            //InitializeComponent();
            //EditaApagaUttilizador_Load(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null) Pos = dataGridView1.CurrentRow.Index;
            utr.Nome = dataGridView1[0, Pos].ToString();
            utr.Bident = int.Parse(dataGridView1[1, Pos].Value.ToString());
            utr.Utilizador.Username = dataGridView1[2, Pos].ToString();
            utr.Utilizador.Password = uc.ListarUtilizadores()[Pos].Utilizador.Password;
        }
    }
}
