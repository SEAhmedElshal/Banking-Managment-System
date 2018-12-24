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
    public partial class BankCredit : Form
    {
        public BankCredit()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            // throw new NotImplementedException();
            modetxt.Items.Add("Cash");
            modetxt.Items.Add("Cheque");
        }

        private void loaddate()
        {
            // throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            NewAccount acc = new NewAccount();
            Deposite dp = new Deposite();
            dp.Date = datelbl.Text;
            dp.AccountNo =acctxt.Text;
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = modetxt.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(amounttxt.Text);
            context.Deposites.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
            item.balance = item.balance + Convert.ToDecimal(amounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("Deposite Money Sucessfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 context = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts where u.Account_No == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.balance);


        }
    }
}
