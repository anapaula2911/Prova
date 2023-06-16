namespace Prova
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labMatricula = new Label();
            labNome = new Label();
            labFuncao = new Label();
            labSalario = new Label();
            labCPF = new Label();
            labJRPF = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 21);
            label1.Name = "label1";
            label1.Size = new Size(516, 50);
            label1.TabIndex = 2;
            label1.Text = "CADASTRO DE FUNCIONÁRIO";
            // 
            // labMatricula
            // 
            labMatricula.AutoSize = true;
            labMatricula.BackColor = Color.MistyRose;
            labMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMatricula.Location = new Point(128, 97);
            labMatricula.Name = "labMatricula";
            labMatricula.Size = new Size(75, 21);
            labMatricula.TabIndex = 3;
            labMatricula.Text = "Matricula";
            // 
            // labNome
            // 
            labNome.AutoSize = true;
            labNome.BackColor = Color.MistyRose;
            labNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labNome.Location = new Point(133, 146);
            labNome.Name = "labNome";
            labNome.Size = new Size(53, 21);
            labNome.TabIndex = 4;
            labNome.Text = "Nome";
            // 
            // labFuncao
            // 
            labFuncao.AutoSize = true;
            labFuncao.BackColor = Color.MistyRose;
            labFuncao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFuncao.Location = new Point(128, 194);
            labFuncao.Name = "labFuncao";
            labFuncao.Size = new Size(60, 21);
            labFuncao.TabIndex = 5;
            labFuncao.Text = "Função";
            // 
            // labSalario
            // 
            labSalario.AutoSize = true;
            labSalario.BackColor = Color.MistyRose;
            labSalario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSalario.Location = new Point(128, 249);
            labSalario.Name = "labSalario";
            labSalario.Size = new Size(58, 21);
            labSalario.TabIndex = 6;
            labSalario.Text = "Salário";
            // 
            // labCPF
            // 
            labCPF.AutoSize = true;
            labCPF.BackColor = Color.MistyRose;
            labCPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labCPF.Location = new Point(435, 97);
            labCPF.Name = "labCPF";
            labCPF.Size = new Size(37, 21);
            labCPF.TabIndex = 8;
            labCPF.Text = "CPF";
            labCPF.Click += label7_Click;
            // 
            // labJRPF
            // 
            labJRPF.AutoSize = true;
            labJRPF.BackColor = Color.MistyRose;
            labJRPF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labJRPF.Location = new Point(435, 171);
            labJRPF.Name = "labJRPF";
            labJRPF.Size = new Size(43, 21);
            labJRPF.TabIndex = 9;
            labJRPF.Text = "JRPF";
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(128, 325);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(515, 325);
            button2.Name = "button2";
            button2.Size = new Size(129, 45);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(209, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MistyRose;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(209, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.MistyRose;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(209, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 23);
            textBox4.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.MistyRose;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(484, 169);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 23);
            textBox6.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.MistyRose;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Médico", "Téquinico em Informática", "Administração" });
            comboBox1.Location = new Point(209, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 23);
            comboBox1.TabIndex = 19;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.MistyRose;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(484, 95);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 23);
            maskedTextBox1.TabIndex = 22;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labJRPF);
            Controls.Add(labCPF);
            Controls.Add(labSalario);
            Controls.Add(labFuncao);
            Controls.Add(labNome);
            Controls.Add(labMatricula);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labMatricula;
        private Label labNome;
        private Label labFuncao;
        private Label labSalario;
        private Label labCPF;
        private Label labJRPF;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private MaskedTextBox maskedTextBox1;
    }
}