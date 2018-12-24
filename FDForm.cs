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
    public partial class FDForm : Form
    {
        public FDForm()
        {
            InitializeComponent();
            loaddate();
            
            loadmode();
        }

        private void loadmode()
        {
            // throw new NotImplementedException();
            comboBox1.Items.Add("Cash");
           comboBox1.Items.Add("Cheque");
        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal acc = Convert.ToDecimal(acctxt.Text);
            var accounts = dbe.userAccounts.Where(x => x.Account_No == acc).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(acctxt.Text);
            fdform.Mode = comboBox1.SelectedItem.ToString();
            fdform.Rupees = egptxt.Text;
            fdform.Period = Convert.ToInt32(periodtxt.Text);
            fdform.Interest_rate = Convert.ToDecimal(interesttxt.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
            fdform.Maturity_Date = (DateTime.UtcNow.AddMilliseconds(Convert.ToInt32(periodtxt.Text))).ToString("MM/dd/yyyy");
            fdform.Maturity_Amount = ((Convert.ToDecimal(egptxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(interesttxt.Text))
                / (100 * 12 * 30)) + (Convert.ToDecimal(egptxt.Text));
            dbe.FDs.Add(fdform);
            decimal amount = Convert.ToDecimal(egptxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.balance);
            decimal fdamount = totalamount - amount;
            accounts.balance = fdamount;
            dbe.SaveChanges();
            MessageBox.Show("FD Started Now");
        }
    }
}
