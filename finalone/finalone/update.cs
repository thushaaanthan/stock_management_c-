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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void lout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginA ss = new loginA();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main ss = new main();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtpriceu.Text != "" && txtquantityu.Text != "")
            {
                SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
                con3.Open();
                string update = "update product set price=@price,quantity=quantity+@quantity,date=@date where id=@id";
                SqlCommand det = new SqlCommand(update, con3);

                det.Parameters.AddWithValue("@price", txtpriceu.Text);
                det.Parameters.AddWithValue("@quantity", txtquantityu.Text);
                det.Parameters.AddWithValue("@id", txtid.Text);
                det.Parameters.AddWithValue("@date", exdateu.Text);

                int x;
                x = det.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("You Update all  details sucessfully :-)");
                    txtid.Text = "";
                    txtpriceu.Text = "";
                    txtquantityu.Text = "";
                }
                else
                {
                    MessageBox.Show("You have some problem in updating please try again later.. ");
                    txtid.Text = "";
                    txtpriceu.Text = "";
                    txtquantityu.Text = "";
                }


            }
            else
            {
                MessageBox.Show("Please Fill All The Detailes !");
                txtid.Text = "";
                txtpriceu.Text = "";
                txtquantityu.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.product);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.searchit(this.productDataSet.product, textBox1.Text);
            }
            catch
            {
                
            }

        }

        
    }
}
