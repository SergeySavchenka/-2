using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Карта_Савченко
{
    public partial class Form1 : Form
    {
    
   
        public Form1()
        {

            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Toalet_picture.Visible = false;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = false;
            Drinks_picture.Visible = false;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 1\nМЦК Лужники";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = false;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);


        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 2\nНоводевичей монастырь";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = true;
            Information_picture.Visible = true;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);
        }

       

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 3\nМетро Киевская";
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 4\nМИД";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = true;
            Information_picture.Visible = false;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 397);
            label2.Location = new Point(763, 429);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 5\nПарк Горького";
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = false;
            Information_picture.Visible = true;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 6\nЗдания РАН";
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 7\nМетро Воробьёвы горы";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = true;
            Information_picture.Visible = true;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label6.Text = "Чекпоинт 8\nСтадион Лужники";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            Toalet_picture.Visible = true;
            Medicine_picture.Visible = true;
            Information_picture.Visible = true;
            Energy_picture.Visible = true;
            Drinks_picture.Visible = true;
            Medicine_picture.Location = new Point(638, 493);
            label2.Location = new Point(763, 524);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label6.Text = "Финиш";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            Toalet_picture.Visible = false;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = false;
            Drinks_picture.Visible = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label6.Text = "Старт гонки\nСамба полный марафон";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            Toalet_picture.Visible = false;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = false;
            Drinks_picture.Visible = false;

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label6.Text = "Старт гонки\nДжонго половина марафона";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            Toalet_picture.Visible = false;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = false;
            Drinks_picture.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label6.Text = "Старт гонки\nКапоэра 5км веселые старты";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            Toalet_picture.Visible = false;
            Medicine_picture.Visible = false;
            Information_picture.Visible = false;
            Energy_picture.Visible = false;
            Drinks_picture.Visible = false;
        }
    }
}
