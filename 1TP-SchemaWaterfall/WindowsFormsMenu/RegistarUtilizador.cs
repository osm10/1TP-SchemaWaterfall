using System;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace WindowsFormsMenu
{
    public partial class RegistarUtilizador : Form
    {
        public RegistarUtilizador(Form f)
        {
            InitializeComponent();
            //f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataModel data = new DataModel();
            int bident;
            UtilizadorRegisto utrtRegisto = new UtilizadorRegisto {Nome = textBox1.Text};
            if(int.TryParse(textBox2.Text, out bident))
            {
                utrtRegisto.Bident = bident;
            }
            Utilizador ut = new Utilizador() {Username = textBox3.Text, Password = textBox4.Text};
            //utrtRegisto.Utilizador.Username = textBox3.Text;
            //utrtRegisto.Utilizador.Password = textBox4.Text;
            utrtRegisto.Utilizador = ut;
            data.UtilizadorRegisto = utrtRegisto;
            DataModelStore ds = new DataModelStore {DataModel = data};
            //DataModelStore.Instance.DataModel = data;
            
            MessageBox.Show("O utilizador foi registado com sucesso!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
