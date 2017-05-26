using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using _1TP_SchemaWaterfall.Helpers;
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
            textBox4.UseSystemPasswordChar = true; //para ocultar os caracteres do input da textbox4
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataModel data = new DataModel();
            int bident;
            UtilizadorRegisto utrRegisto = new UtilizadorRegisto {Nome = textBox1.Text};
            if(int.TryParse(textBox2.Text, out bident))
            {
                utrRegisto.Bident = bident;
            }
            Utilizador ut = new Utilizador() {Username = textBox3.Text, Password = textBox4.Text};
            //utrtRegisto.Utilizador.Username = textBox3.Text;
            //utrtRegisto.Utilizador.Password = textBox4.Text;
            utrRegisto.Utilizador = ut;
            data.UtilizadorRegisto.Add(utrRegisto); 
            //DataModelStore ds = new DataModelStore {DataModel = data};
            DataModelStore.Instance.DataModel=data;

            GestorFicheiros.GravarDataModel();

            MessageBox.Show("O utilizador foi registado com sucesso!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
