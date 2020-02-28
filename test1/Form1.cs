using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using(IDbConnection connection = new  SqlConnection())
            {

            }
        }

        // Глобальные переменные 
        private int x1, y1, x2, y2, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);
        // Перерисовка формы
        private void Form1_Paint(object sender,    PaintEventArgs e)
        {    Graphics g = e.Graphics;
            // Рисуем секундную стрелку 
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            a -= 0.1;
            // Уменьшаем угол на 0,1 радиану 
            // Новые координаты конца стрелки 
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            // Принудительный вызов события Paint   
            Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using(Test11Entities1 db = new Test11Entities1())
            {

                


                List<admin> admins = new List<admin>();

                admins.Add(new admin { Name = textBox1.Text, Password = textBox2.Text });



                db.admin.AddRange(admins);
                db.SaveChanges();

                this.Hide();
                Form2 m = new Form2();
                m.Show();



            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 m = new Form2();
            m.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 150;
            // Радиус стрелки
            a = 0;
            // Угол поворота стрелки
            // Определяем центр формы – начало стрелки  
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            // Конец стрелки 
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1- (int)(r * Math.Sin(a));
        }    // Действия при очередном «тике» таймера
       
    }
}
