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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();


            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //login

            //sql query get with login and pass get "who this gay" and goto nyzhnaya forma

            //mne len` delat` formi
            //AAAAAAAAAAAAAAAAAAAAAAAAAAA
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //cancel

            Form f1 = Application.OpenForms[0];
            f1.Show();

            this.Close();
        }
    }
}
