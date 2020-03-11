using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            using (IDbConnection connection = new SqlConnection())
            {

            }

            using (Test11Entities1 db = new Test11Entities1())
            {
                var pacients = db.Pachienti;
                var Doctors = db.Doctor;
                foreach (Pachienti pl in pacients)
                {

                    comboBox1.Items.Add(pl.Familia + " "+ pl.Name +" "+ pl.Otchestvo);

                }
                foreach (Doctor tl in Doctors)
                {

                    comboBox2.Items.Add(tl.FIO +", "+tl.Specialnost);
                    

                }




            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          


                
            }
        }
    }
