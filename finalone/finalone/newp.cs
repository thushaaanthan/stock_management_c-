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

namespace finalone
{
    public partial class newp : Form
    {
        public newp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main ss = new main();
            ss.Show();
        }

        private void lout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginA ss = new loginA();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtprice.Text != "" && txtquantity.Text != "")
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
                con2.Open();
                string ins = "INSERT INTO product(Id,name,price,quantity,date) VALUES(@id,@name,@price,@quantity,@date)";



                SqlCommand det = new SqlCommand(ins, con2);
                det.Parameters.AddWithValue("@id", txtid.Text);
                det.Parameters.AddWithValue("@name", txtname.Text);
                det.Parameters.AddWithValue("@price", txtprice.Text);
                det.Parameters.AddWithValue("@quantity", txtquantity.Text);
                det.Parameters.AddWithValue("@date", exdate.Text);


                int x = det.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("You Enter details sucessfully :-)");
                    txtid.Text = "";
                    txtname.Text = "";
                    txtprice.Text = "";
                    txtquantity.Text = "";

                }
                else
                {
                    MessageBox.Show("You have some problem in updating please try again later.. ");
                    txtid.Text = "";
                    txtname.Text = "";
                    txtprice.Text = "";
                    txtquantity.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Please Fill All The Detailes !");
                txtid.Text = "";
                txtname.Text = "";
                txtprice.Text = "";
                txtquantity.Text = "";
            }
        }
    }
}
