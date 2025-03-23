namespace Futbol
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Font = new Font("Century", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ficha Tecnica del Equipo";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Constantia", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Portero", "Línea de defensa", "Mediocentro", "Mediapunta", "Mediocentro defensivo", "Interior", "Delantero" });
            comboBox1.Location = new Point(238, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 30);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "               ~-ELIJA-~";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Constantia", 9F);
            textBox3.Location = new Point(238, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 29);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Constantia", 9F);
            textBox1.Location = new Point(238, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 192);
            label4.Name = "label4";
            label4.Size = new Size(176, 32);
            label4.TabIndex = 4;
            label4.Text = "Numero de Puntos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 123);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 3;
            label3.Text = "Elija Jugador:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 54);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre Equipo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(126, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(148, 247);
            button5.Name = "button5";
            button5.Size = new Size(199, 37);
            button5.TabIndex = 0;
            button5.Text = "Cargar Escudo...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(button6);
            groupBox2.Font = new Font("Century", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(557, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 442);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ficha Tecnica del Jugador";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Constantia", 9F);
            textBox7.Location = new Point(130, 88);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(184, 29);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Constantia", 9F);
            textBox6.Location = new Point(130, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 29);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Constantia", 9F);
            textBox5.Location = new Point(130, 134);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 29);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Constantia", 9F);
            textBox4.Location = new Point(130, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 29);
            textBox4.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Constantia", 9F);
            textBox2.Location = new Point(130, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 29);
            textBox2.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 233);
            label9.Name = "label9";
            label9.Size = new Size(89, 32);
            label9.TabIndex = 6;
            label9.Text = "Estatura:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 185);
            label8.Name = "label8";
            label8.Size = new Size(88, 32);
            label8.TabIndex = 5;
            label8.Text = "Posicion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 140);
            label7.Name = "label7";
            label7.Size = new Size(63, 32);
            label7.TabIndex = 4;
            label7.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 88);
            label6.Name = "label6";
            label6.Size = new Size(88, 32);
            label6.TabIndex = 3;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 42);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 2;
            label5.Text = "Numero:";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(198, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(40, 334);
            button6.Name = "button6";
            button6.Size = new Size(124, 38);
            button6.TabIndex = 0;
            button6.Text = "Cargar Foto...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Palatino Linotype", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 528);
            button1.Name = "button1";
            button1.Size = new Size(209, 77);
            button1.TabIndex = 2;
            button1.Text = "Guardar Datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Palatino Linotype", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(296, 530);
            button2.Name = "button2";
            button2.Size = new Size(188, 75);
            button2.TabIndex = 3;
            button2.Text = "Nuevo Registro";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Font = new Font("Palatino Linotype", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(579, 528);
            button3.Name = "button3";
            button3.Size = new Size(156, 74);
            button3.TabIndex = 4;
            button3.Text = "Ver Datos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Font = new Font("Palatino Linotype", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(780, 530);
            button4.Name = "button4";
            button4.Size = new Size(167, 77);
            button4.TabIndex = 5;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 19);
            label1.Name = "label1";
            label1.Size = new Size(525, 43);
            label1.TabIndex = 6;
            label1.Text = "REGISTRO EQUIPO FUTBOL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(978, 625);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
        private PictureBox pictureBox2;
        private Button button6;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}
