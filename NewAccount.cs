using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class NewAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities1 BSE;
        MemoryStream ms;
        public NewAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Cairo");
            comboBox1.Items.Add("Alex");
            comboBox1.Items.Add("Sharm");
            comboBox1.Items.Add("Fowa");
        }


        private void loaddate()
        {
            // throw new NotImplementedException();
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities1();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);
        }

        private void newAccount_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opebdlg = new OpenFileDialog();
            if(opebdlg.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(opebdlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if(maleradio.Checked)
            {
                gender = "male";
            }
            else if(femaleradio.Checked)
            {
                gender = "female";
            }
            else if (otherradio.Checked)
            {
                gender = "other";
            }
            if (marriedradio.Checked)
            {
                m_status = "married";
            }
            else if (unmarriedradio.Checked)
            {
                m_status = "Un-Married";
            }
            BSE = new banking_dbEntities1();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Address = addtxt.Text;
            acc.District = disttxt.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.maritial_status = m_status;
            acc.Mother_Name = mothertxt.Text;
            acc.Father_Name = fathertxt.Text;
            acc.balance = Convert.ToDecimal(balanacetxt.Text);
            acc.Date = datelbl.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("File Saved");
        }

     
    }
}
