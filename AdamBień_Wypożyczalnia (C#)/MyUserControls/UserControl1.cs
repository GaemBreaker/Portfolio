using AdamBień_Wypożyczalnia.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBień_Wypożyczalnia.MyUserControls
{
    public partial class UserControl1 : UserControl
    {
        int _index = -1;

        public UserControl1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            listBox1.Items.Clear();
            _index--;
            WriteInfo(Form1.listP[_index]);
            UpdateButtons();
            PriceSum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            listBox1.Items.Clear();
            _index++;
            WriteInfo(Form1.listP[_index]);
            UpdateButtons();
            PriceSum();
        }

        private void WriteInfo(Person p)
        {
            List<string> pinfo = p.GetInfo();
            foreach (var person in pinfo)
            {
                listBox1.Items.Add(person);
            }
            pictureBox1.Image = p.Photo;

        }

        private void DeleteInfo(Person p)
        {
            Form1.listP.RemoveRange(_index, 1);
            listBox1.Items.Clear();
            listBox1.Items.Add("Usunięto dane o osobie " + (_index + 1));
        }

        private void UpdateButtons()
        {
            if (_index == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (_index >= Form1.listP.Count - 1)
                button2.Enabled = false;
            else
                button2.Enabled = true;
            if (_index < 0)
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            DeleteInfo(Form1.listP[_index]);
            UpdateButtons();
            PriceSum();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            listBox1.Items.Clear();
            _index++;
            WriteInfo(Form1.listP[_index]);
            UpdateButtons();
            PriceSum();
        }

        private string PriceSum()
        {
            double _overall = 0;

            foreach (var item in Form1.listP)
            {
                _overall += (Convert.ToDouble(item.Price));
            }

            return label1.Text = "Suma kosztów: " + (_overall == 0 ? "" : _overall.ToString() + "zł");
        }
    }
}
