namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idade = new System.Windows.Forms.TextBox();
            this.filhos = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.profissao = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.sangue = new System.Windows.Forms.ComboBox();
            this.civil = new System.Windows.Forms.ComboBox();
            this.message = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(447, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "nome";
            this.listBox1.DoubleClick += new System.EventHandler(this.Show);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nome.Location = new System.Drawing.Point(75, 42);
            this.nome.Multiline = true;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(350, 20);
            this.nome.TabIndex = 1;
            this.nome.Tag = "Nome";
            this.nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Tag = "Nome";
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Tag = "Idade";
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(132, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Tag = "Sexo";
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 5;
            this.label4.Tag = "Profissao";
            this.label4.Text = "Profissão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(255, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 6;
            this.label5.Tag = "Salario";
            this.label5.Text = "Salário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(20, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 7;
            this.label6.Tag = "Civil";
            this.label6.Text = "Estado Civil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(242, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 8;
            this.label7.Tag = "Filhos";
            this.label7.Text = "Filhos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(242, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 9;
            this.label8.Tag = "Sangue";
            this.label8.Text = "Tipo Sanguíneo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(20, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 10;
            this.label9.Tag = "Telefone";
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(20, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 11;
            this.label10.Tag = "Email";
            this.label10.Text = "E-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(20, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 12;
            this.label11.Tag = "Endereco";
            this.label11.Text = "Endereço:";
            // 
            // idade
            // 
            this.idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idade.Location = new System.Drawing.Point(75, 73);
            this.idade.Multiline = true;
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(51, 20);
            this.idade.TabIndex = 13;
            this.idade.Tag = "Idade";
            this.idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // filhos
            // 
            this.filhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filhos.Location = new System.Drawing.Point(297, 101);
            this.filhos.Multiline = true;
            this.filhos.Name = "filhos";
            this.filhos.Size = new System.Drawing.Size(51, 20);
            this.filhos.TabIndex = 17;
            this.filhos.Tag = "Filhos";
            this.filhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // endereco
            // 
            this.endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.endereco.Location = new System.Drawing.Point(99, 127);
            this.endereco.Multiline = true;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(326, 20);
            this.endereco.TabIndex = 18;
            this.endereco.Tag = "Endereco";
            this.endereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.telefone.Location = new System.Drawing.Point(99, 153);
            this.telefone.Multiline = true;
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(133, 20);
            this.telefone.TabIndex = 19;
            this.telefone.Tag = "Telefone";
            this.telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // profissao
            // 
            this.profissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.profissao.Location = new System.Drawing.Point(99, 179);
            this.profissao.Multiline = true;
            this.profissao.Name = "profissao";
            this.profissao.Size = new System.Drawing.Size(133, 20);
            this.profissao.TabIndex = 20;
            this.profissao.Tag = "Profissao";
            this.profissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email.Location = new System.Drawing.Point(98, 205);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(326, 20);
            this.email.TabIndex = 21;
            this.email.Tag = "Email";
            this.email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // salario
            // 
            this.salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salario.Location = new System.Drawing.Point(309, 179);
            this.salario.Multiline = true;
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(116, 20);
            this.salario.TabIndex = 22;
            this.salario.Tag = "Salario";
            this.salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressionouTecla);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(104, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(185, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(266, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(23, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Reset);
            // 
            // sexo
            // 
            this.sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.sexo.Location = new System.Drawing.Point(171, 74);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(75, 21);
            this.sexo.TabIndex = 38;
            this.sexo.Tag = "Sexo";
            this.sexo.SelectedIndexChanged += new System.EventHandler(this.indexChanged);
            // 
            // sangue
            // 
            this.sangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sangue.FormattingEnabled = true;
            this.sangue.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.sangue.Location = new System.Drawing.Point(352, 74);
            this.sangue.Name = "sangue";
            this.sangue.Size = new System.Drawing.Size(73, 21);
            this.sangue.TabIndex = 39;
            this.sangue.Tag = "Sangue";
            this.sangue.SelectedIndexChanged += new System.EventHandler(this.indexChanged);
            // 
            // civil
            // 
            this.civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.civil.FormattingEnabled = true;
            this.civil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)",
            "Divorciado(a)"});
            this.civil.Location = new System.Drawing.Point(104, 101);
            this.civil.Name = "civil";
            this.civil.Size = new System.Drawing.Size(128, 21);
            this.civil.TabIndex = 40;
            this.civil.Tag = "Civil";
            this.civil.SelectedIndexChanged += new System.EventHandler(this.indexChanged);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.message.Location = new System.Drawing.Point(77, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 17);
            this.message.TabIndex = 41;
            this.message.Tag = "Nome";
            // 
            // editar
            // 
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editar.Location = new System.Drawing.Point(347, 254);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 42;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.EditButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 295);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.message);
            this.Controls.Add(this.civil);
            this.Controls.Add(this.sangue);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.email);
            this.Controls.Add(this.profissao);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.filhos);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Tag = "Sangue";
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idade;
        private System.Windows.Forms.TextBox filhos;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox profissao;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.ComboBox sangue;
        private System.Windows.Forms.ComboBox civil;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button editar;
    }
}

