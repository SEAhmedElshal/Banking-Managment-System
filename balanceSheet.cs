using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class balanceSheet : Form
    {
        public balanceSheet()
        {
            InitializeComponent();
        }

        private void balanceSheet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in dbe.debits where u.AccountNo == b select u);
            dataGridView1.DataSource = item.ToList();           
            var item2 = (from u in dbe.Transfers where u.Account_No== b select u);
            dataGridView3.DataSource = item2.ToList();

        }
    }
}
