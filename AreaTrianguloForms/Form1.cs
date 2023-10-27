namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        try
        { 
            double n1, n2, resultado;
            n1 = double.Parse(txtBase.Text);
            n2 = double.Parse(txtAltura.Text);

            resultado = (n1 * n2) / 2;

            txtResultado.Text = resultado.ToString();

        }
        catch
         {
                MessageBox.Show("Dados informados estão invalidos!");
                //Limpar txt:
                txtResultado.Clear();
                txtBase.Clear();
                txtAltura.Clear();

         }
    }
    }
}