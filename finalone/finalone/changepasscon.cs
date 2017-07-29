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
    public partial class changepasscon : Form
    {
        public changepasscon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (txtuname.Text != "" && txtpword.Text != "" && secq.Text != "" && txtouname.Text != "")
            {
                SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
                con3.Open();
                string update = "update login set username=@name,password=@password,secquestion=@question where username=@id";
                SqlCommand det = new SqlCommand(update, con3);

                 det.Parameters.AddWithValue("@id", txtouname.Text);
                det.Parameters.AddWithValue("@name", txtuname.Text);
                det.Parameters.AddWithValue("@password", txtpword.Text);
                det.Parameters.AddWithValue("@question", secq.Text);
             

                int x;
                x = det.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("You Update all  details sucessfully :-)");
                   
                     this.Hide();
                    loginW ss = new loginW();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("You have some problem in updating please try again later.. ");
                    txtuname.Text = "";
                    txtpword.Text = "";
                    secq.Text = "";
                }


            }
            else
            {
                MessageBox.Show("Please Fill All The Detailes !");
                txtuname.Text = "";
                txtpword.Text = "";
                secq.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            main ss = new main();
            ss.Show();
        }
        
    }
}
