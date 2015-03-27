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

        #region "INICIALIZADOR" 

        public Form1()
        {
            InitializeComponent();
            lines = File.ReadAllLines("Cadastro.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                funcionarios.Add(new Funcionario("","","","","","","","","","",""));
                funcionarios[i].fromString(lines[i]);
                listBox1.Items.Add(funcionarios[i].name);
            }
        }

        #endregion

        #region "ADDMETHOD"
        public void Add(object sender, EventArgs e)
        {
            string[] expE = ("!a@a#a$a%a¨a&a*a(a)").Split('a');
            string[] expN = ("1,2,3,4,5,6,7,8,9,0").Split(',');
            bool roda = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox == nome || textBox == sexo || textBox == civil || textBox == profissao)
                    {
                        for (int i = 0; i < expE.Length; i++)
                        { if (textBox.Text.Contains(expE[i])) roda = false; }
                        for (int i = 0; i < expN.Length; i++)
                        { if (textBox.Text.Contains(expN[i])) roda = false; }
                    }

                    if (textBox == filhos || textBox == salario || textBox == telefone)
                    {
                        for (int i = 0; i < expE.Length; i++)
                        { if (textBox.Text.Contains(expE[i])) roda = false; }
                    }

                    if (textBox == sangue)
                    {
                        for (int i = 0; i < expN.Length; i++)
                        { if (textBox.Text.Contains(expN[i])) roda = false; }
                    }

                    if (textBox.Text == string.Empty)
                    {
                        roda = false;
                    }
                }
            }
            if (roda)
            {
                funcionarios.Add(new Funcionario(nome.Text, idade.Text, sexo.Text, profissao.Text, civil.Text,
                    filhos.Text, sangue.Text, email.Text, endereco.Text, salario.Text, telefone.Text));
                listBox1.Items.Add(nome.Text);
            }
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
                    name.Text = "Nome:" + funcionarios[j].name;
                    age.Text = "Idade:" + funcionarios[j].age;
                    blood.Text = "Tipo Sanguíneo:" + funcionarios[j].AOB;
                    estado.Text = "Estado Civil:" + funcionarios[j].civilState;
                    adress.Text = "Endereço:" + funcionarios[j].adress;
                    cell.Text = "Telefone:" + funcionarios[j].cellphone;
                    mail.Text = "E-mail:" + funcionarios[j].email;
                    sex.Text = "Sexo:" + funcionarios[j].sex;
                    job.Text = "Profissão:" + funcionarios[j].job;
                    money.Text = "Salário:" + funcionarios[j].money;
                    kids.Text = "Filhos:" + funcionarios[j].kids;

                }
            }
        }
        #endregion

        #region "SAVEMETHOD"
        private void Save(object sender, EventArgs e)
        {
           //
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
                    if (textBox.Text != "" ) {
                        textBox.Text = "";
                    }
                }
            }
        }
        #endregion
    }
    
}
