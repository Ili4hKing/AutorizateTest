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

        private void Button1_Click(object sender, EventArgs e)
        {
            using(Test11Context db = new Test11Context())
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
    }
}
