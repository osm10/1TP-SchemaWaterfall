using _1TP_SchemaWaterfall.Controllers;
using System;
using System.Windows.Forms;

namespace WindowsFormsMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarLogin();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possivel conectar ao ficheiro de dados.\n{exception.Message}", "Erro fatal", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Application.Run(new Form1());
            // Navigate to a URL.
            //System.Diagnostics.Process.Start("http://www.microsoft.com");
            RegistarUtilizador ru = new RegistarUtilizador(this);
            ru.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarLogin()
        {

            var username = textBox1.Text;
            var password = textBox2.Text;

            var pass = UtilizadorController.GetPassword(username, password);
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor verifique",
                    "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pass != password)
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor verifique",
                    "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
