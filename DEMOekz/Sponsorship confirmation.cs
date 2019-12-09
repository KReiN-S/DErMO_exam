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
    public partial class Sponsorship_confirmation : Form
    {
        public Sponsorship_confirmation()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[1];
            f1.Show();


            this.Close();
        }
        public string txt14;
        public string txt5;
        public int hww;

        private void Sponsorship_confirmation_Load(object sender, EventArgs e)
        {
            label14.Text = "Фонд кошек";
            label5.Text = txt5;
            label15.Text = "$" + hww;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[1];
            f1.Show();


            this.Close();
        }
    }
}
