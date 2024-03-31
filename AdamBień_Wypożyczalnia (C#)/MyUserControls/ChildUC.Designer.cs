namespace AdamBień_Wypożyczalnia
{
    partial class ChildUC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            panel2 = new Panel();
            button4 = new Button();
            button1 = new Button();
            comboBox5 = new ComboBox();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            label9 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 198);
            panel1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(461, 91);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(188, 27);
            maskedTextBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mężczyzna", "Kobieta" });
            comboBox1.Location = new Point(562, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(461, 159);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(61, 24);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "Kask";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(338, 159);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(107, 24);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Snowboard";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(205, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(111, 24);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Kijki do nart";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(120, 159);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Narty";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 160);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 11;
            label6.Text = "Wypożycza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 94);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "PESEL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 7;
            label4.Text = "Data urodzenia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 25);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Płeć";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 25);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Imię";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(3, 367);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(794, 424);
            listBox1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(checkBox6);
            panel2.Controls.Add(checkBox5);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 154);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(670, 56);
            button4.Name = "button4";
            button4.Size = new Size(127, 43);
            button4.TabIndex = 24;
            button4.Text = "Uzupełnij";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(670, 107);
            button1.Name = "button1";
            button1.Size = new Size(127, 43);
            button1.TabIndex = 23;
            button1.Text = "Dodaj dane";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Tak", "Nie" });
            comboBox5.Location = new Point(556, 6);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(80, 28);
            comboBox5.TabIndex = 22;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(441, 9);
            label12.Name = "label12";
            label12.Size = new Size(109, 20);
            label12.TabIndex = 21;
            label12.Text = "Doświadczone:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "30 min", "1 h", "1,5 h", "2 h" });
            comboBox4.Location = new Point(168, 122);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 125);
            label11.Name = "label11";
            label11.Size = new Size(159, 20);
            label11.TabIndex = 19;
            label11.Text = "Długość wypożyczenia";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(146, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(258, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 90);
            label10.Name = "label10";
            label10.Size = new Size(137, 20);
            label10.TabIndex = 10;
            label10.Text = "Data wypożyczenia";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(306, 50);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(161, 24);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "Instruktor dla dzieci";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.Visible = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(120, 50);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(180, 24);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Ochraniacze dla dzieci";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 51);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 4;
            label9.Text = "Wypożycza:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Tak", "Nie" });
            comboBox3.Location = new Point(355, 6);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(80, 28);
            comboBox3.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 13);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 2;
            label8.Text = "Zniżka szkolna:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tak", "Nie" });
            comboBox2.Location = new Point(155, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(80, 28);
            comboBox2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 0;
            label7.Text = "Zniżka przedszkolna:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(799, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 172);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(799, 367);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 172);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(823, 178);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 7;
            button2.Text = "Dodaj zdjęcie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(819, 258);
            label15.Name = "label15";
            label15.Size = new Size(136, 20);
            label15.TabIndex = 27;
            label15.Text = "czas wypożyczenia:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(873, 284);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(819, 238);
            label13.Name = "label13";
            label13.Size = new Size(136, 20);
            label13.TabIndex = 25;
            label13.Text = "Suma wydatków za";
            // 
            // ChildUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(label13);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "ChildUC";
            Size = new Size(971, 800);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Panel panel2;
        private Label label7;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private ComboBox comboBox5;
        private Label label12;
        private ComboBox comboBox4;
        private Label label11;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button4;
        private PictureBox pictureBox2;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label15;
        private Label label14;
        private Label label13;
        private MaskedTextBox maskedTextBox1;
    }
}
