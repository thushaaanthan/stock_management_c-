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
    public partial class billing : Form
    {
        public billing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.search(this.productDataSet.product, search.Text);
                listBox1.Update();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.product);

        }

        double tot = 0;

        private void submit_Click_1(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TSA10\Documents\product.mdf;Integrated Security=True;Connect Timeout=30");
            con3.Open();
            string update = "update product set quantity=quantity-@quantity,date=@date where id=@id";
            SqlCommand det = new SqlCommand(update, con3);

            det.Parameters.AddWithValue("@id", idTextBox1.Text);
            det.Parameters.AddWithValue("@quantity", quantityTextBox.Text);

            
           /* int x;
            x = det.ExecuteNonQuery();

            if (x > 0)
            {
                MessageBox.Show("You Update all  details sucessfully :-)");
              
            }*/
            double mull, price, quan;
            price = double.Parse(priceTextBox.Text);
            quan = double.Parse(quantityTextBox.Text);
            mull = price * quan;
            tot+= mull;
            ttotal.Text = tot.ToString();
            listBox1.Update();
        }

        private void lout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginW ss = new loginW();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            first ss = new first();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double balance;
            total.Text=tot.ToString();
            balance = double.Parse(paid.Text) - double.Parse(total.Text);
           
            
            this.Hide();
            printing ss = new printing(balance.ToString(), tot.ToString(), paid.Text);
            ss.Show();
            tot = 0;
        }

        

        
       

       
    }
}
