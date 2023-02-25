namespace VictorCalero
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InteresTextBox = new System.Windows.Forms.TextBox();
            this.MesesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InteresGanadoTextBox = new System.Windows.Forms.TextBox();
            this.MesSeleccionadoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DE INTERESES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deposito recibido:";
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Enabled = false;
            this.DepositoTextBox.Location = new System.Drawing.Point(269, 45);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(148, 20);
            this.DepositoTextBox.TabIndex = 2;
            this.DepositoTextBox.Text = "200000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tasa de Interes:";
            // 
            // InteresTextBox
            // 
            this.InteresTextBox.Enabled = false;
            this.InteresTextBox.Location = new System.Drawing.Point(269, 78);
            this.InteresTextBox.Name = "InteresTextBox";
            this.InteresTextBox.Size = new System.Drawing.Size(148, 20);
            this.InteresTextBox.TabIndex = 4;
            this.InteresTextBox.Text = "0.015";
            // 
            // MesesListBox
            // 
            this.MesesListBox.FormattingEnabled = true;
            this.MesesListBox.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.MesesListBox.Location = new System.Drawing.Point(68, 150);
            this.MesesListBox.Name = "MesesListBox";
            this.MesesListBox.Size = new System.Drawing.Size(100, 160);
            this.MesesListBox.TabIndex = 6;
            this.MesesListBox.Click += new System.EventHandler(this.MesesListBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intereses Ganados:";
            // 
            // InteresGanadoTextBox
            // 
            this.InteresGanadoTextBox.Location = new System.Drawing.Point(215, 267);
            this.InteresGanadoTextBox.Name = "InteresGanadoTextBox";
            this.InteresGanadoTextBox.Size = new System.Drawing.Size(121, 20);
            this.InteresGanadoTextBox.TabIndex = 8;
            // 
            // MesSeleccionadoTextBox
            // 
            this.MesSeleccionadoTextBox.Location = new System.Drawing.Point(215, 188);
            this.MesSeleccionadoTextBox.Name = "MesSeleccionadoTextBox";
            this.MesSeleccionadoTextBox.Size = new System.Drawing.Size(121, 20);
            this.MesSeleccionadoTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mes Seleccionado:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 90);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione un Mes:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MesSeleccionadoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InteresGanadoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MesesListBox);
            this.Controls.Add(this.InteresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo De Intereses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InteresTextBox;
        private System.Windows.Forms.ListBox MesesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InteresGanadoTextBox;
        private System.Windows.Forms.TextBox MesSeleccionadoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}