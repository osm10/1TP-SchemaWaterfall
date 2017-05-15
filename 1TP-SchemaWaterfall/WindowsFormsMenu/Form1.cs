using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
