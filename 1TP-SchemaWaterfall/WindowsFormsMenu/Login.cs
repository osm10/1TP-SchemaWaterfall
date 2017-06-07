using _1TP_SchemaWaterfall.Controllers;
using System;
using System.Net.Mime;
using System.Windows.Forms;

namespace WindowsFormsMenu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true; //para ocultar os caracteres da textbox2 password
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MDIWaterfall mw = new MDIWaterfall();
                mw.Show();
                //ValidarLogin(textBox1.Text,textBox2.Text);
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
            RegistarUtilizador ru = new RegistarUtilizador();
            ru.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidarLogin(string username, string password)
        {
            UtilizadorController uc = new UtilizadorController();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor verifique",
                    "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool confirm = uc.ContaValida(username, password);
            if (confirm)
            {
                MDIWaterfall mw = new MDIWaterfall();
                mw.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Username ou password incorrecta.\n\nPor favor verifique",
                    "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
