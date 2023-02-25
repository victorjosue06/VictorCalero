using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictorCalero
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Task DescuentoFacturaAsync()
        {
            return Task.Delay(90000);
        }

        decimal Precio1;
        decimal Precio2;
        decimal Precio3;
        int Cantidad1;
        int Cantidad2;
        int Cantidad3;
        decimal Operacion;
        decimal Descuento;

        private void button1_Click(object sender, EventArgs e)
        {

            comboBox1.Focus();
            Precio1 = Convert.ToDecimal(Precio1TextBox.Text);
            Precio2 = Convert.ToDecimal(Precio2TextBox.Text);
            Precio3 = Convert.ToDecimal(Precio3TextBox.Text);
            Cantidad1 = Convert.ToInt32(Cantidad1TextBox.Text);
            Cantidad2 = Convert.ToInt32(Cantidad2TextBox.Text);
            Cantidad3 = Convert.ToInt32(Cantidad3TextBox.Text);


            Operacion = (Precio1 * Cantidad1) + (Precio2 * Cantidad2) + (Precio3 * Cantidad3);
            Descuento = ((Operacion * 15) / 100);


            SubTotalTextBox.Text = Convert.ToString(Operacion);
            DescuentoTextBox.Text = Convert.ToString(Descuento);
            TotalTextBox.Text = Convert.ToString(Operacion - Descuento);

            DescuentoFacturaAsync();
            MessageBox.Show("Su Descuento es de: " + Descuento);

        }
    }
}
