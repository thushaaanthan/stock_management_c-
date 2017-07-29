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
    public partial class changepass : Form
    {
       
        public changepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from login where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'", con);

           
            DataTable dt = new DataTable();
            sda.Fill(dt);
           
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                changepasscon ss = new changepasscon();
                ss.Show();
            }
            else
            {

                MessageBox.Show("Your username or password is incorrect ! please enter the correct username and password :-)");
                txtuname.Text = "";
                txtpword.Text = "";
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from login where secquestion='" + secq.Text + "'", con);

           
            DataTable dt = new DataTable();
            sda.Fill(dt);
           
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                changepasscon ss = new changepasscon();
                ss.Show();
            }
            else
            {

                MessageBox.Show("Your Security question Answer is incorrect ! please enter the correct Answer :-)");
                txtuname.Text = "";
                txtpword.Text = "";
            }

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                    this.Hide();
                    loginA ss = new loginA();
                    ss.Show();
        }
        }
    }

