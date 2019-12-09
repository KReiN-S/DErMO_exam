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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();

            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //участвовал ранее
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //новый участник
            register_runner fr = new register_runner();
            fr.Show();
            this.Close();

 
        }
    }
}
