using _1TP_SchemaWaterfall.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsMenu
{
    public partial class MDIWaterfall : Form
    {
        private int childFormNumber = 0;

        public MDIWaterfall()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new NProjeto();
            childForm.MdiParent = this;
            childForm.Text = "Novo Projeto " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                using (StreamReader r = new StreamReader(FileName))
                {
                    string json = r.ReadToEnd();
                    var pros = JsonConvert.DeserializeObject<List<Projeto>>(json);
                }
                Projetos projetos = new Projetos();
                projetos.MdiParent = this;
                projetos.Show();
            }

           
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void criarUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ru = new RegistarUtilizador();
            ru.MdiParent = this;
            ru.Show();
        }

        private void apagarUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form apagaUttilizador = new EditaApagaUttilizador();
            apagaUttilizador.MdiParent = this;
            apagaUttilizador.Show();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vpros = new ViewProjetos();
            vpros.MdiParent = this;
            vpros.Show();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vuts = new ViewUtilizadores();
            vuts.MdiParent = this;
            vuts.Show();
        }

    }
}
