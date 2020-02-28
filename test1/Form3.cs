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
                var MenuPizzas = db.MenuPizza;
                var SizePizzas = db.SizePizza;
                foreach (MenuPizza pl in MenuPizzas)
                {

                    comboBox1.Items.Add(pl.Pizza);

                }
                foreach (SizePizza tl in SizePizzas)
                {

                    comboBox2.Items.Add(tl.Size);

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
            using (Test11Entities1 db = new Test11Entities1())
            {
                var MenuPizzas = db.MenuPizza;
                int i = comboBox1.SelectedIndex + 1;
               

                foreach (MenuPizza pl in MenuPizzas)
                {
                    if (i == pl.id)
                    {
                        label5.Text = pl.Cost;


                    }


                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (Test11Entities1 db = new Test11Entities1())
            {
                var MenuPizzas = db.MenuPizza;
                int i = comboBox1.SelectedIndex + 1;


                foreach (MenuPizza pl in MenuPizzas)
                {
                    if (i == pl.id)
                    {
                        label5.Text = pl.Cost;


                    }


                }
            }
        }
    }
}
