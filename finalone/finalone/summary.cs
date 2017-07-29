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
    public partial class summary : Form
    {
        public summary()
        {
            InitializeComponent();
            load_table();
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
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("Select * from product", con3);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;
            data.DataSource = bsource;
            sda.Update(dt);
        }

        private void checkqu_Click(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("Select * from product where quantity<=50", con3);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;
            data.DataSource = bsource;
            sda.Update(dt);
        }

        public void load_table()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("Select * from product", con3);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;
            data.DataSource = bsource;
            sda.Update(dt);

        }

       
        private void summary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.product);

        }

       

    }
}
