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
    public partial class loginA : Form
    {
        public loginA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
            
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from login where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlCommand cmd2 = new SqlCommand("Select Count(*) from product where quantity<=50", con3);
                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = cmd2;
                DataTable dt2 = new DataTable();
                
                sda2.Fill(dt2);
                if (dt2.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Your some product has less than 50 quantity item so check it and refill it !");
                }

                this.Hide();
                main ss = new main();
                ss.Show();
            }
            else
            {
                
               
                    MessageBox.Show("Your username or password is incorrect ! please enter the correct username and password :-)");
                txtuname.Text = "";
                txtpword.Text = "";
            }
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepass ss = new changepass();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            first ss = new first();
            ss.Show();
        }

        private void loginA_Load(object sender, EventArgs e)
        {

        }
    }
}
