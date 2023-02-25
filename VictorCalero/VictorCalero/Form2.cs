using System;
using System.Windows.Forms;

namespace VictorCalero
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        decimal Deposito;
        decimal Interes;
        decimal Operacion;

        private void MesesListBox_Click(object sender, EventArgs e)
        {
            MesSeleccionadoTextBox.Text = MesesListBox.SelectedItem.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposito = Convert.ToDecimal(DepositoTextBox.Text);
            Interes = Convert.ToDecimal(InteresTextBox.Text);


            if (MesSeleccionadoTextBox.Text == "Enero")
            {
                Operacion = Deposito * Interes * 1;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Febrero")
            {
                Operacion = Deposito * Interes * 2;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Marzo")
            {
                Operacion = Deposito * Interes * 3;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Abril")
            {
                Operacion = Deposito * Interes * 4;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Mayo")
            {
                Operacion = Deposito * Interes * 5;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Junio")
            {
                Operacion = Deposito * Interes * 6;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Julio")
            {
                Operacion = Deposito * Interes * 7;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Agosto")
            {
                Operacion = Deposito * Interes * 8;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Septiembre")
            {
                Operacion = Deposito * Interes * 9;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Octubre")
            {
                Operacion = Deposito * Interes * 10;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Noviembre")
            {
                Operacion = Deposito * Interes * 11;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
            if (MesSeleccionadoTextBox.Text == "Diciembre")
            {
                Operacion = Deposito * Interes * 12;
                InteresGanadoTextBox.Text = Convert.ToString(Operacion);
            }
        }
    }
}
