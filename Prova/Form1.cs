namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matricula = labMatricula.Text;
            string nome = labNome.Text;
            string funcao = labFuncao.Text;
            string cpf = labCPF.Text;
            string jrpf = labJRPF.Text;
            int salario = Convert.ToInt32(labSalario.Text);

            Funcionario funcionario = new Funcionario(funcao);
            MessageBox.Show();
        }
    }
}