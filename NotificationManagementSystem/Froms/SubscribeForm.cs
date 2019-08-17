using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
    public partial class SubscribeForm : Form
    {
        public Publisher publisher;
        public CustomerRepository CustomersList;
        public SendViaEmail eCustomer;
        public SendViaMobile pCustomer;



        public SubscribeForm(Form1 form1)
        {
            InitializeComponent();
  
            this.publisher = form1.publisher;
            this.CustomersList = form1.Customers;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {

            //Subscribe email
            if(chkEmail.Checked && VerifyEmail())
            {
                string email = txtEmail.Text;
                eCustomer = new SendViaEmail(email);
                
                //validate duplicate
                if (!(IsDuplicate<SendViaEmail>(eCustomer)))
                {
                    eCustomer.Subscribe(publisher);
                    CustomersList.EmailCustomers.Add(eCustomer);
                    MessageBox.Show(String.Format("Your email {0} Subscribed successfully", email));
                    
                }
                else
                {
                    MessageBox.Show("email already subscribed");
                }                        
            }

            //subscribe mobile
            if (chkMobile.Checked && VerifyMobile())
            {
                string mobile = txtMobile.Text;
                pCustomer = new SendViaMobile(mobile);
                //validate duplicate

                if (!(IsDuplicate<SendViaMobile>(pCustomer)))
                {
                    pCustomer.Subscribe(publisher);
                    CustomersList.MobileCustomers.Add(pCustomer);
                    MessageBox.Show(String.Format("Your mobile {0} Subscribed successfully", mobile));                    

                }
                else
                {
                    MessageBox.Show("Mobile already subscribed");
                   
                }
            }

        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            if (chkEmail.Checked)
            {
                
                string email = txtEmail.Text;
                eCustomer = new SendViaEmail(email);
                SendViaEmail removeItem = null;

                foreach (SendViaEmail item in CustomersList.EmailCustomers)
                {
                    // MessageBox.Show(string.Format("{0}",string.Compare(item.ToString(),pCustomer.ToString())));

                    if (string.Compare(item.ToString(), eCustomer.ToString()) == 0)
                    {
                        item.UnSubscribe(publisher);
                        removeItem = item;

                        MessageBox.Show(String.Format("Email {0} UnSubscribed", email));
                        
                    }

                }
                CustomersList.EmailCustomers.Remove(removeItem);
            }

            if (chkMobile.Checked)
            {
                
                string mobile = txtMobile.Text;
                pCustomer = new SendViaMobile(mobile);
                SendViaMobile removeItem =null;


                foreach (SendViaMobile item in CustomersList.MobileCustomers)
                {
                   // MessageBox.Show(string.Format("{0}",string.Compare(item.ToString(),pCustomer.ToString())));

                    if(string.Compare(item.ToString(), pCustomer.ToString()) == 0)
                    {
                        item.UnSubscribe(publisher);
                        removeItem = item;
                        MessageBox.Show(String.Format("Mobile {0} UnSubscribed", mobile));
                       
                    }

                }
                CustomersList.MobileCustomers.Remove(removeItem);

            }





        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Show();
            Show();
            this.Close();
        }


        private bool VerifyEmail()
        {
            string email = txtEmail.Text;
            try
            {
                if (email.Split('@')[1].Contains("."))
                {
                    lblErrorEmail.Text = "";
                    return true;
                }
                else
                {
                    lblErrorEmail.Text = "Invalid Email Address";
                    this.lblErrorEmail.BackColor = Color.Red;
                   // lblErrorEmail.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                lblErrorEmail.Text = "Invalid Email Address";
                return false;
            }
        }



        private bool VerifyMobile()
        {
            string mobile = txtMobile.Text;

            if (Regex.Match(mobile, @"^\d{3}[\-]\d{3}[\-]\d{4}$").Success)
            {
                lblErrorMobile.Text = "";
                return true;
            }
            else
            {
                lblErrorMobile.Text = "Invalid Mobile Number";
                return false;
            }
        }


        private bool IsDuplicate<E>(E e)
        {

            foreach (SendViaEmail item in CustomersList.EmailCustomers)
            {
                if (string.Compare(item.ToString(), e.ToString()) == 0)
                {
                    return true;
                }
            }

            foreach (SendViaMobile item in CustomersList.MobileCustomers)
            {
                if (string.Compare(item.ToString(), e.ToString()) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void SubscribeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.Show();
        }

        private void SubscribeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
