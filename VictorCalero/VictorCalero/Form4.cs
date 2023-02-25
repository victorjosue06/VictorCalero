using System;
using System.Windows.Forms;

namespace VictorCalero
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        int i = 0;
        private void ContarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
                if (i % 3 == 1)
                {
                    NumerosListBox.Items.Add(NombreTextBox.Text);
                }

            for (int i = 0; i <= 100; i++)
                if (i % 5 == 1)
                {
                    NumerosListBox.Items.Add(ApellidoTextBox.Text);
                }

        }
    }
}
