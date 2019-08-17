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
    public partial class PublishNotification : Form
    {
        Publisher publisher;
        public PublishNotification(Form1 form1)
        {
            
            InitializeComponent();
            publisher = form1.publisher;
        }

        private void btnPublish2_Click(object sender, EventArgs e)
        {
            txtOutput2.Clear();
            string pubMessage = txtNotificationCont2.Text;
            publisher.PublishMessage(txtOutput2,pubMessage);
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //------Delete
        private void btnPublish_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublishNotification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.Show();
        }
    }
}
