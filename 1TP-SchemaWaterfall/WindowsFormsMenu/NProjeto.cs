﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Helpers;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

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
        
        //Tarefa tarefa = new Tarefa();
        private string mytextbox2; 
        private void ShowTextBox2()
        {
            foreach (Utilizador utilizador in DataModelStore.Instance.DataModel.UtilizadorList)
            {
                comboBox1.Items.Add(utilizador.Username);
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            try
            {            
                //tarefa.Tipo = TarefaTipo.Analysis;
                pro.Nome = textBox1.Text;
                pro.User.Username = mytextbox2;
                //pro.Tarefas.Add(tarefa);
                pro.Tarefa.Tipo= TarefaTipo.Analysis;

                if (DataModelStore.Instance.DataModel.ProjetosList != null)
                {
                    var projetos = DataModelStore.Instance.DataModel.ProjetosList;
                    projetos.Add(pro);
                    GestorFicheiros.GravaProjetos(projetos);
                }
                else
                {
                    List<Projeto> projetos = new List<Projeto> { pro };
                    GestorFicheiros.GravaProjetos(projetos);
                }
                MessageBox.Show("O Projeto foi gravado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
          
            //ShowTextBox2();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form fTarefas = new Tarefas(pro, DataModelStore.Instance.DataModel.ProjetosList.Count-1);
            fTarefas.MdiParent = MDIWaterfall.ActiveForm;
            fTarefas.Show();
            //Open = false;
            //Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text += comboBox1.SelectedItem + @"; ";
            mytextbox2 += textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pro.Datainicio = dateTimePicker1.Value;
        }
    }
}
