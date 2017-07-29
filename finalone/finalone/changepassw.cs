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
    public partial class changepassw : Form
    {
        public changepassw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\loginw.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(*) from loginw where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'", con1);

            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            if (dt1.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                changepassconw ss = new changepassconw();
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
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\loginw.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(*) from loginw where secquestion='" + secq.Text + "'", con1);

            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            if (dt1.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                changepassconw ss = new changepassconw();
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
            loginW ss = new loginW();
            ss.Show();
        }
    }
}
