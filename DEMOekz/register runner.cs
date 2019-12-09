using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace DEMOekz
{
    public partial class register_runner : Form
    {
        public register_runner()
        {
            InitializeComponent();
        }

        private void Register_runner_Load(object sender, EventArgs e)
        {

        }

        public static string email;

        DateTime dateNow = DateTime.Now;

        public static bool isValidEmail(string email) {
            string pattern = "[0-9a-zA-Z\\-_\\.]+@[a-zAZ0-9\\-_\\.]+.[a-z]{2-6}";
            Match is_match = Regex.Match(email, pattern);
            if (is_match.Success)
                return true;
            else
                return false;
        }

        public static bool isValidPassword(string password) {
            string pattern = "(?=.*[0-9])(?=.*[a-z])(?=.*[!@#$%^]).{6,}";
            Match is_match = Regex.Match(password, pattern);
            if (is_match.Success)
                return true;
            else
                return false;
        }






        private void Button5_Click(object sender, EventArgs e)
        {
            if (isValidEmail(textBox1.Text) == false) MessageBox.Show("Email должен соответсвовать формату x@x.x");
            else
            {
                if (textBox2.Text != textBox3.Text) MessageBox.Show("Пароли не совпадают!");
                else
                {
                    if (isValidPassword(textBox2.Text) == false) MessageBox.Show("Пароль должен содержать 1 строчную, 1 заглавную, 1 цифру и один спец символ");
                    else
                    {
                        if (dateNow.Year - dateTimePicker1.Value.Year < 10 || dateTimePicker1.Value.Year > dateNow.Year)
                            MessageBox.Show("Участнику должно быть больше 10 лет!");
                        else
                        {
                            //подтверждение регистрации


                        }
                    }

                }
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

            this.Close();
        }
    }
}
