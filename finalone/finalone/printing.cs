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
    public partial class printing : Form
    {
        public printing(String bal,String amo,String all)
        {
            InitializeComponent();
            totalpay.Text = all;
            use.Text = amo;
            balance.Text = bal;
        }

        private void printing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            billing ss = new billing();
            ss.Show();
        }
    }
}
