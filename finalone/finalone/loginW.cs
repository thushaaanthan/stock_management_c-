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
    public partial class loginW : Form
    {
        public loginW()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\loginw.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from loginw where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                billing ss = new billing();
                ss.Show();
            }
            else
            {

                MessageBox.Show("Your username or password is incorrect ! please enter the correct username and password :-)");
                txtuname.Text = "";
                txtpword.Text = "";
            }
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

      

        private void loginW_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepassw ss = new changepassw();
            ss.Show();
        }
    }
}
