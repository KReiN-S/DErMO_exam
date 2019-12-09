using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOekz
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

                TimeSpan delta = Program.start - DateTime.Now;
                label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов и " + delta.Minutes.ToString() + " минут до старта марафона ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
           

            this.Close();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            how_long_is_a_marathon f7 = new how_long_is_a_marathon();
            f7.Show();

            this.Hide();
        }
    }
}
