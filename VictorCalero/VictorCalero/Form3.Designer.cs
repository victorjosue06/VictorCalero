namespace VictorCalero
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Cantidad1TextBox = new System.Windows.Forms.TextBox();
            this.Precio3TextBox = new System.Windows.Forms.TextBox();
            this.Cantidad3TextBox = new System.Windows.Forms.TextBox();
            this.Precio2TextBox = new System.Windows.Forms.TextBox();
            this.Cantidad2TextBox = new System.Windows.Forms.TextBox();
            this.Precio1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HUEVOS",
            "ARROZ",
            "FRIJOLES"});
            this.comboBox1.Location = new System.Drawing.Point(22, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "HUEVOS",
            "ARROZ",
            "FRIJOLES"});
            this.comboBox2.Location = new System.Drawing.Point(22, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "HUEVOS",
            "ARROZ",
            "FRIJOLES"});
            this.comboBox3.Location = new System.Drawing.Point(22, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(123, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // Cantidad1TextBox
            // 
            this.Cantidad1TextBox.Location = new System.Drawing.Point(175, 90);
            this.Cantidad1TextBox.Name = "Cantidad1TextBox";
            this.Cantidad1TextBox.Size = new System.Drawing.Size(97, 20);
            this.Cantidad1TextBox.TabIndex = 4;
            // 
            // Precio3TextBox
            // 
            this.Precio3TextBox.Location = new System.Drawing.Point(293, 163);
            this.Precio3TextBox.Name = "Precio3TextBox";
            this.Precio3TextBox.Size = new System.Drawing.Size(121, 20);
            this.Precio3TextBox.TabIndex = 9;
            // 
            // Cantidad3TextBox
            // 
            this.Cantidad3TextBox.Location = new System.Drawing.Point(175, 163);
            this.Cantidad3TextBox.Name = "Cantidad3TextBox";
            this.Cantidad3TextBox.Size = new System.Drawing.Size(97, 20);
            this.Cantidad3TextBox.TabIndex = 8;
            // 
            // Precio2TextBox
            // 
            this.Precio2TextBox.Location = new System.Drawing.Point(293, 126);
            this.Precio2TextBox.Name = "Precio2TextBox";
            this.Precio2TextBox.Size = new System.Drawing.Size(121, 20);
            this.Precio2TextBox.TabIndex = 7;
            // 
            // Cantidad2TextBox
            // 
            this.Cantidad2TextBox.Location = new System.Drawing.Point(175, 126);
            this.Cantidad2TextBox.Name = "Cantidad2TextBox";
            this.Cantidad2TextBox.Size = new System.Drawing.Size(97, 20);
            this.Cantidad2TextBox.TabIndex = 6;
            // 
            // Precio1TextBox
            // 
            this.Precio1TextBox.Location = new System.Drawing.Point(293, 90);
            this.Precio1TextBox.Name = "Precio1TextBox";
            this.Precio1TextBox.Size = new System.Drawing.Size(121, 20);
            this.Precio1TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione un Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "SubTotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Descuento:";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(293, 235);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(121, 83);
            this.CalcularButton.TabIndex = 19;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Enabled = false;
            this.SubTotalTextBox.Location = new System.Drawing.Point(175, 215);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(97, 20);
            this.SubTotalTextBox.TabIndex = 20;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Enabled = false;
            this.DescuentoTextBox.Location = new System.Drawing.Point(175, 267);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(97, 20);
            this.DescuentoTextBox.TabIndex = 21;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(175, 316);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(97, 20);
            this.TotalTextBox.TabIndex = 22;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 384);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Precio1TextBox);
            this.Controls.Add(this.Cantidad2TextBox);
            this.Controls.Add(this.Precio2TextBox);
            this.Controls.Add(this.Cantidad3TextBox);
            this.Controls.Add(this.Precio3TextBox);
            this.Controls.Add(this.Cantidad1TextBox);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox Cantidad1TextBox;
        private System.Windows.Forms.TextBox Precio3TextBox;
        private System.Windows.Forms.TextBox Cantidad3TextBox;
        private System.Windows.Forms.TextBox Precio2TextBox;
        private System.Windows.Forms.TextBox Cantidad2TextBox;
        private System.Windows.Forms.TextBox Precio1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
    }
}