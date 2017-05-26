using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Models;

namespace WindowsFormsMenu
{
    public partial class NProjeto : Form
    {
        public static bool Open { get; set; }
        public NProjeto()
        {
            InitializeComponent();
            Open = true;
            ShowTextBox2();
        }

        private void ShowTextBox2()
        {
            textBox2.Text += comboBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Projeto pro = new Projeto();
            UtilizadorController uc = new UtilizadorController();
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
            pro.Nome = textBox1.Text;

            foreach (var ut in uc.Utilizadores)
            {
                comboBox1.Items.Add(ut);
                textBox2.Text = comboBox1.Text;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Tarefas fTarefas = new Tarefas();
            fTarefas.Show();
            //Open = false;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
