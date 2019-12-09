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
    public partial class how_long_is_a_marathon : Form
    {
        public how_long_is_a_marathon()
        {
            InitializeComponent();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            label3.Text = "Болид F1";
            pictureBox3.Image = pictureBox4.Image;
            double speed = 42000 / (345/3.6);
            int min = (int)speed / 60;
            int hur = min / 60;
            min = min - (hur * 60);
            label5.Text = "Максимальная скорость болида F1 345км/ч. Это займет "+hur+"часов "+min+"минут чтобы завершить 42km марафон";
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            label3.Text = "Червяк";
            pictureBox3.Image = pictureBox5.Image;
            double speed = 42000 / (0.03 / 3.6);
            int min = (int)speed / 60;
            int hur = min / 60;
            min = min - (hur * 60);
            label5.Text = "Максимальная скорость червяка 0.03км/ч. Это займет " + hur + "часов " + min + "минут чтобы завершить 42km марафон";
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            label3.Text = "Ленивец";
            pictureBox3.Image = pictureBox6.Image;
            double speed = 42000 / (0.12 / 3.6);
            int min = (int)speed / 60;
            int hur = min / 60;
            min = min - (hur * 60);
            label5.Text = "Максимальная скорость ленивца 0.12км/ч. Это займет " + hur + "часов " + min + "минут чтобы завершить 42km марафон";
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            label3.Text = "Капибара";
            pictureBox3.Image = pictureBox7.Image;
            double speed = 42000 / (35 / 3.6);
            int min = (int)speed / 60;
            int hur = min / 60;
            min = min - (hur * 60);
            label5.Text = "Максимальная скорость капибары 35км/ч. Это займет " + hur + "часов " + min + "минут чтобы завершить 42km марафон";
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            label3.Text = "Ягуар";
            pictureBox3.Image = pictureBox8.Image;
            double speed = 42000 / (80 / 3.6);
            int min = (int)speed / 60;
            int hur = min / 60;
            min = min - (hur * 60);
            label5.Text = "Максимальная скорость ягуара 80км/ч. Это займет " + hur + "часов " + min + "минут чтобы завершить 42km марафон";
        }




        private void PictureBox13_Click(object sender, EventArgs e)
        {
            label3.Text = "Airbus A380";
            pictureBox3.Image = pictureBox13.Image;
            int way = (int)42000 / 73;
            label5.Text = "Длина Airbus A380 73 метра. Это займет "+way+"шт из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            label3.Text = "Шлепки";
            pictureBox3.Image = pictureBox12.Image;
            double way = 42000 / 0.245;
            way = (int)way;
            label5.Text = "Длина шлепок 0.245 метра. Это займет " + way + "шт из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            label3.Text = "Футбольное поле";
            pictureBox3.Image = pictureBox11.Image;
            int way = (int)42000 / 105;
            label5.Text = "Длина футбольного поля 105 метроа. Это займет " + way + "шт из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            label3.Text = "Рональдо";
            pictureBox3.Image = pictureBox10.Image;
            double way = 42000 / 1.81;
            way = (int)way;
            label5.Text = "Длина Рональдо 1.81 метра. Это займет " + way + "шт из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            label3.Text = "Автобус";
            pictureBox3.Image = pictureBox9.Image;
            int way = (int)42000 / 10;
            label5.Text = "Длина атобуса 10 метров. Это займет " + way + "шт из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void How_long_is_a_marathon_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form6 f6 = new Form6();
            //f6.Show();
            Form f6 = Application.OpenForms[1];
            f6.Show();


        }

        private void How_long_is_a_marathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Form6 f6 = new Form6();
            //f6.Show();
            //this.Close();

            Form f6 = Application.OpenForms[1];
            f6.Show();


            this.Close();

        }
    }
}
