using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DEMOekz
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int doll = 50;

        static string connectString = "Data Source=DESKTOP-IBPB0S8\\SQLEXPRESS;Initial Catalog=DEMO;Integrated Security=True";

        private SqlConnection myConnection;

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEMODataSet1.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.dEMODataSet1.Runner);
            timer1.Start();

            textBox8.Text = doll.ToString();
            label15.Text = "$"+ doll.ToString();

            textBox1.ForeColor = System.Drawing.Color.Gray;
            textBox1.Text = "Ваше имя";
            textBox3.ForeColor = System.Drawing.Color.Gray;
            textBox3.Text = "Владелец карты";
            textBox5.ForeColor = System.Drawing.Color.Gray;
            textBox5.Text = "01";
            textBox6.ForeColor = System.Drawing.Color.Gray;
            textBox6.Text = "2017";
            textBox7.ForeColor = System.Drawing.Color.Gray;
            textBox7.Text = "123";

        }
        private void Button4_Click(object sender, EventArgs e)
        {
            doll += 10;
            textBox8.Text = doll.ToString();
            label15.Text = "$" + doll.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (doll <= 0)
            {
                MessageBox.Show("lox");
            }
            else
            {
                doll -= 10;
            }
            textBox8.Text = doll.ToString();
            label15.Text = "$"+ doll.ToString();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ваше имя")
            {
                textBox1.Clear();
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Text = "";
            }
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Владелец карты")
            {
                textBox3.Clear();
                textBox3.ForeColor = System.Drawing.Color.Black;
                textBox3.Text = "";
            }
        }

        private void TextBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "01")
            {
                textBox5.Clear();
                textBox5.ForeColor = System.Drawing.Color.Black;
                textBox5.Text = "";
            }
        }

        private void TextBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "2017")
            {
                textBox6.Clear();
                textBox6.ForeColor = System.Drawing.Color.Black;
                textBox6.Text = "";
            }
        }

        private void TextBox7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "123")
            {
                textBox7.Clear();
                textBox7.ForeColor = System.Drawing.Color.Black;
                textBox7.Text = "";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Program.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов и " + delta.Minutes.ToString() + " минут до старта марафона ";
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = System.Drawing.Color.Gray;
                textBox1.Text = "Ваше имя";
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.ForeColor = System.Drawing.Color.Gray;
                textBox3.Text = "Владелец карты";
            }
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.ForeColor = System.Drawing.Color.Gray;
                textBox5.Text = "01";
            }
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.ForeColor = System.Drawing.Color.Gray;
                textBox6.Text = "2017";
            }
        }

        private void TextBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.ForeColor = System.Drawing.Color.Gray;
                textBox7.Text = "123";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int ok = 1;

            if (textBox1.Text == "Ваше имя")
            {
                MessageBox.Show("Вы не заполнили поле 'Ваше имя'");
                ok = 0;
            }
            else ok = 1;

            if (textBox3.Text == "Владелец карты")
            {
                MessageBox.Show("Вы не заполнили поле 'Владелец карты'");
                ok = 0;
            }
            else ok = 1;

            if (maskedTextBox1.MaskFull == false)
            {
                MessageBox.Show("Вы не заполнили поле 'Номер карты'");
                ok = 0;
            }
            else ok = 1;

            DateTime t = DateTime.Now;
            int y = int.Parse(textBox6.Text);
            int m = int.Parse(textBox5.Text);
            bool inv = true;

            if (t.Year <= y)
            { 
                if (t.Year == y)
                {
                    if (t.Month > m) inv = false;
                }
                
            }
            else inv = false;

            if (inv == true) ok = 1;
            else
            {
                ok = 0;
                MessageBox.Show("Карта не действительна");
            }

            MessageBox.Show(ok.ToString());

            
            string query1 = "INSERT INTO Sponsorship (SponsorName, RegistrationId, Amount) VALUES ('Фонд Кошек','" + comboBox1.SelectedIndex + "','" +doll + "')";
            SqlCommand command2 = new SqlCommand(query1, myConnection);
            try
            {
                if (command2.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data updated successfully");



                    Sponsorship_confirmation f6 = new Sponsorship_confirmation();
                    f6.txt5 = comboBox1.SelectedValue.ToString();
                    f6.txt14 = "123";
                    f6.hww = doll;
                    f6.Show();
                    Hide();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();


            this.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //отмена
            Form f1 = Application.OpenForms[0];
            f1.Show();
            this.Close();
        }
    }
}
