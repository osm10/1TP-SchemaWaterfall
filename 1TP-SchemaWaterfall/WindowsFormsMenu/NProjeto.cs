using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Helpers;
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
        Projeto pro = new Projeto();
        UtilizadorController uc = new UtilizadorController();
        
        private void ShowTextBox2()
        {
            foreach (var user in GestorFicheiros.LoadUsers())
            {
                comboBox1.Items.Add(user);
            }
             
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
            pro.Nome = textBox1.Text;

            //ShowTextBox2();

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
