using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Окончание трасы";
            label2.Text = "Поздравляем!";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "МЦК Лужники";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;




        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            label1.Text = "Новодевичей\n монастырь";
            label2.Text = " Особенности: \n\n Стенд питья\n\nЭнергетические\n батончики\n\n Туалет\n\n Информация\n\n Медицинский пункт ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Метро Киевская";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики\n\n Туалет";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox14.Visible = true;
            pictureBox13.Visible= false;
            pictureBox15.Visible= false;    
          

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "МИД";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики\n\n Туалет\n\n\n Медицинский пункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox13.Visible= false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "Парк Горького";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики\n\n Туалет\n\n Информация";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "Здания РАН";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики\n\n Туалет\n ";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox14.Visible = true;
            pictureBox13.Visible = false;   
            pictureBox15.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "Метро Воробевы\n  горы";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики\n\n Туалет\n\n Информация\n\n Медицинский пункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "Стадион Лужники";
            label2.Text = " Особенности: \n\n Стенд питья\n\n Энергетические\n батончики\n\n Туалет\n\n Информация\n\n Медицинский пункт";
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label1.Text = "Дистанция:";
            label2.Text = " Начало трассы,\n удачи! ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            label1.Text = "Дистанция:";
            label2.Text = " Вы прошли почти\n половину,\n не сдавайтесь ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            label1.Text = "Дистанция:";
            label2.Text = " Первые 5 км \nпройдены,\n поднажмите ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;

        }

      
    }
}
