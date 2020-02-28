using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using(Test11Entities1 db = new Test11Entities1())
            {

                var Admins = db.admin.AsNoTracking().FirstOrDefault(u => u.Name == textBox1.Text && u.Password == textBox2.Text);
              
                if (Admins == null)
                {
                    MessageBox.Show("Введен неверный логин или пароль");
                    return;
                }

                else
                {
                    this.Hide();
                    Form3 k = new Form3();
                    k.Show();
                }

            }
            }
        }
    }

