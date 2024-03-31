using AdamBień_Wypożyczalnia.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdamBień_Wypożyczalnia
{
    public partial class ChildUC : UserControl
    {
        private Child _child1;
        private int _overallPrice;

        public ChildUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Proszę podać imię!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Proszę podać nazwisko!");
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Proszę podać PESEL!");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Pole 'Zniżka przedszkolna' nie może być puste!");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("Pole 'Zniżka szkolna' nie może być puste!");
            }
            else if (comboBox5.Text == "")
            {
                MessageBox.Show("Pole 'Doświadczone' nie może być puste!");
            }
            else if (comboBox4.Text == "")
            {
                MessageBox.Show("Proszę wybrać długość wypożyczenia!");
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Proszę dodać zdjęcie!");
            }
            else
            {
                _child1 = new Child(textBox1.Text, textBox2.Text, dateTimePicker1.Value, maskedTextBox1.Text, comboBox1.Text, checkBox1.Checked, checkBox4.Checked, checkBox2.Checked, checkBox3.Checked, comboBox2.Text, comboBox3.Text, comboBox5.Text, checkBox5.Checked, checkBox6.Checked, dateTimePicker2.Value, comboBox4.Text, (Bitmap)pictureBox1.Image);
                GetInfo(_child1);
                pictureBox2.Image = _child1._picture;
                _overallPrice = _overallPrice + _child1._price;
                label14.Text = System.Convert.ToString(_overallPrice) + "zł";
                string compare1 = "";
                string compare2 = "";
                foreach (var item in Form1.listP)
                {
                    compare1 = _child1 != item;
                    compare2 = _child1 == item;

                    if (compare2 != "")
                    {
                        listBox1.Items.Add(compare2);
                        listBox1.Items.Add("");
                        break;
                    }
                }

                if (compare2 == "")
                {
                    listBox1.Items.Add(compare1);
                    listBox1.Items.Add("");
                    Form1.listP.Add(_child1);
                }
            }
        }

        private void GetInfo(Child c)
        {
            List<string> cinfo = c.GetInfo();
            foreach (var child in cinfo)
            {
                listBox1.Items.Add(child);
            }
            listBox1.Items.Add(" ");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Nie")
            {
                checkBox6.Visible = true;
            }
            else
            {
                checkBox6.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Krzysztof";
            textBox2.Text = "Bąk";
            comboBox1.Text = "Mężczyzna";
            dateTimePicker1.Value = new DateTime(2015, 4, 14);
            maskedTextBox1.Text = "15746384652";
            checkBox1.Checked = true;
            checkBox4.Checked = true;
            comboBox2.Text = "Nie";
            comboBox3.Text = "Tak";
            comboBox5.Text = "Tak";
            checkBox5.Checked = true;
            dateTimePicker2.Value = new DateTime(2023, 6, 14);
            comboBox4.Text = "1,5 h";
            pictureBox1.ImageLocation = @".\iamge1.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Plik zdjęcia(*.jpg;*.png)|*.jpg;*.png";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (IsValidImage(_openFileDialog.OpenFile()) == true)
                {
                    Bitmap f = new Bitmap(_openFileDialog.OpenFile());
                    pictureBox1.Image = f;
                }
                else
                {
                    MessageBox.Show("Wybrany plik nie jest obrazkiem!");
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Plik zdjęcia(*.jpg;*.png)|*.jpg;*.png";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (IsValidImage(_openFileDialog.OpenFile()) == true)
                {
                    Bitmap f = new Bitmap(_openFileDialog.OpenFile());
                    pictureBox1.Image = f;
                }
                else
                {
                    MessageBox.Show("Wybrany plik nie jest obrazkiem!");
                }

            }
        }

        bool IsValidImage(Stream file)
        {
            try
            {
                using (Image newImage = new Bitmap(file))
                { }
            }
            catch (OutOfMemoryException ex)
            {
                return false;
            }
            catch (ArgumentException ex)
            {
                return false;
            }

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+$"))
            {
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length);
                MessageBox.Show("Proszę używać tylko liter!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+$"))
            {
            }
            else
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length);
                MessageBox.Show("Proszę używać tylko liter!");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Upewnij się, że poprawnie wypełniasz dane!");
        }
    }
}
