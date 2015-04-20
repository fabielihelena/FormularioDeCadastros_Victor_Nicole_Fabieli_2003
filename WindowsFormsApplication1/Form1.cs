using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        public string[] lines;
        public string[] newLines;
        bool roda2 = false;

        public void changeColor(TextBox s,string a)
        {
//            string o = string.Empty;
            foreach (Control d in this.Controls)
            {
                if (d is Label)
                {
                    if (s.Tag == d.Tag)
                    {
                        d.ForeColor = Color.Red;
                        message.Text = "Preencha todos os campos";
                    }
                }
            }
            
        }


        #region "INICIALIZADOR" 

        public Form1()
        {
            InitializeComponent();
            try
            {
                lines = File.ReadAllLines("Cadastro.txt");
                using (StreamReader file = new StreamReader("Cadastro.txt"))
                {
                    if (!string.IsNullOrWhiteSpace(file.ReadLine()))
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            Console.WriteLine(lines);
                            funcionarios.Add(new Funcionario("", "", "", "", "", "", "", "", "", "", ""));
                            funcionarios[i].fromString(lines[i]);
                            listBox1.Items.Add(funcionarios[i].name);
                        }
                    }
                }
            }
            catch (ArgumentNullException r) 
            {
                File.CreateText("Cadastro.txt");
            }
        }

        #endregion

        #region "ADDMETHOD"
        public void Add(object sender, EventArgs e)
        {
                bool roda = true;
                message.ForeColor = Color.Red;
                    foreach (Control c in this.Controls)
                    {
                        if (c is ComboBox)
                        {
                            foreach (Control d in this.Controls)
                            {
                                if (d is Label)
                                {
                                    if(string.IsNullOrWhiteSpace((c as ComboBox).Text))
                                    if (d.Tag == (c as ComboBox).Tag) d.ForeColor = Color.Red;
                                }
                            }
                        }
                        if (c is TextBox)
                        {
                            TextBox textBox = c as TextBox;
                            if (string.IsNullOrWhiteSpace(textBox.Text))
                            {
                                changeColor(textBox, "Precisa preencher todos os campos");
                                roda = false;
                            }

                        }
                    }
            //------------ Verificar email
                    string[] splitEmail = email.Text.Split('@');
                    Console.WriteLine(splitEmail.Length);
                    if (splitEmail.Length > 2) { roda = false; changeColor(email, "Emailinvalido"); }
                    else if (splitEmail.Length <= 1) { roda = false; changeColor(email, "Emailinvalido"); }

                    if (roda && roda2)
                    {
                        funcionarios.Add(new Funcionario(nome.Text, idade.Text, sexo.Text, profissao.Text, civil.Text,
                            filhos.Text, sangue.Text, email.Text, endereco.Text, salario.Text, telefone.Text));
                        listBox1.Items.Add(nome.Text);

                        
                        
                    }
                    
                    Save();
        }
        #endregion

        #region "REMOVEMETHOD"
        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                bool i  = listBox1.GetSelected(j);
                if (i)
                {
                    listBox1.Items.RemoveAt(j);
                    funcionarios.RemoveAt(j);
                }
            }
            Save();
        }


        #endregion

        #region "SHOWMETHOD"
        private void Show(object sender, EventArgs e)
        {
            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                bool i = listBox1.GetSelected(j);
                if (i)
                {
                    nome.Text =  funcionarios[j].name;
                    idade.Text =  funcionarios[j].age;
                    sangue.Text =  funcionarios[j].AOB;
                    civil.Text =  funcionarios[j].civilState;
                    endereco.Text =  funcionarios[j].adress;
                    telefone.Text =  funcionarios[j].cellphone;
                    email.Text =  funcionarios[j].email;
                    sexo.Text =  funcionarios[j].sex;
                    profissao.Text =  funcionarios[j].job;
                    salario.Text =  funcionarios[j].money;
                    filhos.Text =  funcionarios[j].kids;

                }
            }
            Save();
        }
        #endregion

        #region "SAVEMETHOD"
        private void Save()
        {
            newLines = new string[funcionarios.Count];
            for (int i = 0; i < funcionarios.Count; i++)
            {
                newLines[i] = funcionarios[i].asString();
            }
            File.WriteAllLines("Cadastro.txt", newLines);
        }

        private void Reset(object sender, EventArgs e)
        {
            foreach (Control r in this.Controls)
            {
                if (r is TextBox)
                {
                    TextBox textBox = r as TextBox;
                    if (textBox.Text != "") {
                        textBox.Text = "";
                    }
                }

                if (r is ComboBox)
                {
                    ComboBox comboBox = r as ComboBox;
                    comboBox.SelectedIndex = -1;
                    foreach (Control j in this.Controls)
                    {
                        if (j is Label)
                        {
                            if (comboBox.Tag == j.Tag) (j as Label).ForeColor = Color.Black;
                        }
                    }
                }

            }
        }
        #endregion

        private void pressionouTecla(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            //Console.WriteLine("pressionouTecla");
            //Console.WriteLine(e.KeyChar);
            //Console.WriteLine((sender as TextBox).Text);
            if (e.KeyChar.Equals((char)8))
            {
                e.Handled = false;
            }

            else if (((sender as TextBox) == idade )|| ((sender as TextBox) == filhos))
            {
                string valid = "0123456789";
                e.Handled = (valid.IndexOf(e.KeyChar) == -1);
            }

            else if ((sender as TextBox) == telefone)
            {
                string valid = "0123456789 -/()";
                e.Handled = (valid.IndexOf(e.KeyChar) == -1);
            }

            else if ((sender as TextBox) == nome || (sender as TextBox) == profissao)
            {
                string valid = "abcdefghijklmnopqrstuvwxyz áéíóúâêîôûãõ";
                valid += valid.ToUpper();
                e.Handled = (valid.IndexOf(e.KeyChar) < 0);
            }

            else if ((sender as TextBox) == salario)
            {
                string valid = "0123456789,";
                e.Handled = (valid.IndexOf(e.KeyChar) < 0);
            }

            else if ((sender as TextBox) == endereco)
            {
                string valid = "abcdefghijklmnopqrstuvwxyz /-()º°áéíóúâêîôûãõ";
                valid += valid.ToUpper();
                valid += "1234567890,";
                e.Handled = (valid.IndexOf(e.KeyChar) < 0);
            }

            else if ((sender as TextBox) == email)
            {
                string valid = "abcdefghijklmnopqrstuvwxyz /-_1234567890@.,";
                valid += valid.ToUpper();
                e.Handled = (valid.IndexOf(e.KeyChar) < 0);
            }

            if (!e.Handled)
            {
                foreach (Control d in this.Controls)
                {
                    if (d is Label)
                    {
                        if ((sender as TextBox).Tag == d.Tag)
                        {
                            if (!string.IsNullOrWhiteSpace((sender as TextBox).Text))
                            {
                                d.ForeColor = Color.Black;
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void indexChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace((sender as ComboBox).Text) )
            {
                roda2 = false;
                foreach (Control d in this.Controls)
                {
                    if (d is Label)
                    {
                        if (d.Tag == (sender as ComboBox).Tag) d.ForeColor = Color.Red;
                    }
                }
            }
            else{
                roda2= true;
                foreach (Control d in this.Controls)
                {
                    if (d is Label)
                    {
                        if (d.Tag == (sender as ComboBox).Tag) d.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void EditButton(object sender, EventArgs e)
        {
            string[] splitEmail = email.Text.Split('@');
            Console.WriteLine(splitEmail.Length);
            if (splitEmail.Length == 2)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    bool i = listBox1.GetSelected(j);
                    if (i)
                    {
                        if (!string.IsNullOrWhiteSpace(nome.Text))
                        {
                            funcionarios[j].name = nome.Text;
                            listBox1.Items[j] = nome.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(idade.Text))
                        {
                            funcionarios[j].age = idade.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(filhos.Text))
                        {
                            funcionarios[j].kids = filhos.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(endereco.Text))
                        {
                            funcionarios[j].adress = endereco.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(telefone.Text))
                        {
                            funcionarios[j].cellphone = telefone.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(profissao.Text))
                        {
                            funcionarios[j].job = profissao.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(email.Text))
                        {
                            funcionarios[j].email = email.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(salario.Text))
                        {
                            funcionarios[j].money = salario.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(sexo.Text))
                        {
                            funcionarios[j].sex = sexo.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(sangue.Text))
                        {
                            funcionarios[j].AOB = sangue.Text;
                        }
                        if (!string.IsNullOrWhiteSpace(civil.Text))
                        {
                            funcionarios[j].civilState = civil.Text;
                        }
                    }
                }
                message.Text = "";
                message.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
            }
            else
            {
                message.Text = "Email Inválido";
                message.ForeColor = Color.Red;
                label10.ForeColor = Color.Red;
            }

            Save();
        }
    }
    
}
