﻿using System;
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
            int bident;
            UtilizadorRegisto utrtRegisto = new UtilizadorRegisto();
            utrtRegisto.Nome = textBox1.Text;
            if(int.TryParse(textBox2.Text, out bident))
            {
                utrtRegisto.Bident = bident;
            }
            utrtRegisto.Utilizador.Username = textBox3.Text;
            utrtRegisto.Utilizador.Password = textBox4.Text;

        }
    }
}
