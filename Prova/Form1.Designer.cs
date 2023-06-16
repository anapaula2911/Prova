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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 97);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 3;
            label2.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(128, 131);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(128, 169);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 5;
            label4.Text = "Função";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MistyRose;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(128, 213);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 6;
            label5.Text = "Salário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MistyRose;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(128, 263);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 7;
            label6.Text = "Salário Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MistyRose;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(433, 131);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 8;
            label7.Text = "CPF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.MistyRose;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(427, 263);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 9;
            label8.Text = "JRPF";
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(128, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Location = new Point(427, 333);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
    }
}