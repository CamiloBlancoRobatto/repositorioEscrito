namespace capaPresentacion
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(498, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(735, 66);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Agregar vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Matricula:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(668, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 172);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Marca";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(668, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 223);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Modelo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(668, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 278);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Año:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(668, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 320);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 10;
            label6.Text = "Codigo Servicio:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(668, 320);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(614, 378);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(371, 480);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 13;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(829, 378);
            button3.Name = "button3";
            button3.Size = new Size(147, 23);
            button3.TabIndex = 14;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(139, 480);
            button4.Name = "button4";
            button4.Size = new Size(127, 23);
            button4.TabIndex = 15;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(614, 96);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 16;
            label7.Text = "id:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.HideSelection = false;
            textBox6.Location = new Point(668, 93);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 582);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private TextBox textBox6;
    }
}