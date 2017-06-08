using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Models;

namespace WindowsFormsMenu
{
    public partial class SubTarefas : Form
    {
        Subtarefa subtarefa = new Subtarefa();
        public SubTarefas()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            subtarefa.Datainicio = dateTimePicker1.Value;
            subtarefa.Datafinal = dateTimePicker2.Value;
            subtarefa.Descricao = textBox1.Text;

            if(string.IsNullOrWhiteSpace(subtarefa.Descricao) || string.IsNullOrWhiteSpace(subtarefa.Datainicio.ToString()) || string.IsNullOrWhiteSpace(subtarefa.Datafinal.ToString()))
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!");
            }
            else
            {
                subtarefa.SubtarefasList.Add(subtarefa);
                MessageBox.Show("Subtarefa finalizada com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
