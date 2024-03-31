using System.Windows.Forms;

using System;
using AdamBień_Wypożyczalnia.MyClasses;
using AdamBień_Wypożyczalnia.MyUserControls;

namespace AdamBień_Wypożyczalnia
{
    public partial class Form1 : Form
    {
        private AdultUC _adult = new AdultUC();
        private ChildUC _child = new ChildUC();
        private UserControl1 _UserControl1 = new UserControl1();
        public static List<Person> listP = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Width = 1030;
            Height = 1000;
            panel2.Width = 971;
            panel2.Height = 800;
            panel2.Controls.Add(_adult);
            _adult.Visible = true;
            _adult.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Width = 1030;
            Height = 1000;
            panel2.Width = 971;
            panel2.Height = 800;
            panel2.Controls.Add(_child);
            _child.Visible = true;
            _child.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Width = 1015;
            Height = 710;
            panel2.Width = 971;
            panel2.Height = 600;
            panel2.Controls.Add(_UserControl1);
            _UserControl1.Visible = true;
            _UserControl1.BringToFront();
        }
    }
}