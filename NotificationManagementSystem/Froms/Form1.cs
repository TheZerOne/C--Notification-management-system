using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
    public partial class Form1 : Form
    {
        
        public Publisher publisher;
        public CustomerRepository Customers;

        public Form1()
        {

            InitializeComponent();
            publisher = new Publisher();
            Customers = new CustomerRepository();
             
        }

        private void btnManageSubsc_Click(object sender, EventArgs e)
        {
            SubscribeForm subscribeForm = new SubscribeForm(this);
            this.Hide();
            subscribeForm.ShowDialog(this);
            
            
        }

        private void btnPublishNoti_Click(object sender, EventArgs e)
        {
            PublishNotification publishForm = new PublishNotification(this);
            this.Hide();
            publishForm.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!Customers.EmailCustomers.Any() && !Customers.MobileCustomers.Any())
            {
                btnPublishNoti.Enabled = false;
            }
            else
            {
                btnPublishNoti.Enabled = true;
            }
        }
    }
}
