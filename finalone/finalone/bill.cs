using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalone
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.product);

        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Search1(this.productDataSet.product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
