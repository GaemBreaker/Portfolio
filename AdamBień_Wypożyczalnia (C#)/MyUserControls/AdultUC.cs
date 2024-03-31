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

namespace AdamBień_Wypożyczalnia
{
    public partial class AdultUC : UserControl
    {
        private Adult _adult1;
        private List<string> _size = new List<string>();
        private int _overallPrice;

        public AdultUC()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Proszę podać płeć!");
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Proszę podać PESEL!");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Pole 'Zniżka seniora' nie może być puste!");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("Pole 'Posiada dzieci' nie może być puste!");
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
                _adult1 = new Adult(textBox1.Text, textBox2.Text, dateTimePicker1.Value, maskedTextBox1.Text, comboBox1.Text, checkBox1.Checked, checkBox4.Checked, checkBox2.Checked, checkBox3.Checked, comboBox2.Text, comboBox3.Text, numericUpDown1.Value, dateTimePicker2.Value, comboBox4.Text, (Bitmap)pictureBox1.Image, _size);
                GetInfo(_adult1);
                pictureBox2.Image = _adult1._picture;
                _overallPrice = _overallPrice + _adult1._price;
                label14.Text = System.Convert.ToString(_overallPrice) + "zł";
                _size = new List<string>();
                string compare1 = "";
                string compare2 = "";
                foreach (var item in Form1.listP)
                {
                    compare1 = _adult1 != item;
                    compare2 = _adult1 == item;

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
                    Form1.listP.Add(_adult1);
                }
            }
        }

        private void GetInfo(Adult a)
        {
            List<string> ainfo = a.GetInfo();
            foreach (var adult in ainfo)
            {
                listBox1.Items.Add(adult);
            }
            listBox1.Items.Add(" ");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Tak")
            {
                label9.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                label9.Visible = false;
                numericUpDown1.Visible = false;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            _size.Add(maskedTextBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jan";
            textBox2.Text = "Kowalski";
            comboBox1.Text = "Mężczyzna";
            dateTimePicker1.Value = new DateTime(1990, 8, 23);
            maskedTextBox1.Text = "03125696571";
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            comboBox2.Text = "Tak";
            comboBox3.Text = "Nie";
            dateTimePicker2.Value = new DateTime(2023, 06, 22);
            comboBox4.Text = "1 h";
            maskedTextBox2.Text = "43";
            pictureBox1.ImageLocation = @".\iamge1.jpg";
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z]+$"))
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